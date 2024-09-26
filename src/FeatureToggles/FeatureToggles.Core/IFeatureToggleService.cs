using FeatureToggles.Core.Models;

namespace FeatureToggles.Core;

public interface IFeatureToggleService
{
    Task<bool> IsEnabled(string featureName);
    Task<bool> IsDisabled(string featureName);
    
    Task LoadFeatureToggles();
    
    Task<FeatureToggle[]> GetFeatureFlagsAsync();
}