using Sylac.OpenWeatherMap.API.Models.Weather;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Sylac.OpenWeatherMap.API.Converters
{
    /// <summary>
    /// Converts a weather condition type to and from JSON.
    /// </summary>
    public class WeatherConditionConverter : JsonConverter<WeatherConditionType>
    {
        /// <summary>
        /// Reads the weather condition type from the JSON reader.
        /// </summary>
        /// <param name="reader"> The JSON reader. </param>
        /// <param name="typeToConvert"> The type to convert. </param>
        /// <param name="options"> Json serializer options </param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override WeatherConditionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.String)
            {
                throw new JsonException("Expected a string value for weather condition.");
            }

            return reader.GetString() switch
            {
                "Thunderstorm" => WeatherConditionType.Thunderstorm,
                "Drizzle" => WeatherConditionType.Drizzle,
                "Rain" => WeatherConditionType.Rain,
                "Snow" => WeatherConditionType.Snow,
                "Atmosphere" => WeatherConditionType.Atmosphere,
                "Clear" => WeatherConditionType.Clear,
                "Clouds" => WeatherConditionType.Clouds,
                _ => WeatherConditionType.Unknown,
            };
        }

        /// <summary>
        /// Writes the weather condition type to the JSON writer.
        /// </summary>
        /// <param name="writer"> The JSON writer. </param>
        /// <param name="value"> The weather condition type. </param>
        /// <param name="options"> Json serializer options </param>
        public override void Write(Utf8JsonWriter writer, WeatherConditionType value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString());
        }
    }
}
