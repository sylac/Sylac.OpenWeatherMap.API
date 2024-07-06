using AutoFixture;
using FluentAssertions;
using Microsoft.Extensions.Options;
using NSubstitute;
using Sylac.OpenWeatherMap.API.Abstractions;
using Sylac.OpenWeatherMap.API.Models.Responses;
using Sylac.OpenWeatherMap.API.Options;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;

namespace Sylac.OpenWeatherMap.API.UnitTests;

public class OpenWeatherMapTests
{
    [Fact]
    public void OpenWeatherMap_Constructor_ShouldCreateInstance()
    {
        // Arrange
        var options = Substitute.For<IOptions<OpenWeatherMapOptions>>();
        var openWeatherMapRestAPI = Substitute.For<IOpenWeatherMapRestAPI>();

        // Act
        var openWeatherMap = new OpenWeatherMapService(options, openWeatherMapRestAPI);

        // Assert
        openWeatherMap.Should().NotBeNull();
    }

    [Fact]
    public async Task OpenWeatherMap_GetOneCallWeatherInfoAsync_ShouldReturnWeatherInfo()
    {
        // Arrange
        var fixture = new Fixture();
        var openWeatherMapOptions = fixture.Create<OpenWeatherMapOptions>();
        var options = new OptionsWrapper<OpenWeatherMapOptions>(openWeatherMapOptions);

        var openWeatherMapRestAPI = Substitute.For<IOpenWeatherMapRestAPI>();
        var openWeatherMap = new OpenWeatherMapService(options, openWeatherMapRestAPI);

        openWeatherMapRestAPI
            .GetOneCallWeatherInfoAsync(Arg.Any<decimal>(), Arg.Any<decimal>(), Arg.Any<string>(), Arg.Any<string>(), Arg.Any<string>(), Arg.Any<string>())
            .Returns(Observable.Return(fixture.Create<OneCallWeatherInfo>()));

        // Act
        var weatherInfo = await openWeatherMap
            .GetOneCallWeatherInfoAsync((decimal)52.2297, (decimal)21.0122)
            .ToTask();

        // Assert
        weatherInfo.Should().NotBeNull();
    }

    [Fact]
    public async Task OpenWeatherMap_GetOneCallWeatherInfoAsync_ShouldReturnWeatherInfoWithCorrectValues()
    {
        // Arrange
        var latitude = (decimal)52.2297;
        var longitude = (decimal)21.0122;
        var fixture = new Fixture();
        var openWeatherMapOptions = fixture.Create<OpenWeatherMapOptions>();
        var options = new OptionsWrapper<OpenWeatherMapOptions>(openWeatherMapOptions);

        var openWeatherMapRestAPI = Substitute.For<IOpenWeatherMapRestAPI>();
        var openWeatherMap = new OpenWeatherMapService(options, openWeatherMapRestAPI);

        var oneCallWeatherInfo = fixture.Create<OneCallWeatherInfo>();
        openWeatherMapRestAPI
            .GetOneCallWeatherInfoAsync(Arg.Any<decimal>(), Arg.Any<decimal>(), Arg.Any<string>(), Arg.Any<string>(), Arg.Any<string>(), Arg.Any<string>())
            .Returns(Observable.Return(oneCallWeatherInfo));

        // Act
        var weatherInfo = await openWeatherMap
            .GetOneCallWeatherInfoAsync(latitude, longitude)
            .ToTask();

        // Assert
        weatherInfo.Should().BeEquivalentTo(oneCallWeatherInfo);
    }

    [Fact]
    public async Task OpenWeatherMap_GetOneCallWeatherInfoAsync_ShouldCallGetOneCallWeatherInfoAsyncWithCorrectValues()
    {
        // Arrange
        var latitude = (decimal)52.2297;
        var longitude = (decimal)21.0122;
        var fixture = new Fixture();
        var openWeatherMapOptions = fixture.Create<OpenWeatherMapOptions>();
        var options = new OptionsWrapper<OpenWeatherMapOptions>(openWeatherMapOptions);

        var openWeatherMapRestAPI = Substitute.For<IOpenWeatherMapRestAPI>();
        var openWeatherMap = new OpenWeatherMapService(options, openWeatherMapRestAPI);

        // Act
        await openWeatherMap
            .GetOneCallWeatherInfoAsync(latitude, longitude)
            .ToTask();

        // Assert
        await openWeatherMapRestAPI
            .Received(1)
            .GetOneCallWeatherInfoAsync(
                latitude,
                longitude,
                openWeatherMapOptions.ApiKey,
                exclude: null,
                units: openWeatherMapOptions.UnitSystem.ToQueryString(),
                language: openWeatherMapOptions.Language.ToQueryString());
    }
}
