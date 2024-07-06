using Sylac.OpenWeatherMap.API.Converters;
using System.Text.Json.Serialization;

namespace Sylac.OpenWeatherMap.API.Models.Temperature
{
    /// <summary>
    /// Daily temperature information
    /// </summary>
    public sealed record DailyTemperature : BaseForecastTemperature
    {
        /// <summary>
        /// Min daily temperature
        /// </summary>
        [JsonPropertyName("min")]
        [JsonConverter(typeof(TemperatureValueConverter))]
        public TemperatureValue Min { get; init; }

        /// <summary>
        /// Max daily temperature
        /// </summary>
        [JsonPropertyName("max")]
        [JsonConverter(typeof(TemperatureValueConverter))]
        public TemperatureValue Max { get; init; }
    }
}
