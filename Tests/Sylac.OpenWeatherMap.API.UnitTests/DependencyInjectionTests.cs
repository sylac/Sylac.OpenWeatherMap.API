using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Sylac.OpenWeatherMap.API.Abstractions;
using Sylac.OpenWeatherMap.API.Options;

namespace Sylac.OpenWeatherMap.API.UnitTests
{
    public class DependencyInjectionTests
    {
        [Fact]
        public void AddOpenWeatherMap_ShouldConfigureOptions()
        {
            // Arrange
            var services = new ServiceCollection();

            // Act
            services.AddOpenWeatherMap(_ => { });

            // Assert
            var serviceProvider = services.BuildServiceProvider();
            var options = serviceProvider.GetRequiredService<IOptions<OpenWeatherMapOptions>>();
            options.Should().NotBeNull();
        }

        [Fact]
        public void AddOpenWeatherMap_ShouldRegisterOpenWeatherMap()
        {
            // Arrange
            var services = new ServiceCollection();

            // Act
            services.AddOpenWeatherMap(_ => { });

            // Assert
            var serviceProvider = services.BuildServiceProvider();
            var openWeatherMap = serviceProvider.GetRequiredService<IOpenWeatherMapService>();
            openWeatherMap.Should().NotBeNull();
        }

        [Fact]
        public void AddOpenWeatherMap_ShouldRegisterOpenWeatherMapRestAPI()
        {
            // Arrange
            var services = new ServiceCollection();

            // Act
            services.AddOpenWeatherMap(_ => { });

            // Assert
            var serviceProvider = services.BuildServiceProvider();
            var openWeatherMapRestAPI = serviceProvider.GetRequiredService<IOpenWeatherMapRestAPI>();
            openWeatherMapRestAPI.Should().NotBeNull();
        }

        [Fact]
        public void AddOpenWeatherMap_ShouldRegisterOptions()
        {
            // Arrange
            var services = new ServiceCollection();

            // Act
            services.AddOpenWeatherMap(_ => { });

            // Assert
            var serviceProvider = services.BuildServiceProvider();
            var options = serviceProvider.GetRequiredService<IOptions<OpenWeatherMapOptions>>();
            options.Should().NotBeNull();
        }

        [Fact]
        public void AddOpenWeatherMap_ShouldConfigureOptionsWithAction()
        {
            // Arrange
            var services = new ServiceCollection();

            string baseUrl = "https://api.openweathermap.org";
            string apiKey = "testApiKey";
            UnitSystem unitSystem = UnitSystem.Metric;


            // Act
            services.AddOpenWeatherMap(options =>
            {
                options.BaseUrl = baseUrl;
                options.ApiKey = apiKey;
                options.UnitSystem = unitSystem;
            });

            // Assert
            var serviceProvider = services.BuildServiceProvider();
            var options = serviceProvider.GetRequiredService<IOptions<OpenWeatherMapOptions>>();
            options.Value.BaseUrl.Should().Be(baseUrl);
            options.Value.ApiKey.Should().Be(apiKey);
            options.Value.UnitSystem.Should().Be(unitSystem);
        }

        [Fact]
        public void AddOpenWeatherMap_ShouldRegisterOpenWeatherMapRestAPIBaseUrl()
        {
            // Arrange
            var services = new ServiceCollection();

            string baseUrl = "https://api.openweathermap.org";

            // Act
            services.AddOpenWeatherMap(options =>
            {
                options.BaseUrl = baseUrl;
            });

            // Assert
            var serviceProvider = services.BuildServiceProvider();
            var openWeatherMapRestAPI = serviceProvider.GetRequiredService<IOpenWeatherMapRestAPI>();
            openWeatherMapRestAPI.Should().NotBeNull();
        }
    }
}
