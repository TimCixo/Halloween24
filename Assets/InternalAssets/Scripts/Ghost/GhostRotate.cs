using UnityEngine;

/// <summary>
/// Rotates the ghost sprite based on its movement direction.
/// </summary>
[RequireComponent(typeof(GhostMovementData))]
public class GhostRotate : MonoBehaviour
{
    private GhostMovementData _ghostMovementData;

    private void Start()
    {
        _ghostMovementData = GetComponent<GhostMovementData>();

        RotateSprite();

        _ghostMovementData.OnMovementDirectionChanged += RotateSprite;
    }

    /// <summary>
    /// Rotates the sprite based on the given direction.
    /// </summary>
    /// <param name="direction">The movement direction of the ghost.</param>
    private void RotateSprite()
    {
        Vector2 direction = _ghostMovementData.MovementDirection;

        float angleY = direction.x > 0 ? 0f : 180f;
        float angleX = direction.y >= 0 ? 0f : 180f;

        transform.rotation = Quaternion.Euler(angleX, angleY, 0f);
    }
}
