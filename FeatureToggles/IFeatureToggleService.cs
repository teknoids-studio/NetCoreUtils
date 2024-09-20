namespace FeatureToggles;

public interface IFeatureToggleService
{
    bool IsEnabled(string featureName);
    bool IsDisabled(string featureName);
}