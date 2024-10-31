using System;
using UnityEngine;

/// <summary>
/// Component responsible for storing the movement data of the ghost
/// </summary>
[RequireComponent(typeof(Rigidbody2D))]
public class GhostMovementData : MonoBehaviour
{
    /// <summary>
    /// The speed of the movement
    /// </summary>
    [SerializeField, Tooltip("The speed of the movement")]
    private float _movementSpeed = 10f;

    /// <summary>
    /// The amplitude of the sinusoidal movement
    /// </summary>
    [SerializeField, Tooltip("The amplitude of the sinusoidal movement")]
    private float _amplitude = 0.5f;

    /// <summary>
    /// The frequency of the sinusoidal movement
    /// </summary>
    [SerializeField, Tooltip("The frequency of the sinusoidal movement")]
    private float _frequency = 1f;

    [SerializeField, Tooltip("The direction of the movement")]
    private MoveDirection _direction = MoveDirection.Up;

    /// <summary>
    /// The direction of the movement
    /// </summary>
    private Vector2 _movementDirection;

    /// <summary>
    /// The Rigidbody2D component of the ghost
    /// </summary>
    private Rigidbody2D _rigidbody2D;

    /// <summary>
    /// The speed of the movement
    /// </summary>
    public float MovementSpeed => _movementSpeed;

    /// <summary>
    /// The amplitude of the sinusoidal movement
    /// </summary>
    public float Amplitude => _amplitude;

    /// <summary>
    /// The frequency of the sinusoidal movement
    /// </summary>
    public float Frequency => _frequency;

    /// <summary>
    /// The Rigidbody2D component of the ghost
    /// </summary>
    public Rigidbody2D Rigidbody2D => _rigidbody2D;

    /// <summary>
    /// The direction of the movement
    /// </summary>
    public Vector2 MovementDirection => _movementDirection;

    /// <summary>
    /// Event invoked when the movement direction is changed
    /// </summary>
    public event Action OnMovementDirectionChanged;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
    
    private void OnValidate()
    {
        ChangeDirection(_direction);
    }

    public void ChangeDirection(MoveDirection direction)
    {
        switch (direction)
        {
            case MoveDirection.Up:
                _movementDirection = Vector2.up;   // (0, 1)
                break;
            case MoveDirection.Down:
                _movementDirection = Vector2.down;  // (0, -1)
                break;
            case MoveDirection.Left:
                _movementDirection = Vector2.left;  // (-1, 0)
                break;
            case MoveDirection.Right:
                _movementDirection = Vector2.right; // (1, 0)
                break;
        }

        OnMovementDirectionChanged?.Invoke();
    }
}