using FeatureToggles.Core.Models;
using Microsoft.Extensions.Caching.Memory;

namespace FeatureToggles.Core;

public abstract class FeatureToggleServiceBase(IMemoryCache cache) : IFeatureToggleService
{
    private readonly IMemoryCache _cache = cache;

    public abstract Task<bool> IsEnabled(string featureName);

    public abstract Task<bool> IsDisabled(string featureName);

    public abstract Task<FeatureToggle[]> GetFeatureFlagsAsync();
}