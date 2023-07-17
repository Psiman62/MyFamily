using MetaFac.CG4.Attributes;

namespace MyFamily.Schema
{
    [Entity(1)]
    public class LocalProfile
    {
        [Member(1)]
        public string? ProfileName { get; }
    }
}