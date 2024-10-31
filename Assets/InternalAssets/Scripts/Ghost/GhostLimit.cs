using UnityEngine;

/// <summary>
/// Component responsible for killing the ghost when it goes out of screen bounds
/// </summary>
public class GhostLimit : MonoBehaviour
{
    /// <summary>
    /// Time to kill in seconds
    /// </summary>
    [SerializeField, Tooltip("Time to kill in seconds")]
    private float _timeToKill = 2f;
    [SerializeField, Tooltip("Range of screen bounds")]
    private float _killDistance = 0.5f;

    private Camera _mainCamera;
    private float _timeOutOfBounds = 0f;

    private void Start()
    {
        _mainCamera = Camera.main;
    }

    private void Update()
    {
        if (IsOutOfScreenBounds())
        {
            _timeOutOfBounds += Time.deltaTime;
            
            if (_timeOutOfBounds >= _timeToKill)
            {
                KillGhost();
            }
        }
        else
        {
            _timeOutOfBounds = 0f;
        }
    }

    /// <summary>
    /// Check if the ghost is out of screen bounds
    /// </summary>
    /// <returns>True if the ghost is out of screen bounds, false otherwise</returns>
    private bool IsOutOfScreenBounds()
    {
        Vector2 screenPoint = _mainCamera.WorldToViewportPoint(transform.position);
        
        bool isOutOfScreenX = screenPoint.x < -_killDistance || screenPoint.x > 1 + _killDistance;
        bool isOutOfScreenY = screenPoint.y < -_killDistance || screenPoint.y > 1 + _killDistance;
        
        return isOutOfScreenX || isOutOfScreenY;
    }

    /// <summary>
    /// Kill the ghost without showing the death effect
    /// </summary>
    private void KillGhost()
    {
        GhostDespawn ghostDeath = GetComponent<GhostDespawn>();

        ghostDeath?.KillWithoutEffect();
    }
}

