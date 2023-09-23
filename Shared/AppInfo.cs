namespace MyFamily.Models
{
    public class AppInfo
    {
        private readonly static AppInfo _global = new AppInfo();
        public static AppInfo Global => _global;

        public readonly string Name;
        public readonly string AppVersion;
        public readonly string CG4Version;
        public readonly string CG4CommitDate;

        private AppInfo()
        {
            Name = "MyFamily";
            AppVersion = typeof(Contracts.ILocalProfile).Assembly.GetName().Version.ToString();
            CG4Version = MetaFac.CG4.Runtime.BuildInfo.Instance.AssemblyFileVersion;
            CG4CommitDate = MetaFac.CG4.Runtime.BuildInfo.Instance.GitCommitDate;
        }

    }
}