namespace FeatureToggles;

public class FeatureToggleService : IFeatureToggleService
{
    private readonly Dictionary<string, bool> _featureToggles;

    public FeatureToggleService()
    {
        _featureToggles = featureToggles;
    }
    
    Get

    public bool IsEnabled(string featureName)
    {
        return _featureToggles.ContainsKey(featureName) && _featureToggles[featureName];
    }

    public bool IsDisabled(string featureName)
    {
        return !_featureToggles.ContainsKey(featureName) || !_featureToggles[featureName];
    }
}

