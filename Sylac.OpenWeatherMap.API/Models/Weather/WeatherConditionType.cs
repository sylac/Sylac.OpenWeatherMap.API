namespace Sylac.OpenWeatherMap.API.Models.Weather
{
    /// <summary>
    /// Weather condition type.
    /// </summary>
    public enum WeatherConditionType
    {
        /// <summary>
        /// Unknown weather condition
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// Thunderstorm weather condition
        /// </summary>
        Thunderstorm,

        /// <summary>
        /// Drizzle weather condition
        /// </summary>
        Drizzle,

        /// <summary>
        /// Rain weather condition
        /// </summary>
        Rain,

        /// <summary>
        /// Snow weather condition
        /// </summary>
        Snow,

        /// <summary>
        /// Mist weather condition
        /// </summary>
        Atmosphere,

        /// <summary>
        /// Clear weather condition
        /// </summary>
        Clear,

        /// <summary>
        /// Clouds weather condition
        /// </summary>
        Clouds
    }
}
