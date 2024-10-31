using UnityEngine;
using TMPro;

/// <summary>
/// Component responsible for counting and displaying points.
/// </summary>
public class PointCounter : MonoBehaviour
{
    [SerializeField, Tooltip("The text component that displays the counter")]
    private TextMeshProUGUI counterText;
    private uint _points = 0;

    /// <summary>
    /// Initializes the points counter and updates the UI text.
    /// </summary>
    private void Start()
    {
        _points = 0;
        UpdateCounterText();
    }

    /// <summary>
    /// Updates the text component with the current points value.
    /// </summary>
    private void UpdateCounterText()
    {
        counterText.text = $"Points: {_points}";
    }

    /// <summary>
    /// Increases the points counter by the specified amount and updates the UI text.
    /// </summary>
    /// <param name="count">The amount to increase the counter by.</param>
    public void IncreaseCounter(uint count)
    {
        _points += count;
        
        UpdateCounterText();
    }
}