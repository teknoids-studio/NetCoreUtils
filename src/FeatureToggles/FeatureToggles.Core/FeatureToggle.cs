namespace FeatureToggles.Core;

public class FeatureToggle
{
    /// <summary>
    /// Name of the Feature Flag
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Flag state
    /// </summary>
    public bool IsActive { get; set; }

    /// <summary>
    /// List of conditions for flag evaluation
    /// </summary>
    public FlagCondition[] Conditions { get; set; } = Array.Empty<FlagCondition>();
}