using FeatureToggles.Core;
using FeatureToggles.Core.Models;
using Microsoft.Extensions.Caching.Memory;

namespace S3FileFeatureToggleService;

public class S3FeatureToggleService() : FeatureToggleServiceBase(new MemoryCache(new MemoryCacheOptions()))
{
    public override Task<bool> IsEnabled(string featureName)
    {
        throw new NotImplementedException();
    }

    public override Task<bool> IsDisabled(string featureName)
    {
        throw new NotImplementedException();
    }

    public override Task<FeatureToggle[]> GetFeatureFlagsAsync()
    {
        throw new NotImplementedException();
    }
}