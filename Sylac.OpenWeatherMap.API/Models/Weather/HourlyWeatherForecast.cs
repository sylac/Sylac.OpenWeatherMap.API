using Sylac.OpenWeatherMap.API.Converters;
using Sylac.OpenWeatherMap.API.Models.Temperature;
using Sylac.OpenWeatherMap.API.Models.Weather.Precipitations;
using System.Text.Json.Serialization;

namespace Sylac.OpenWeatherMap.API.Models.Weather
{
    /// <summary>
    /// Hourly weather forecast data API response
    /// </summary>
    public sealed record HourlyWeatherForecast
    {
        /// <summary>
        /// Time of the forecasted data, Unix, UTC
        /// </summary>
        [JsonPropertyName("dt")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime DateTime { get; init; }

        /// <summary>
        /// Temperature. <br/>
        /// Units – default: kelvin, metric: Celsius, imperial: Fahrenheit.
        /// </summary>
        [JsonPropertyName("temp")]
        [JsonConverter(typeof(TemperatureValueConverter))]
        public TemperatureValue Temperature { get; init; }

        /// <summary>
        /// Temperature. This temperature parameter accounts for the human perception of weather. <br/>
        /// Units – default: kelvin, metric: Celsius, imperial: Fahrenheit.
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
        /// Atmospheric temperature (varying according to pressure and humidity) below which water droplets begin to condense and dew can form. <br/>
        /// Units – default: kelvin, metric: Celsius, imperial: Fahrenheit.
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
        /// Visibility, metres. <br/>
        /// The maximum value of the visibility is 10 km
        /// </summary>
        [JsonPropertyName("visibility")]
        public int Visibility { get; init; }

        /// <summary>
        /// Wind speed. <br/>
        /// Units – default: meter/sec, metric: meter/sec, imperial: miles/hour.
        /// </summary>
        [JsonPropertyName("wind_speed")]
        public double WindSpeed { get; init; }

        /// <summary>
        /// Wind gust. <br/>
        /// Units – default: meter/sec, metric: meter/sec, imperial: miles/hour.
        /// </summary>
        [JsonPropertyName("wind_gust")]
        public double? WindGust { get; init; }

        /// <summary>
        /// Wind direction, degrees (meteorological)
        /// </summary>
        [JsonPropertyName("wind_deg")]
        public int WindDeg { get; init; }

        /// <summary>
        /// Weather condition
        /// </summary>
        [JsonPropertyName("weather")]
        public WeatherCondition[] Weather { get; init; } = [];

        /// <summary>
        /// Probability of precipitation. <br/>
        /// The values of the parameter vary between 0 and 1, where 0 is equal to 0%, 1 is equal to 100%
        /// </summary>
        [JsonPropertyName("pop")]
        public double ProbabilityOfPrecipitation { get; init; }

        /// <summary>
        /// Rain volume for last hour, mm
        /// </summary>
        [JsonPropertyName("rain")]
        public Rain? Rain { get; init; }

        /// <summary>
        /// Snow volume for last hour, mm
        /// </summary>
        [JsonPropertyName("snow")]
        public Snow? Snow { get; init; }
    }
}
