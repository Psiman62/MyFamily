#region Notices
// <auto-generated>
// Warning: This file was automatically generated. Changes to this file may
// cause incorrect behavior and will be lost when this file is regenerated.
// </auto-generated>
// <information>
// This file was generated using MetaFac.CG4 tools and user supplied metadata.
// Generator: MessagePack.2.4
// Metadata : MyFamily.Schema
// </information>
#endregion
#nullable enable
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CS8019 // Unnecessary using directive
#pragma warning disable CS8019 // Unnecessary using directive
using MetaFac.Memory;
using MetaFac.Mutability;
using MessagePack;
using MetaFac.CG4.Runtime;
using MetaFac.CG4.Runtime.MessagePack;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Runtime.CompilerServices;
using MyFamily.Models.Contracts;

namespace MyFamily.Models.MessagePack
{


    public abstract class EntityBase : IFreezable, IEntityBase, IEquatable<EntityBase>, ICopyFrom<EntityBase>
    {
        public static EntityBase Empty => throw new NotSupportedException();
        public const int EntityTag = 0;

        [MethodImpl(MethodImplOptions.NoInlining)]
        private static void ThrowIsReadonly()
        {
            throw new InvalidOperationException("Cannot set properties when frozen");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected ref T CheckNotFrozen<T>(ref T value)
        {
            if (_isFrozen) ThrowIsReadonly();
            return ref value;
        }

        public EntityBase() { }
        public EntityBase(EntityBase source) { }
        public void CopyFrom(EntityBase source) { }
        public EntityBase(IEntityBase source) { }
        protected abstract int OnGetEntityTag();
        public int GetEntityTag() => OnGetEntityTag();

        protected volatile bool _isFrozen = false;
        public bool IsFreezable() => true;
        public bool IsFrozen() => _isFrozen;
        protected virtual void OnFreeze() { }
        public void Freeze()
        {
            if (_isFrozen) return;
            OnFreeze();
            _isFrozen = true;
        }
        public bool TryFreeze()
        {
            if (_isFrozen) return false;
            OnFreeze();
            _isFrozen = true;
            return true;
        }

        public bool Equals(EntityBase? other) => true;
        public override bool Equals(object? obj) => obj is EntityBase other && this.Equals(other);
        public override int GetHashCode() => 0;
    }


    public sealed class LocalProfile_Factory : IEntityFactory<ILocalProfile, LocalProfile>
    {
        private static readonly LocalProfile_Factory _instance = new LocalProfile_Factory();
        public static LocalProfile_Factory Instance => _instance;

        public LocalProfile? CreateFrom(ILocalProfile? source)
        {
            if (source is null) return null;
            if (source is LocalProfile sibling && sibling.IsFrozen()) return sibling;
            return new LocalProfile(source);
        }

        private static readonly LocalProfile _empty = new LocalProfile().Frozen();
        public LocalProfile Empty => _empty;
    }
    [MessagePackObject]
    public partial class LocalProfile : EntityBase, ILocalProfile, IEquatable<LocalProfile>, ICopyFrom<LocalProfile>
    {
        protected override void OnFreeze()
        {
            base.OnFreeze();
        }

        public new const int EntityTag = 1;
        protected override int OnGetEntityTag() => EntityTag;

        // ---------- private fields ----------
        private String? field_ProfileName;

        // ---------- accessors ----------
        [Key(1)]
        public String? ProfileName
        {
            get => field_ProfileName;
            set => field_ProfileName = CheckNotFrozen(ref value);
        }

        // ---------- ILocalProfile methods ----------
        String? ILocalProfile.ProfileName => field_ProfileName;

        public LocalProfile()
        {
        }

        public LocalProfile(LocalProfile source) : base(source)
        {
            field_ProfileName = source.field_ProfileName;
        }

        public void CopyFrom(LocalProfile source)
        {
            base.CopyFrom(source);
            field_ProfileName = source.field_ProfileName;
        }

        public LocalProfile(ILocalProfile source) : base(source)
        {
            field_ProfileName = source.ProfileName;
        }

        public bool Equals(LocalProfile? other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if (!field_ProfileName.ValueEquals(other.field_ProfileName)) return false;
            return base.Equals(other);
        }

        public static bool operator ==(LocalProfile left, LocalProfile right)
        {
            if (left is null) return (right is null);
            return left.Equals(right);
        }

        public static bool operator !=(LocalProfile left, LocalProfile right)
        {
            if (left is null) return !(right is null);
            return !left.Equals(right);
        }

        public override bool Equals(object? obj)
        {
            return obj is LocalProfile other && Equals(other);
        }

        private int CalcHashCode()
        {
            HashCode hc = new HashCode();
            hc.Add(field_ProfileName.CalcHashUnary());
            hc.Add(base.GetHashCode());
            return hc.ToHashCode();
        }

        private int? _hashCode = null;
        public override int GetHashCode()
        {
            if (!_isFrozen) return CalcHashCode();
            if (_hashCode is null)
                _hashCode = CalcHashCode();
            return _hashCode.Value;
        }

    }


}
