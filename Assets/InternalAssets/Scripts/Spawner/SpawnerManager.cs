using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Менеджер спаунера, який відповідає за спаун гостей на екрані.
/// </summary>
[RequireComponent(typeof(SpawnerData))]
public class SpawnerManager : MonoBehaviour
{
    /// <summary>
    /// Камера, яка використовується для розрахунку координат спауну.
    /// </summary>
    private Camera _mainCamera;

    /// <summary>
    /// Дані спаунера.
    /// </summary>
    private SpawnerData _spawnerData;

    /// <summary>
    /// Час, що залишився до наступного спауну.
    /// </summary>
    private float _spawnerTime = 0;

    private void Start()
    {
        _spawnerData = GetComponent<SpawnerData>();
        _mainCamera = Camera.main;

        InitSpawnPoints();
    }

    private void Update()
    {
        if (_spawnerTime >= _spawnerData.SpawnDelay)
        {
            SpawnRandomGhost();

            _spawnerTime = 0;
        }

        _spawnerTime += Time.deltaTime * Random.Range(1f, 1.6f);
    }

    /// <summary>
    /// Ініціалізує точки спауну.
    /// </summary>
    private void InitSpawnPoints()
    {
        float distance = _spawnerData.SpawnDistance;
        GameObject verticalSpawnpoint = _spawnerData.VerticalSpawnpoint;
        GameObject horizontalSpawnpoint = _spawnerData.HorizontalSpawnpoint;

        Vector2 screenPoint = _mainCamera.ViewportToWorldPoint(new Vector2(-distance, 0.5f));
        
        verticalSpawnpoint.transform.position = screenPoint;

        screenPoint = _mainCamera.ViewportToWorldPoint(new Vector2(0.5f, -distance / 2));

        horizontalSpawnpoint.transform.position = screenPoint;
    }


    /// <summary>
    /// Спаунить випадкового гosta.
    /// </summary>
    private void SpawnRandomGhost()
    {
        bool isVertical = GetChance(50);

        SpawnGhost(isVertical);
    }

    /// <summary>
    /// Спаунить гosta за заданими параметрами.
    /// </summary>
    /// <param name="isVertical">Чи спаунити гosta вертикально.</param>
    private void SpawnGhost(bool isVertical)
    {
        GameObject spawnpoint = isVertical ? _spawnerData.VerticalSpawnpoint : _spawnerData.HorizontalSpawnpoint;
        bool specialGhost = GetChance(_spawnerData.SpecialGhostChance);
        List<GameObject> ghosts;
        GameObject ghost;

        if(specialGhost)
        {
            ghosts = _spawnerData.SpecialGhosts;
        }
        else
        {
            ghosts = isVertical ? _spawnerData.VerticalGhosts : _spawnerData.HorizontalGhosts;
        }

        ghost = ghosts[Random.Range(0, ghosts.Count)];

        Vector2 screenPoint = _mainCamera.ViewportToWorldPoint(new Vector2(
            isVertical ? Random.Range(0.1f, 0.9f) : spawnpoint.transform.position.x,
            isVertical ? spawnpoint.transform.position.y : Random.Range(0.1f, 0.9f)
        ));

        MoveDirection direction = isVertical ? MoveDirection.Up : MoveDirection.Right;

        if (GetChance(50))
        {
            screenPoint *= -1;
            direction = isVertical ? MoveDirection.Down : MoveDirection.Left;
        }

        GameObject temp = Instantiate(ghost, screenPoint, Quaternion.identity);
        
        temp.GetComponent<GhostMovementData>().ChangeDirection(direction);
    }

    /// <summary>
    /// Отримати випадкове значення з заданим шансом.
    /// </summary>
    /// <param name="chance">Шанс.</param>
    /// <returns>True, якщо випадкове значення менше за заданий шанс, false інакше.</returns>
    private bool GetChance(uint chance)
    {
        return Random.Range(1, 101) <= chance;
    }
}
