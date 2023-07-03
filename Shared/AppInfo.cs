using System;

namespace BlazorApp.Shared
{
    public class AppInfo
    {
        private readonly static AppInfo _global = new AppInfo();
        public static AppInfo Global => _global;

        public readonly string Name;
        public readonly string AppVersion;
        public readonly string CG4Version;

        private AppInfo()
        {
            Name = "MyFamily";
            AppVersion = typeof(MyFamily.Models.Contracts.ILocalProfile).Assembly.GetName().Version.ToString();
            CG4Version = MetaFac.CG4.Runtime.BuildInfo.Instance.AssemblyFileVersion;
        }

    }
}