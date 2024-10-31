using UnityEngine;

/// <summary>
/// Component responsible for killing the ghost
/// </summary>
public class GhostDespawn : MonoBehaviour
{
    /// <summary>
    /// Effect reproduced upon death
    /// </summary>
    [SerializeField, Tooltip("Effect reproduced upon death")]
    private GameObject _deathEffect;
    /// <summary>
    /// Number of points received when killing the ghost
    /// </summary>
    [SerializeField, Tooltip("Number of points received when killing the ghost")]
    private uint _points = 10;

    private AudioSource _audioSource;

    /// <summary>
    /// Gets the number of points received when killing the ghost
    /// </summary>
    public uint Points => _points;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    /// <summary>
    /// Kill the ghost
    /// </summary>
    public void Kill()
    {
        Instantiate(_deathEffect, transform.position, transform.rotation);

        Destroy(gameObject);
    }

    /// <summary>
    /// Kill the ghost without showing the death effect
    /// </summary>
    public void KillWithoutEffect()
    {
        Destroy(gameObject);
    }
}