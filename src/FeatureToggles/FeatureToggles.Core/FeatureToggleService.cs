namespace FeatureToggles.Core;

public class FeatureToggleService : IFeatureToggleService
{
    private readonly Dictionary<string, bool> _featureToggles;

    public FeatureToggleService()
    {
        _featureToggles = new Dictionary<string, bool>();
    }

    public bool IsEnabled(string featureName)
    {
        return _featureToggles.ContainsKey(featureName) && _featureToggles[featureName];
    }

    public bool IsDisabled(string featureName)
    {
        return !_featureToggles.ContainsKey(featureName) || !_featureToggles[featureName];
    }
    
    private Task LoadFeatureToggles()
    {
        // Load feature toggles from configuration
    }
}

