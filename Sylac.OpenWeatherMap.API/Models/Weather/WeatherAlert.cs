using Sylac.OpenWeatherMap.API.Converters;
using System.Text.Json.Serialization;

namespace Sylac.OpenWeatherMap.API.Models.Weather
{
    /// <summary>
    /// Weather alert information
    /// </summary>
    public sealed record WeatherAlert
    {
        /// <summary>
        /// Name of the alert source
        /// </summary>
        [JsonPropertyName("sender_name")]
        public string SenderName { get; init; } = string.Empty;

        /// <summary>
        /// Alert event name
        /// </summary>
        [JsonPropertyName("event")]
        public string Event { get; init; } = string.Empty;

        /// <summary>
        /// Date and time of the start of the alert, Unix, UTC
        /// </summary>
        [JsonPropertyName("start")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Start { get; init; }

        /// <summary>
        /// Date and time of the end of the alert, Unix, UTC
        /// </summary>
        [JsonPropertyName("end")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime End { get; init; }

        /// <summary>
        /// Description of the alert
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; init; } = string.Empty;

        /// <summary>
        /// Array of strings representing the names of the alert feature
        /// </summary>
        [JsonPropertyName("tags")]
        public string[] Tags { get; init; } = [];
    }
}
