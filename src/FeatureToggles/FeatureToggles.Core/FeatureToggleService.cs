namespace FeatureToggles.Core;

public class FeatureToggleService : IFeatureToggleService
{
    private readonly Dictionary<string, bool> _featureToggles;

    public FeatureToggleService()
    {
        _featureToggles = new Dictionary<string, bool>();
    }

    public Task<bool> IsEnabled(string featureName)
    {
        return Task.FromResult(_featureToggles.ContainsKey(featureName) && _featureToggles[featureName]);
    }

    public Task<bool> IsDisabled(string featureName)
    {
        return Task.FromResult(!_featureToggles.ContainsKey(featureName) || !_featureToggles[featureName]);
    }
    
    public Task LoadFeatureToggles()
    {
        // Load feature toggles from configuration
        return Task.CompletedTask;
    }
}

