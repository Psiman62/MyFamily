#region Notices
// <auto-generated>
// Warning: This file was automatically generated. Changes to this file may
// cause incorrect behavior and will be lost when this file is regenerated.
// </auto-generated>
// <information>
// This file was generated using MetaFac.CG4 tools and user supplied metadata.
// Generator: Contracts.2.8
// Metadata : MyFamily.Schema
// </information>
#endregion
#nullable enable
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CS8019 // Unnecessary using directive
using MetaFac.CG4.Runtime;
using MetaFac.Memory;
using MetaFac.Mutability;
using System;
using System.Collections.Generic;
using System.Numerics;

namespace MyFamily.Models.Contracts
{
    public partial interface ILocalProfile : IEntityBase
    {
        String? ProfileName { get; }
    }
}
