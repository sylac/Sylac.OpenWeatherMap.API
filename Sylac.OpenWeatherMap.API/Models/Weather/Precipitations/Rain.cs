using System.Text.Json.Serialization;

namespace Sylac.OpenWeatherMap.API.Models.Weather.Precipitations
{
    /// <summary>
    /// Rain information.
    /// </summary>
    public sealed record Rain
    {
        /// <summary>
        /// Rain volume for the last hour, in millimeters.
        /// </summary>
        [JsonPropertyName("1h")]
        public double OneHourPrecipitation { get; init; }
    }
}
