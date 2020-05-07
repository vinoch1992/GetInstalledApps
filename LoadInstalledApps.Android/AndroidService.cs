using System.Collections.Generic;
using Android.Content.PM;
using LoadInstalledApps.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(AndroidService))]
namespace LoadInstalledApps.Droid
{
    public class AndroidService : IAndroidService
    {
        public List<InApp> GetIntalledApps()
        {
            List<InApp> inApps = new List<InApp>();
            IList<ApplicationInfo> apps = Android.App.Application.Context.PackageManager.GetInstalledApplications(PackageInfoFlags.MatchAll);
            for (int i = 0; i < apps.Count; i++)
            {
                inApps.Add(new InApp(apps[i].LoadLabel(Android.App.Application.Context.PackageManager), apps[i].PackageName));
            }
            return inApps;
        }
    }
}
