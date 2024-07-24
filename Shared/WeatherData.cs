namespace MyFamily.Models.JsonSystemText
{
    public partial class WeatherDetail
    {
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    }
}
