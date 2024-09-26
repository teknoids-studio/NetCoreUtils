using FeatureToggles.Core;
using FeatureToggles.Core.Models;
using Microsoft.Extensions.Caching.Memory;

namespace InMemoryFeatureToggles;

public class InMemoryFeatureToggleService() : FeatureToggleServiceBase(new MemoryCache(new MemoryCacheOptions()))
{
    public override Task<bool> IsEnabled(string featureName)
    {
        throw new NotImplementedException();
    }

    public override Task<bool> IsDisabled(string featureName)
    {
        throw new NotImplementedException();
    }

    public override Task LoadFeatureToggles()
    {
        throw new NotImplementedException();
    }

    public override Task<FeatureToggle[]> GetFeatureFlagsAsync()
    {
        throw new NotImplementedException();
    }
}