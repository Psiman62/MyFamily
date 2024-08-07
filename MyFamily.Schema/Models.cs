﻿
using FluentModels;

namespace MyFamily.Schema
{
    [Entity(1)]
    public class LocalProfile
    {
        [Member(1)]
        public string? ProfileName { get; }
    }

    [Entity(2)]
    public class WeatherDetail
    {
        [Member(1)] public DateTime Date { get; }
        [Member(2)] public int TemperatureC { get; }
        [Member(3)] public string? Summary { get; }
    }

    [Entity(3)]
    public class WeatherBundle
    {
        [Member(1)] public string? ServerVersion { get; }
        [Member(2)] public string? StatusMessage { get; }
        [Member(3)] public WeatherDetail[]? Details { get; }
    }
}