namespace Sylac.OpenWeatherMap.API.Models.Temperature
{
    /// <summary>
    /// Temperature value.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="unit"></param>
    public readonly struct TemperatureValue(double value, TemperatureUnit unit)
    {
        /// <summary>
        /// The temperature value.
        /// </summary>
        public double Value { get; init; } = value;
        /// <summary>
        /// The temperature unit.
        /// </summary>
        public TemperatureUnit Unit { get; init; } = unit;

        /// <summary>
        /// The temperature in Celsius.
        /// </summary>
        public double Celsius => Unit switch
        {
            TemperatureUnit.Celsius => Value,
            TemperatureUnit.Fahrenheit => (Value - 32) * 5 / 9,
            TemperatureUnit.Kelvin => Value - 273.15,
            _ => throw new NotImplementedException()
        };

        /// <summary>
        /// The temperature in Fahrenheit.
        /// </summary>
        public double Fahrenheit => Unit switch
        {
            TemperatureUnit.Celsius => Value * 9 / 5 + 32,
            TemperatureUnit.Fahrenheit => Value,
            TemperatureUnit.Kelvin => Value * 9 / 5 - 459.67,
            _ => throw new NotImplementedException()
        };

        /// <summary>
        /// The temperature in Kelvin.
        /// </summary>
        public double Kelvin => Unit switch
        {
            TemperatureUnit.Celsius => Value + 273.15,
            TemperatureUnit.Fahrenheit => (Value + 459.67) * 5 / 9,
            TemperatureUnit.Kelvin => Value,
            _ => throw new NotImplementedException()
        };
    }
}
