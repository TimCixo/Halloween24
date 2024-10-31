using System;
using UnityEngine;

/// <summary>
/// Component responsible for moving the ghost in a sinusoidal line.
/// </summary>
[RequireComponent(typeof(GhostMovementData))]
public class WaggingMovement : MonoBehaviour
{
    [SerializeField, Range(0, 100), Tooltip("Chance to change the direction of the ghost")]
    private uint _chance;
    private GhostMovementData _ghostMovementData;

    /// <summary>
    /// Retrieves the GhostMovementData component at the start of the game.
    /// </summary>
    private void Start()
    {
        _ghostMovementData = GetComponent<GhostMovementData>();
    }

    /// <summary>
    /// Moves the ghost in a sinusoidal line based on its movement direction, speed and amplitude.
    /// </summary>
    private void FixedUpdate()
    {
        if (UnityEngine.Random.Range(1, 101) <= _chance)
        {
            ChangeDirection();
        }

        Move();
    }
    
    /// <summary>
    /// Calculates and sets the ghost's velocity for sinusoidal movement.
    /// </summary>
    private void Move()
    {
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
        
        _ghostMovementData.Rigidbody2D.velocity = new Vector2(horizontalMovement, verticalMovement);
    }

    /// <summary>
    /// Randomly changes the ghost's movement direction.
    /// </summary>
    private void ChangeDirection()
    {
        MoveDirection newDirection = (MoveDirection) UnityEngine.Random.Range(0, 4);

        _ghostMovementData.ChangeDirection(newDirection);
    }
}

