using Sylac.OpenWeatherMap.API.Converters;
using System.Text.Json.Serialization;

namespace Sylac.OpenWeatherMap.API.Models.Temperature
{
    /// <summary>
    /// Base forecast temperature information
    /// </summary>
    public abstract record BaseForecastTemperature
    {
        /// <summary>
        /// Morning temperature
        /// </summary>
        [JsonPropertyName("morn")]
        [JsonConverter(typeof(TemperatureValueConverter))]
        public TemperatureValue Morning { get; init; }

        /// <summary>
        /// Day temperature
        /// </summary>
        [JsonPropertyName("day")]
        [JsonConverter(typeof(TemperatureValueConverter))]
        public TemperatureValue Day { get; init; }

        /// <summary>
        /// Evening temperature
        /// </summary>
        [JsonPropertyName("eve")]
        [JsonConverter(typeof(TemperatureValueConverter))]
        public TemperatureValue Evening { get; init; }

        /// <summary>
        /// Night temperature
        /// </summary>
        [JsonPropertyName("night")]
        [JsonConverter(typeof(TemperatureValueConverter))]
        public TemperatureValue Night { get; init; }
    }
}
