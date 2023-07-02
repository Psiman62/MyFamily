using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorApp.Shared
{
    public class AppInfo
    {
        private readonly static AppInfo _global = new AppInfo();
        public static AppInfo Global => _global;

        public readonly string Name;
        public readonly Version Version;
        private AppInfo()
        {
            Name = "MyFamily";
            Version = new Version(1, 0, 0);
        }

    }
}