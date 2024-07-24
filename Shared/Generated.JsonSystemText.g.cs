#region Notices
// <auto-generated>
// Warning: This file was automatically generated. Changes to this file may
// cause incorrect behavior and will be lost when this file is regenerated.
// </auto-generated>
// <information>
// This file was generated using MetaFac.CG4 tools and user supplied metadata.
// Generator: JsonSystemText.2.8
// Metadata : MyFamily.Schema
// </information>
#endregion
#nullable enable
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CS8019 // Unnecessary using directive
using MetaFac.Mutability;
using MetaFac.CG4.Runtime;
using MetaFac.CG4.Runtime.JsonSystemText;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Numerics;
using System.Text.Json.Serialization;
using MyFamily.Models.Contracts;
using MetaFac.Memory;

namespace MyFamily.Models.JsonSystemText
{


    public abstract class EntityBase : IFreezable, IEntityBase
    {
        public static EntityBase Empty => throw new NotSupportedException();
        public const int EntityTag = 0;
        public EntityBase() { }
        public EntityBase(EntityBase? source) { }
        public EntityBase(IEntityBase? source) { }
        public void CopyFrom(IEntityBase? source) { }
        protected abstract int OnGetEntityTag();
        public int GetEntityTag() => OnGetEntityTag();
        public bool Equals(EntityBase? other) => true;
        public override int GetHashCode() => 0;

        public bool IsFreezable() => false;
        public bool IsFrozen() => false;
        public void Freeze() { }
        public bool TryFreeze() => true;
    }


    public sealed class LocalProfile_Factory : IEntityFactory<ILocalProfile, LocalProfile>
    {
        private static readonly LocalProfile_Factory _instance = new LocalProfile_Factory();
        public static LocalProfile_Factory Instance => _instance;
        public LocalProfile? CreateFrom(ILocalProfile? source) => (source is null) ? null : new LocalProfile(source);
        public LocalProfile Empty => new LocalProfile();
    }
    public partial class LocalProfile : EntityBase, ILocalProfile, IEquatable<LocalProfile>
    {
        public new const int EntityTag = 1;
        protected override int OnGetEntityTag() => EntityTag;

        private String? field_ProfileName;
        String? ILocalProfile.ProfileName => field_ProfileName;
        public String? ProfileName
        {
            get => field_ProfileName;
            set => field_ProfileName = value;
        }

        public LocalProfile() : base()
        {
        }

        public LocalProfile(LocalProfile? source) : base(source)
        {
            if (source is null) throw new ArgumentNullException(nameof(source));
            field_ProfileName = source.ProfileName;
        }

        public LocalProfile(ILocalProfile? source) : base(source)
        {
            if (source is null) throw new ArgumentNullException(nameof(source));
            field_ProfileName = source.ProfileName;
        }

        public void CopyFrom(ILocalProfile? source)
        {
            if (source is null) return;
            base.CopyFrom(source);
            field_ProfileName = source.ProfileName;
        }

        public bool Equals(LocalProfile? other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if (!base.Equals(other)) return false;
            if (!ProfileName.ValueEquals(other.ProfileName)) return false;
            return true;
        }

        public override bool Equals(object? obj) => obj is LocalProfile other && Equals(other);

        public override int GetHashCode()
        {
            HashCode hc = new HashCode();
            hc.Add(base.GetHashCode());
            hc.Add(ProfileName.CalcHashUnary());
            return hc.ToHashCode();
        }
    }

    public sealed class WeatherData_Factory : IEntityFactory<IWeatherData, WeatherData>
    {
        private static readonly WeatherData_Factory _instance = new WeatherData_Factory();
        public static WeatherData_Factory Instance => _instance;
        public WeatherData? CreateFrom(IWeatherData? source) => (source is null) ? null : new WeatherData(source);
        public WeatherData Empty => new WeatherData();
    }
    public partial class WeatherData : EntityBase, IWeatherData, IEquatable<WeatherData>
    {
        public new const int EntityTag = 2;
        protected override int OnGetEntityTag() => EntityTag;

        private DateTime field_Date;
        DateTime IWeatherData.Date { get => field_Date; }
        public DateTime Date
        {
            get => field_Date;
            set => field_Date = value;
        }
        private Int32 field_TemperatureC;
        Int32 IWeatherData.TemperatureC { get => field_TemperatureC; }
        public Int32 TemperatureC
        {
            get => field_TemperatureC;
            set => field_TemperatureC = value;
        }
        private String? field_Summary;
        String? IWeatherData.Summary => field_Summary;
        public String? Summary
        {
            get => field_Summary;
            set => field_Summary = value;
        }

        public WeatherData() : base()
        {
        }

        public WeatherData(WeatherData? source) : base(source)
        {
            if (source is null) throw new ArgumentNullException(nameof(source));
            field_Date = source.Date;
            field_TemperatureC = source.TemperatureC;
            field_Summary = source.Summary;
        }

        public WeatherData(IWeatherData? source) : base(source)
        {
            if (source is null) throw new ArgumentNullException(nameof(source));
            field_Date = source.Date;
            field_TemperatureC = source.TemperatureC;
            field_Summary = source.Summary;
        }

        public void CopyFrom(IWeatherData? source)
        {
            if (source is null) return;
            base.CopyFrom(source);
            field_Date = source.Date;
            field_TemperatureC = source.TemperatureC;
            field_Summary = source.Summary;
        }

        public bool Equals(WeatherData? other)
        {
            if (other is null) return false;
            if (ReferenceEquals(other, this)) return true;
            if (!base.Equals(other)) return false;
            if (!Date.ValueEquals(other.Date)) return false;
            if (!TemperatureC.ValueEquals(other.TemperatureC)) return false;
            if (!Summary.ValueEquals(other.Summary)) return false;
            return true;
        }

        public override bool Equals(object? obj) => obj is WeatherData other && Equals(other);

        public override int GetHashCode()
        {
            HashCode hc = new HashCode();
            hc.Add(base.GetHashCode());
            hc.Add(Date.CalcHashUnary());
            hc.Add(TemperatureC.CalcHashUnary());
            hc.Add(Summary.CalcHashUnary());
            return hc.ToHashCode();
        }
    }


}
