using System.Text.Json;
using System.Text.Json.Serialization;

namespace Sylac.OpenWeatherMap.API.Converters
{
    /// <summary>
    /// Converts a Unix timestamp to a DateTime object and vice versa.
    /// </summary>
    public sealed class UnixDateTimeConverter : JsonConverter<DateTime>
    {
        /// <summary>
        /// Reads and converts the JSON to the appropriate type.
        /// </summary>
        /// <param name="reader"> The JSON reader. </param>
        /// <param name="typeToConvert"> The type to convert. </param>
        /// <param name="options"> JSON serializer options. </param>
        /// <returns> The converted object. </returns>
        /// <exception cref="JsonException"> Thrown when the JSON is invalid. </exception>
        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.Number)
            {
                throw new JsonException("Expected a number value for date time.");
            }

            return DateTimeOffset.FromUnixTimeSeconds(reader.GetInt64()).DateTime;
        }

        /// <summary>
        /// Writes the JSON representation of the object.
        /// </summary>
        /// <param name="writer"> The JSON writer. </param>
        /// <param name="value"> The value to write. </param>
        /// <param name="options"> JSON serializer options. </param>
        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        {
            writer.WriteNumberValue(new DateTimeOffset(value).ToUnixTimeSeconds());
        }
    }
}
