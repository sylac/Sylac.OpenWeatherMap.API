using Sylac.OpenWeatherMap.API.Converters;
using Sylac.OpenWeatherMap.API.Models.Temperature;
using System.Text.Json.Serialization;

namespace Sylac.OpenWeatherMap.API.Models.Weather;

/// <summary>
/// Weather forecast for a specific day
/// </summary>
public sealed record DailyWeatherForecast
{
    /// <summary>
    /// Time of the forecasted data, Unix, UTC
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
    /// Moonrise time, Unix, UTC
    /// </summary>
    [JsonPropertyName("moonrise")]
    [JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime Moonrise { get; init; }

    /// <summary>
    /// Moonset time, Unix, UTC
    /// </summary>
    [JsonPropertyName("moonset")]
    [JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime Moonset { get; init; }

    /// <summary>
    /// Moon phase
    /// </summary>
    [JsonPropertyName("moon_phase")]
    public double MoonPhase { get; init; }

    /// <summary>
    /// Human-readable description of the weather conditions for the day.
    /// </summary>
    [JsonPropertyName("summary")]
    public string Summary { get; init; } = string.Empty;

    /// <summary>
    /// Temperature
    /// </summary>
    [JsonPropertyName("temp")]
    public DailyTemperature Temperature { get; init; } = new();

    /// <summary>
    /// Feels like temperature
    /// </summary>
    [JsonPropertyName("feels_like")]
    public FeelsLikeTemperature FeelsLike { get; init; } = new();

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
    /// Atmospheric temperature (varying according to pressure and humidity) below which water droplets begin to condense and dew can form
    /// </summary>
    [JsonPropertyName("dew_point")]
    public double DewPoint { get; init; }

    /// <summary>
    /// Wind speed
    /// </summary>
    [JsonPropertyName("wind_speed")]
    public double WindSpeed { get; init; }

    /// <summary>
    /// Wind direction, degrees (meteorological)
    /// </summary>
    [JsonPropertyName("wind_deg")]
    public int WindDeg { get; init; }

    /// <summary>
    /// Wind gust
    /// </summary>
    [JsonPropertyName("wind_gust")]
    public double WindGust { get; init; }

    /// <summary>
    /// Weather conditions
    /// </summary>
    [JsonPropertyName("weather")]
    public WeatherCondition[] Weather { get; init; } = [];

    /// <summary>
    /// Cloudiness, %
    /// </summary>
    [JsonPropertyName("clouds")]
    public int Cloudiness { get; init; }

    /// <summary>
    /// Probability of precipitation
    /// </summary>
    [JsonPropertyName("pop")]
    public double ProbabilityOfPrecipitation { get; init; }

    /// <summary>
    /// Precipitation volume
    /// </summary>
    [JsonPropertyName("rain")]
    public double Rain { get; init; }

    /// <summary>
    /// UV index
    /// </summary>
    [JsonPropertyName("uvi")]
    public double Uvi { get; init; }
}
