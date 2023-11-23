
using FluentModels;

namespace MyFamily.Schema
{
    [Entity(1)]
    public class LocalProfile
    {
        [Member(1)]
        public string? ProfileName { get; }
    }
}