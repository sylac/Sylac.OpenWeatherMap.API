namespace Sylac.OpenWeatherMap.API.Options
{
    /// <summary>
    /// Options for the OpenWeatherMap API.
    /// </summary>
    public sealed class OpenWeatherMapOptions
    {
        /// <summary>
        /// The base URL of the OpenWeatherMap API.
        /// </summary>
        public string BaseUrl { get; set; } = "https://api.openweathermap.org";

        /// <summary>
        /// The API key that should be used to authenticate with the OpenWeatherMap API.
        /// </summary>
        public string ApiKey { get; set; } = string.Empty;

        /// <summary>
        /// The units of measurement that should be used.
        /// </summary>
        public UnitSystem UnitSystem { get; set; } = UnitSystem.Standard;

        /// <summary>
        /// The language that should be used.
        /// </summary>
        public Language Language { get; set; } = Language.English;

    }
}
