using System.Collections.Generic;

namespace LoadInstalledApps
{
    public interface IAndroidService
    {
        List<InApp> GetIntalledApps();
    }
}
