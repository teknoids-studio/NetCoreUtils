namespace FeatureToggles.Core.Models;

public class FeatureToggle
{
    /// <summary>
    /// Name of the Feature Flag
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// Flag state
    /// </summary>
    public required bool IsActive { get; set; }
}