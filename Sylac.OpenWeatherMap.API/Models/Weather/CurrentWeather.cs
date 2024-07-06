using Sylac.OpenWeatherMap.API.Converters;
using Sylac.OpenWeatherMap.API.Models.Temperature;
using Sylac.OpenWeatherMap.API.Models.Weather.Precipitations;
using System.Text.Json.Serialization;

namespace Sylac.OpenWeatherMap.API.Models.Weather
{
    /// <summary>
    /// Current weather data API response
    /// </summary>
    public sealed record CurrentWeather
    {
        /// <summary>
        ///  Current time, Unix, UTC
        /// </summary>
        [JsonPropertyName("dt")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime DateTime { get; init; }

        /// <summary>
        /// Sunrise time, Unix, UTC
        /// </summary>
        [JsonPropertyName("sunrise")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Sunrise { get; init; }

        /// <summary>
        /// Sunset time, Unix, UTC
        /// </summary>
        [JsonPropertyName("sunset")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Sunset { get; init; }

        /// <summary>
        /// Temperature. <br/>
        /// Unit Default: Kelvin, Metric: Celsius, Imperial: Fahrenheit.
        /// </summary>
        [JsonPropertyName("temp")]
        [JsonConverter(typeof(TemperatureValueConverter))]
        public TemperatureValue Temperature { get; init; }

        /// <summary>
        /// Temperature. This temperature parameter accounts for the human perception of weather. <br/>
        /// Unit Default: Kelvin, Metric: Celsius, Imperial: Fahrenheit.
        /// </summary>
        [JsonPropertyName("feels_like")]
        [JsonConverter(typeof(TemperatureValueConverter))]
        public TemperatureValue FeelsLike { get; init; }

        /// <summary>
        /// Atmospheric pressure on the sea level, hPa
        /// </summary>
        [JsonPropertyName("pressure")]
        public int Pressure { get; init; }

        /// <summary>
        /// Humidity, %
        /// </summary>
        [JsonPropertyName("humidity")]
        public int Humidity { get; init; }

        /// <summary>
        /// Atmospheric temperature below which water droplets begin to condense and dew can form. <br/>
        /// Unit Default: Kelvin, Metric: Celsius, Imperial: Fahrenheit.
        /// </summary>
        [JsonPropertyName("dew_point")]
        public double DewPoint { get; init; }

        /// <summary>
        /// UV index
        /// </summary>
        [JsonPropertyName("uvi")]
        public double Uvi { get; init; }

        /// <summary>
        /// Cloudiness, %
        /// </summary>
        [JsonPropertyName("clouds")]
        public int Clouds { get; init; }

        /// <summary>
        /// Average visibility, meters
        /// </summary>
        [JsonPropertyName("visibility")]
        public int Visibility { get; init; }

        /// <summary>
        /// Wind speed. <br/>
        /// Unit Default: meter/sec, Metric: meter/sec, Imperial: miles/hour.
        /// </summary>
        [JsonPropertyName("wind_speed")]
        public double WindSpeed { get; init; }

        /// <summary>
        /// Wind direction, degrees (meteorological)
        /// </summary>
        [JsonPropertyName("wind_deg")]
        public int WindDeg { get; init; }

        /// <summary>
        /// Wind gust. <br/>
        /// Unit Default: meter/sec, Metric: meter/sec, Imperial: miles/hour.
        /// </summary>
        [JsonPropertyName("wind_gust")]
        public double WindGust { get; init; }

        /// <summary>
        /// Rain volume for the last 1 hour, in millimeters.
        /// </summary>
        [JsonPropertyName("rain")]
        public Rain? Rain { get; init; }

        /// <summary>
        /// Snow volume for the last 1 hour, in millimeters.
        /// </summary>
        [JsonPropertyName("snow")]
        public Snow? Snow { get; init; }

        /// <summary>
        /// Weather condition
        /// </summary>
        [JsonPropertyName("weather")]
        public WeatherCondition[] Weather { get; init; } = [];
    }
}
