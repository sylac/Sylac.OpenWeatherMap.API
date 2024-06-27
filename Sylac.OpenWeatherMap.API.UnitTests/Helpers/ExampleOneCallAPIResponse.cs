using Sylac.OpenWeatherMap.API.Models.Responses;
using Sylac.OpenWeatherMap.API.Models.Temperature;
using Sylac.OpenWeatherMap.API.Models.Weather;

namespace Sylac.OpenWeatherMap.API.UnitTests.Helpers
{
    internal class ExampleOneCallAPIResponse
    {
        public static Dictionary<Type, (string, object)> WeatherDataDictionary => new()
        {
            { typeof(WeatherCondition), (WeatherConditionJsonResponse, WeatherConditionResponse) },
            { typeof(CurrentWeather), (CurrentWeatherJsonResponse, CurrentWeatherResponse) },
            { typeof(MinuteWeatherForecast), (MinutelyJsonResponse, MinutelyResponse) },
            { typeof(HourlyWeatherForecast), (HourlyJsonResponse, HourlyResponse) },
            { typeof(DailyWeatherForecast), (DailyJsonResponse, DailyResponse) },
            { typeof(WeatherAlert), (WeatherAlertJsonResponse, WeatherAlertResponse) },
            { typeof(OneCallWeatherInfo), (OneCallApiJsonResponse, OneCallApiResponse) }
        };

        #region WeatherConditionResponse
        public static WeatherCondition WeatherConditionResponse => new()
        {
            Id = 803,
            Type = WeatherConditionType.Clouds,
            Description = "broken clouds",
            Icon = "04d"
        };

        public const string WeatherConditionJsonResponse = @"
        {
            ""id"":803,
            ""main"":""Clouds"",
            ""description"":""broken clouds"",
            ""icon"":""04d""
        }";
        #endregion

        #region CurrentWeatherResponse
        public static CurrentWeather CurrentWeatherResponse => new()
        {
            DateTime = DateTimeOffset.FromUnixTimeSeconds(1684929490).DateTime,
            Sunrise = DateTimeOffset.FromUnixTimeSeconds(1684926645).DateTime,
            Sunset = DateTimeOffset.FromUnixTimeSeconds(1684977332).DateTime,
            Temperature = new(292.55, TemperatureUnit.Kelvin),
            FeelsLike = new(292.87, TemperatureUnit.Kelvin),
            Pressure = 1014,
            Humidity = 89,
            DewPoint = 290.69,
            Uvi = 0.16,
            Clouds = 53,
            Visibility = 10000,
            WindSpeed = 3.13,
            WindDeg = 93,
            WindGust = 6.71,
            Weather = [WeatherConditionResponse],
            Rain = new() { OneHourPrecipitation = 0.15 }
        };

        public const string CurrentWeatherJsonResponse = $@"
        {{
            ""dt"":1684929490,
            ""sunrise"":1684926645,
            ""sunset"":1684977332,
            ""temp"":292.55,
            ""feels_like"":292.87,
            ""pressure"":1014,
            ""humidity"":89,
            ""dew_point"":290.69,
            ""uvi"":0.16,
            ""clouds"":53,
            ""visibility"":10000,
            ""wind_speed"":3.13,
            ""wind_deg"":93,
            ""wind_gust"":6.71,
            ""weather"":[{WeatherConditionJsonResponse}],
            ""rain"":{{""1h"":0.15}}
        }}";

        #endregion

        #region MinutelyResponse
        public static MinuteWeatherForecast MinutelyResponse => new()
        {
            DateTime = DateTimeOffset.FromUnixTimeSeconds(1684929540).DateTime,
            Precipitation = 0
        };

        public const string MinutelyJsonResponse = @"
        {
            ""dt"":1684929540,
            ""precipitation"":0
        }";
        #endregion

        #region HourlyResponse
        public static HourlyWeatherForecast HourlyResponse => new()
        {
            DateTime = DateTimeOffset.FromUnixTimeSeconds(1684926000).DateTime,
            Temperature = new(292.01, TemperatureUnit.Kelvin),
            FeelsLike = new(292.33, TemperatureUnit.Kelvin),
            Pressure = 1014,
            Humidity = 91,
            DewPoint = 290.51,
            Uvi = 0,
            Clouds = 54,
            Visibility = 10000,
            WindSpeed = 2.58,
            WindDeg = 86,
            WindGust = 5.88,
            Weather = [WeatherConditionResponse],
            ProbabilityOfPrecipitation = 0.15
        };

        public const string HourlyJsonResponse = $@"
        {{
            ""dt"":1684926000,
            ""temp"":292.01,
            ""feels_like"":292.33,
            ""pressure"":1014,
            ""humidity"":91,
            ""dew_point"":290.51,
            ""uvi"":0,
            ""clouds"":54,
            ""visibility"":10000,
            ""wind_speed"":2.58,
            ""wind_deg"":86,
            ""wind_gust"":5.88,
            ""weather"":[{WeatherConditionJsonResponse}],
            ""pop"":0.15
        }}";
        #endregion

        #region DailyResponse
        public static DailyWeatherForecast DailyResponse => new()
        {
            DateTime = DateTimeOffset.FromUnixTimeSeconds(1684951200).DateTime,
            Sunrise = DateTimeOffset.FromUnixTimeSeconds(1684926645).DateTime,
            Sunset = DateTimeOffset.FromUnixTimeSeconds(1684977332).DateTime,
            Moonrise = DateTimeOffset.FromUnixTimeSeconds(1684941060).DateTime,
            Moonset = DateTimeOffset.FromUnixTimeSeconds(1684905480).DateTime,
            MoonPhase = 0.16,
            Summary = "Expect a day of partly cloudy with rain",
            Temperature = new()
            {
                Day = new(299.03, TemperatureUnit.Kelvin),
                Min = new(290.69, TemperatureUnit.Kelvin),
                Max = new(300.35, TemperatureUnit.Kelvin),
                Night = new(291.45, TemperatureUnit.Kelvin),
                Evening = new(297.51, TemperatureUnit.Kelvin),
                Morning = new(292.55, TemperatureUnit.Kelvin)
            },
            FeelsLike = new()
            {
                Day = new(299.21, TemperatureUnit.Kelvin),
                Night = new(291.37, TemperatureUnit.Kelvin),
                Evening = new(297.86, TemperatureUnit.Kelvin),
                Morning = new(292.87, TemperatureUnit.Kelvin)
            },
            Pressure = 1016,
            Humidity = 59,
            DewPoint = 290.48,
            WindSpeed = 3.98,
            WindDeg = 76,
            WindGust = 8.92,
            Weather = [WeatherConditionResponse],
            Cloudiness = 92,
            ProbabilityOfPrecipitation = 0.47,
            Rain = 0.15,
            Uvi = 9.23
        };

        public const string DailyJsonResponse = $@"
        {{
            ""dt"":1684951200,
            ""sunrise"":1684926645,
            ""sunset"":1684977332,
            ""moonrise"":1684941060,
            ""moonset"":1684905480,
            ""moon_phase"":0.16,
            ""summary"":""Expect a day of partly cloudy with rain"",
            ""temp"":{{
                ""day"":299.03,
                ""min"":290.69,
                ""max"":300.35,
                ""night"":291.45,
                ""eve"":297.51,
                ""morn"":292.55
            }},
            ""feels_like"":{{
                ""day"":299.21,
                ""night"":291.37,
                ""eve"":297.86,
                ""morn"":292.87
            }},
            ""pressure"":1016,
            ""humidity"":59,
            ""dew_point"":290.48,
            ""wind_speed"":3.98,
            ""wind_deg"":76,
            ""wind_gust"":8.92,
            ""weather"":[{WeatherConditionJsonResponse}],
            ""clouds"":92,
            ""pop"":0.47,
            ""rain"":0.15,
            ""uvi"":9.23
        }}";
        #endregion

        #region WeatherAlertResponse
        public static WeatherAlert WeatherAlertResponse => new()
        {
            SenderName = "NWS Philadelphia - Mount Holly (New Jersey, Delaware, Southeastern Pennsylvania)",
            Event = "Small Craft Advisory",
            Start = DateTimeOffset.FromUnixTimeSeconds(1684952747).DateTime,
            End = DateTimeOffset.FromUnixTimeSeconds(1684988747).DateTime,
            Description = "...SMALL CRAFT ADVISORY REMAINS IN EFFECT FROM 5 PM THIS\nAFTERNOON TO 3 AM EST FRIDAY...\n* WHAT...North winds 15 to 20 kt with gusts up to 25 kt and seas\n3 to 5 ft expected.\n* WHERE...Coastal waters from Little Egg Inlet to Great Egg\nInlet NJ out 20 nm, Coastal waters from Great Egg Inlet to\nCape May NJ out 20 nm and Coastal waters from Manasquan Inlet\nto Little Egg Inlet NJ out 20 nm.\n* WHEN...From 5 PM this afternoon to 3 AM EST Friday.\n* IMPACTS...Conditions will be hazardous to small craft.",
            Tags = []
        };

        public const string WeatherAlertJsonResponse = @"
        {
            ""sender_name"": ""NWS Philadelphia - Mount Holly (New Jersey, Delaware, Southeastern Pennsylvania)"",
            ""event"": ""Small Craft Advisory"",
            ""start"": 1684952747,
            ""end"": 1684988747,
            ""description"": ""...SMALL CRAFT ADVISORY REMAINS IN EFFECT FROM 5 PM THIS\nAFTERNOON TO 3 AM EST FRIDAY...\n* WHAT...North winds 15 to 20 kt with gusts up to 25 kt and seas\n3 to 5 ft expected.\n* WHERE...Coastal waters from Little Egg Inlet to Great Egg\nInlet NJ out 20 nm, Coastal waters from Great Egg Inlet to\nCape May NJ out 20 nm and Coastal waters from Manasquan Inlet\nto Little Egg Inlet NJ out 20 nm.\n* WHEN...From 5 PM this afternoon to 3 AM EST Friday.\n* IMPACTS...Conditions will be hazardous to small craft."",
            ""tags"": [

            ]
        }";
        #endregion

        #region OneCallAPIResponse
        public static OneCallWeatherInfo OneCallApiResponse => new()
        {
            Latitude = 33.44,
            Longitude = -94.04,
            Timezone = "America/Chicago",
            TimezoneOffset = -18000,
            CurrentWeather = CurrentWeatherResponse,
            MinuteWeatherForecasts = [MinutelyResponse, new()
            {
                DateTime = DateTimeOffset.FromUnixTimeSeconds(1684929600).DateTime,
                Precipitation = 0.31
            }],
            HourlyWeatherForecasts = [HourlyResponse,
            new()
            {
                DateTime = DateTimeOffset.FromUnixTimeSeconds(1684933200).DateTime,
                Temperature = new(291.01, TemperatureUnit.Kelvin),
                FeelsLike = new(292.33, TemperatureUnit.Kelvin),
                Pressure = 1014,
                Humidity = 91,
                DewPoint = 290.51,
                Uvi = 0,
                Clouds = 53,
                Visibility = 9870,
                WindSpeed = 2.22,
                WindDeg = 84,
                WindGust = 4.88,
                Weather = [WeatherConditionResponse],
                ProbabilityOfPrecipitation = 0.10
            }],
            DailyWeatherForecasts = [DailyResponse with
            {
                Weather = [new()
                {
                    Id = 500,
                    Type = WeatherConditionType.Rain,
                    Description = "light rain",
                    Icon = "10d"
                }]
            }],
            Alerts = [WeatherAlertResponse, new()
            {
                SenderName = "NWS Oklahoma City (Oklahoma)",
                Event = "Heat Advisory",
                Start = DateTimeOffset.FromUnixTimeSeconds(1684952747).DateTime,
                End = DateTimeOffset.FromUnixTimeSeconds(1684988747).DateTime,
                Description = "...HEAT ADVISORY REMAINS IN EFFECT FROM 1 PM THIS AFTERNOON TO\n8 PM CDT THIS EVENING...\n* WHAT...Heat index values up to 110 expected.\n* WHERE...Canadian, Cleveland, Oklahoma, Lincoln, Grady, McClain,\nLogan, Payne, and Pottawatomie Counties.\n* WHEN...From 1 PM this afternoon to 8 PM CDT this evening.\n* IMPACTS...Hot temperatures and high humidity may cause heat\nillnesses to occur.",
                Tags = []
            }]
        };

        public const string OneCallApiJsonResponse = $@"
{{
    ""lat"":33.44,
    ""lon"":-94.04,
    ""timezone"":""America/Chicago"",
    ""timezone_offset"":-18000,
    ""current"":{CurrentWeatherJsonResponse},
    ""minutely"":[
        {MinutelyJsonResponse},
        {{
            ""dt"":1684929600,
            ""precipitation"":0.31
        }}
    ],
    ""hourly"":[
        {HourlyJsonResponse},
        {{
             ""dt"":1684933200,
            ""temp"":291.01,
            ""feels_like"":292.33,
            ""pressure"":1014,
            ""humidity"":91,
            ""dew_point"":290.51,
            ""uvi"":0,
            ""clouds"":53,
            ""visibility"":9870,
            ""wind_speed"":2.22,
            ""wind_deg"":84,
            ""wind_gust"":4.88,
            ""weather"":[{WeatherConditionJsonResponse}],
            ""pop"":0.10
        }}
    ],
    ""daily"":[
        {{
            ""dt"":1684951200,
            ""sunrise"":1684926645,
            ""sunset"":1684977332,
            ""moonrise"":1684941060,
            ""moonset"":1684905480,
            ""moon_phase"":0.16,
            ""summary"":""Expect a day of partly cloudy with rain"",
            ""temp"":
            {{
                ""day"":299.03,
                ""min"":290.69,
                ""max"":300.35,
                ""night"":291.45,
                ""eve"":297.51,
                ""morn"":292.55
            }},
            ""feels_like"":
            {{
                ""day"":299.21,
                ""night"":291.37,
                ""eve"":297.86,
                ""morn"":292.87
            }},
            ""pressure"":1016,
            ""humidity"":59,
            ""dew_point"":290.48,
            ""wind_speed"":3.98,
            ""wind_deg"":76,
            ""wind_gust"":8.92,
            ""weather"":[
            {{
                ""id"":500,
                ""main"":""Rain"",
                ""description"":""light rain"",
                ""icon"":""10d""
            }}
            ],
            ""clouds"":92,
            ""pop"":0.47,
            ""rain"":0.15,
            ""uvi"":9.23
        }}
    ],
    ""alerts"": [
    {WeatherAlertJsonResponse},
    {{
        ""sender_name"": ""NWS Oklahoma City (Oklahoma)"",
        ""event"": ""Heat Advisory"",
        ""start"": 1684952747,
        ""end"": 1684988747,
        ""description"": ""...HEAT ADVISORY REMAINS IN EFFECT FROM 1 PM THIS AFTERNOON TO\n8 PM CDT THIS EVENING...\n* WHAT...Heat index values up to 110 expected.\n* WHERE...Canadian, Cleveland, Oklahoma, Lincoln, Grady, McClain,\nLogan, Payne, and Pottawatomie Counties.\n* WHEN...From 1 PM this afternoon to 8 PM CDT this evening.\n* IMPACTS...Hot temperatures and high humidity may cause heat\nillnesses to occur."",
        ""tags"": []
    }}
  ]
}}";
        #endregion
    }
}
