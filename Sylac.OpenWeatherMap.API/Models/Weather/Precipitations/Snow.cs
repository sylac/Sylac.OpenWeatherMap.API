using System.Text.Json.Serialization;

namespace Sylac.OpenWeatherMap.API.Models.Weather.Precipitations
{
    /// <summary>
    /// Snow information.
    /// </summary>
    public sealed record Snow
    {
        /// <summary>
        /// Snow volume for the last 1 hour, in millimeters.
        /// </summary>
        [JsonPropertyName("1h")]
        public double OneHourPrecipitation { get; init; }
    }
}
