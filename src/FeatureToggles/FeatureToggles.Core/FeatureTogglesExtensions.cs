using FeatureToggles.Core.Models;

namespace FeatureToggles.Core;

public static class FeatureToggleExtensions
{
    public static bool IsActive(this FeatureToggle[] flags, string name)
    {
        var flag = flags?.FirstOrDefault(x => x.Name.Equals(name));

        return flag is not null && flag.IsActive;
    }
}