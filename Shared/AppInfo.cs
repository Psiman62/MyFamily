namespace MyFamily.Models
{
    public class AppInfo
    {
        private readonly static AppInfo _global = new AppInfo();
        public static AppInfo Global => _global;

        public readonly string Name;
        public readonly string AppVersion;
        public readonly string CommitDate;
        public readonly string CG4Version;

        private AppInfo()
        {
            Name = "MyFamily";
            AppVersion = ThisAssembly.AssemblyFileVersion;
            CommitDate = ThisAssembly.GitCommitDate.ToString("R");
            CG4Version = MetaFac.CG4.Runtime.BuildInfo.Instance.AssemblyFileVersion;
        }

    }
}