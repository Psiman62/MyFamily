using MetaFac.CG4.Attributes;

namespace MyFamily.Schema
{
    [Entity(1)]
    public interface ILocalProfile
    {
        [Member(1)]
        string ProfileName { get; }

    }
}
