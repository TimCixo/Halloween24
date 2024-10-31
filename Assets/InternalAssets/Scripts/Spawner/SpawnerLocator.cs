using UnityEngine;

/// <summary>
/// Component responsible for positioning the spawner at the top-left corner of the screen.
/// </summary>
public class SpanwerLocator : MonoBehaviour
{
    private Camera _mainCamera;

    private void Start()
    {
        _mainCamera = Camera.main;

        MoveTo();
    }

    /// <summary>
    /// Moves the spawner to the top-left corner of the screen.
    /// </summary>
    private void MoveTo()
    {
        Vector2 screenPoint = _mainCamera.ViewportToWorldPoint(new Vector2(-0.1f, -0.05f));
        transform.position = screenPoint;
    }
}

