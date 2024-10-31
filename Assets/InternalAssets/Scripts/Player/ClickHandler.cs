using UnityEngine;

/// <summary>
/// Handles mouse click interactions with ghosts.
/// </summary>
[RequireComponent(typeof(PointCounter))]
public class ClickHandler : MonoBehaviour
{
    /// <summary>
    /// Component responsible for playing the sound effect when a ghost is clicked.
    /// </summary>
    [SerializeField, Tooltip("Component responsible for playing the sound effect when a ghost is clicked.")]
    private AudioSource _audioSource;
    /// <summary>
    /// The sound effect played when a ghost is clicked.
    /// </summary>
    [SerializeField, Tooltip("The sound effect played when a ghost is clicked.")]
    private AudioClip _clickSound;

    private PointCounter _pointCounter;

    /// <summary>
    /// Initializes the PointCounter component.
    /// </summary>
    private void Start()
    {
        _pointCounter = GetComponent<PointCounter>();
    }

    /// <summary>
    /// Checks for mouse clicks and processes interactions with ghosts.
    /// </summary>
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);

            if (hit.transform != null && hit.transform.TryGetComponent(out GhostDespawn ghostDespawn))
            {
                ghostDespawn.Kill();
    
                _audioSource.PlayOneShot(_clickSound);
                _pointCounter.IncreaseCounter(ghostDespawn.Points);
            }
            else if (hit.transform != null && hit.transform.TryGetComponent(out EvilGhostDespawn evilGhostDespawn))
            {
                evilGhostDespawn.Kill();
            }
        }
    }
}