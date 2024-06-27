namespace Sylac.OpenWeatherMap.API.Options;

/// <summary>
/// The extension methods for the <see cref="UnitSystem"/> enumeration.
/// </summary>
public static class UnitsExtensions
{
    /// <summary>
    /// Convert the units to a query string.
    /// </summary>
    /// <param name="units"> The units. </param>
    /// <returns> The query string. </returns>
    /// <exception cref="ArgumentOutOfRangeException"> Thrown when an argument is outside the range of valid values. </exception>
    public static string ToQueryString(this UnitSystem units)
    {
        return units switch
        {
            UnitSystem.Standard => "standard",
            UnitSystem.Metric => "metric",
            UnitSystem.Imperial => "imperial",
            _ => throw new ArgumentOutOfRangeException(nameof(units), units, null)
        };
    }
}
