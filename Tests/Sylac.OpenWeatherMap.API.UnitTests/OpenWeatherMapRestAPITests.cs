using Refit;
using Sylac.OpenWeatherMap.API.UnitTests.Helpers;
using System.Net;
using System.Reactive.Threading.Tasks;

namespace Sylac.OpenWeatherMap.API.UnitTests
{
    public class OpenWeatherMapRestAPITests
    {
        public record OneCallWeatherInfoss(double Lat, double Lon);
        public interface IOneCallWeatherInfoss
        {
            [Get("/data/3.0/onecall")]
            IObservable<OneCallWeatherInfoss> GetOneCallWeatherInfoAsync(
                [AliasAs("lat")] double latitude,
                [AliasAs("lon")] double longitude,
                [AliasAs("appid")] string apiKey);
        }


        [Fact]
        public async Task GetOneCallWeatherInfoAsync_ValidResponse_ReturnsOneCallWeatherInfo()
        {
            // Arrange
            string jsonResp = @"{""lat"":0,""lon"":0}";


            var mockResponseMessage = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(jsonResp, System.Text.Encoding.UTF8, "application/json")
            };

            var httpMessageHandler = new MockHttpMessageHandler(mockResponseMessage);

            var httpClient = new HttpClient(httpMessageHandler)
            {
                BaseAddress = new Uri("https://api.openweathermap.org")
            };

            var openWeatherMapRestAPI = RestService.For<IOneCallWeatherInfoss>(httpClient);

            // Act
            var result = await openWeatherMapRestAPI.GetOneCallWeatherInfoAsync(0, 0, "API_KEY").ToTask();

            // Assert
            Assert.NotNull(result);
        }
    }
}