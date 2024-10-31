using UnityEngine;

/// <summary>
/// Component responsible for moving the ghost in a straight line.
/// </summary>
[RequireComponent(typeof(GhostMovementData))]
public class StraightMovement : MonoBehaviour
{
    private GhostMovementData _ghostMovementData;

    /// <summary>
    /// Retrieves the GhostMovementData component at the start of the game.
    /// </summary>
    private void Start()
    {
        _ghostMovementData = GetComponent<GhostMovementData>();
    }

    /// <summary>
    /// Moves the ghost in a straight line based on its movement direction and speed.
    /// </summary>
    private void FixedUpdate()
    {
        Move();
    }

    /// <summary>
    /// Moves the ghost in a straight line based on its movement direction and speed.
    /// </summary>
    private void Move()
    {
        // Calculate the movement speed based on the direction and amplitude.
        float verticalMovement;
        float horizontalMovement;
        Vector2 movementDirection = _ghostMovementData.MovementDirection;

        if (movementDirection.x == 0) // Vertical movement
        {
            horizontalMovement = Mathf.Sin(Time.time * _ghostMovementData.Frequency) * _ghostMovementData.Amplitude;
            verticalMovement = _ghostMovementData.MovementDirection.y * _ghostMovementData.MovementSpeed;
        }
        else // Horizontal movement
        {
            verticalMovement = Mathf.Sin(Time.time * _ghostMovementData.Frequency) * _ghostMovementData.Amplitude;
            horizontalMovement = _ghostMovementData.MovementDirection.x * _ghostMovementData.MovementSpeed;          
        }
        
        // Set the velocity of the ghost based on the calculated movement speed.
        _ghostMovementData.Rigidbody2D.velocity = new Vector2(horizontalMovement, verticalMovement);
    }
}