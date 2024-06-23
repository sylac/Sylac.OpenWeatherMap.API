using Sylac.OpenWeatherMap.API.Converters;
using System.Text.Json.Serialization;

namespace Sylac.OpenWeatherMap.API.Models.Weather
{
    /// <summary>
    /// Weather condition information
    /// </summary>
    public sealed record WeatherCondition
    {
        /// <summary>
        /// Weather condition id
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; init; }

        /// <summary>
        /// Group of weather parameters (Rain, Snow, Extreme etc.)
        /// </summary>
        [JsonPropertyName("main")]
        [JsonConverter(typeof(WeatherConditionConverter))]
        public WeatherConditionType Type { get; init; }

        /// <summary>
        /// Weather condition within the group
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; init; } = string.Empty;

        /// <summary>
        /// Weather icon id
        /// </summary>
        [JsonPropertyName("icon")]
        public string Icon { get; init; } = string.Empty;
    }
}


