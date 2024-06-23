using FluentAssertions;
using Sylac.OpenWeatherMap.API.Models.Responses;
using Sylac.OpenWeatherMap.API.Models.Weather;
using Sylac.OpenWeatherMap.API.UnitTests.Helpers;
using System.Text.Json;

namespace Sylac.OpenWeatherMap.API.UnitTests;

public class ModelsParsingTests
{
    [Theory]
    [InlineData(typeof(WeatherCondition))]
    [InlineData(typeof(CurrentWeather))]
    [InlineData(typeof(MinuteWeatherForecast))]
    [InlineData(typeof(HourlyWeatherForecast))]
    [InlineData(typeof(DailyWeatherForecast))]
    [InlineData(typeof(WeatherAlert))]
    [InlineData(typeof(OneCallWeatherInfo))]
    public void ResponseParsing_ValidJson_ReturnsParsedResponseObject(Type weatherDataType)
    {
        // Arrange
        if (!ExampleOneCallAPIResponse.WeatherDataDictionary.ContainsKey(weatherDataType))
        {
            Assert.Fail($"No example data found for {weatherDataType.Name}");
        }

        (var json, var reference) = ExampleOneCallAPIResponse.WeatherDataDictionary[weatherDataType];

        // Act
        var result = JsonSerializer.Deserialize(json, reference.GetType());

        // Assert
        Assert.NotNull(result);
        result.Should().BeEquivalentTo(reference);
    }

}
