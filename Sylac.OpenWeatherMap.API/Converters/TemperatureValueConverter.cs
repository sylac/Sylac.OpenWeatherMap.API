using Sylac.OpenWeatherMap.API.Models.Temperature;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Sylac.OpenWeatherMap.API.Converters
{
    /// <summary>
    /// Converts a <see cref="TemperatureValue"/> to and from JSON.
    /// </summary>
    public sealed class TemperatureValueConverter : JsonConverter<TemperatureValue>
    {
        /// <summary>
        /// Reads the JSON representation of the object.
        /// </summary>
        /// <param name="reader"> The reader to use. </param>
        /// <param name="typeToConvert"> The type of the object. </param>
        /// <param name="options"> The serialization options. </param>
        /// <returns> The object value. </returns>
        /// <exception cref="JsonException"> Thrown when the JSON is invalid. </exception>
        public override TemperatureValue Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.Number)
            {
                throw new JsonException("Expected number value for temperature.");
            }

            var value = reader.GetDouble();
            var unit = TemperatureUnit.Kelvin;

            return new TemperatureValue(value, unit);
        }

        /// <summary>
        /// Writes the JSON representation of the object.
        /// </summary>
        /// <param name="writer"> The writer to use. </param>
        /// <param name="value"> The value to write. </param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, TemperatureValue value, JsonSerializerOptions options)
        {
            writer.WriteNumberValue(value.Value);
        }
    }
}
