using UnityEngine;

/// <summary>
/// Class responsible for showing the game over screen.
/// </summary>
public class EndGame : MonoBehaviour
{
    /// <summary>
    /// Reference to the game over canvas prefab.
    /// </summary>
    [SerializeField, Tooltip("Reference to the game over canvas prefab.")]
    private GameObject _gameOverCanvas;

    /// <summary>
    /// Reference to the current game over canvas.
    /// </summary>
    private GameObject _currentGameOverCanvas;

    /// <summary>
    /// Shows the game over screen.
    /// </summary>
    public void ShowGameOver()
    {
        if (_currentGameOverCanvas == null)
        {
            _currentGameOverCanvas = Instantiate(_gameOverCanvas);
            
            Time.timeScale = 0f;
        }
    }
}
