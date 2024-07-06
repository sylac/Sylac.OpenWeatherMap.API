namespace Sylac.OpenWeatherMap.API.UnitTests.Helpers
{
    public class MockHttpMessageHandler(HttpResponseMessage mockResponse) : HttpMessageHandler
    {
        private readonly HttpResponseMessage _mockResponse = mockResponse;

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_mockResponse);
        }
    }
}
