using UnityEngine;

/// <summary>
/// Component responsible for killing the ghost
/// </summary>
public class EvilGhostDespawn : MonoBehaviour
{
    /// <summary>
    /// Reference to the EndGame component
    /// </summary>
    [SerializeField]
    private EndGame _endGame;

    /// <summary>
    /// Kill the ghost and show the game over screen
    /// </summary>
    public void Kill()
    {
        _endGame.ShowGameOver();
    }

    /// <summary>
    /// Kill the ghost without showing the death effect
    /// </summary>
    public void KillWithoutEffect()
    {
        Destroy(gameObject);
    }
}
