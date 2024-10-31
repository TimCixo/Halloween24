using System;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Клас, який містить налаштування спаунера.
/// </summary>
public class SpawnerData : MonoBehaviour
{
    /// <summary>
    /// Шанс спауну особливого привида.
    /// </summary>
    [SerializeField, Range(0, 100)]
    private uint _specialGhostChance = 10;

    /// <summary>
    /// Відстань від краю екрана до точки спауну.
    /// </summary>
    [SerializeField]
    private float _spawnDistance = 0.25f;

    /// <summary>
    /// Затримка між спаунами привидів.
    /// </summary>
    [SerializeField]
    private float _spawnDelay = 1f;

    /// <summary>
    /// Об'єкт, що позначає точку спауну для вертикального руху.
    /// </summary>
    [SerializeField]
    private GameObject _verticalSpawnpoint;

    /// <summary>
    /// Об'єкт, що позначає точку спауну для горизонтального руху.
    /// </summary>
    [SerializeField]
    private GameObject _horizontalSpawnpoint;

    /// <summary>
    /// Список об'єктів, які можуть бути спаунені для вертикального руху.
    /// </summary>
    [SerializeField]
    private List<GameObject> _verticalGhosts;

    /// <summary>
    /// Список об'єктів, які можуть бути спаунені для особливих привидів.
    /// </summary>
    [SerializeField]
    private List<GameObject> _specialGhosts;

    /// <summary>
    /// Список об'єктів, які можуть бути спаунені для горизонтального руху.
    /// </summary>
    [SerializeField]
    private List<GameObject> _horizontalGhosts;


    /// <summary>
    /// Шанс спауну особливого привида.
    /// </summary>
    public uint SpecialGhostChance => _specialGhostChance;

    /// <summary>
    /// Відстань від краю екрана до точки спауну.
    /// </summary>
    public float SpawnDistance => _spawnDistance;

    /// <summary>
    /// Затримка між спаунами привидів.
    /// </summary>
    public float SpawnDelay => _spawnDelay;

    /// <summary>
    /// Об'єкт, що позначає точку спауну для вертикального руху.
    /// </summary>
    public GameObject VerticalSpawnpoint => _verticalSpawnpoint;

    /// <summary>
    /// Об'єкт, що позначає точку спауну для горизонтального руху.
    /// </summary>
    public GameObject HorizontalSpawnpoint => _horizontalSpawnpoint;

    /// <summary>
    /// Список об'єктів, які можуть бути спаунені для вертикального руху.
    /// </summary>
    public List<GameObject> VerticalGhosts => _verticalGhosts;

    /// <summary>
    /// Список об'єктів, які можуть бути спаунені для особливих привидів.
    /// </summary>
    public List<GameObject> SpecialGhosts => _specialGhosts;

    /// <summary>
    /// Список об'єктів, які можуть бути спаунені для горизонтального руху.
    /// </summary>
    public List<GameObject> HorizontalGhosts => _horizontalGhosts;
}
