﻿namespace LoadInstalledApps
{
    public class InApp
    {
        public string AppName { get; set; }
        public string PackageName { get; set; }

        public InApp(string appName, string packageName)
        {
            AppName = appName;
            PackageName = packageName;
        }
    }
}
