
namespace Test12_DeserializeExtra
{
    public class WeatherForecast
    {
        public DateTimeOffset Date { get; set; }
        public int TemperatureCelsius { get; set; }
        public string? Summary { get; set; }
        public string? SummaryField;
        public IList<DateTimeOffset>? DatesAvailable { get; set; }
        public Dictionary<string, HighLowTemps>? TemperatureRanges { get; set; }
        public string[]? SummaryWords { get; set; }
    }

    public class HighLowTemps
    {
        public int High { get; set; }
        public int Low { get; set; }
    }

    public class Program
    {
        public static void Main()
        {
            string jsonString =
                            @"{
                              ""Date"": ""2019-08-01T00:00:00-07:00"",
                              ""TemperatureCelsius"": 25,
                              ""Summary"": ""Hot"",
                              ""DatesAvailable"": [
                                ""2019-08-01T00:00:00-07:00"",
                                ""2019-08-02T00:00:00-07:00""
                              ],
                              ""TemperatureRanges"": {
                                            ""Cold"": {
                                                ""High"": 20,
                                  ""Low"": -10
                                            },
                                ""Hot"": {
                                                ""High"": 60,
                                  ""Low"": 20
                                }
                                        },
                              ""SummaryWords"": [
                                ""Cool"",
                                ""Windy"",
                                ""Humid""
                              ]
                            }
                            ";
            WeatherForecast? weatherForecast = System.Text.Json.JsonSerializer.Deserialize<WeatherForecast>(jsonString);

            Console.WriteLine($"Date: {weatherForecast?.Date}");
            Console.WriteLine($"TemperatureCelsius: {weatherForecast?.TemperatureCelsius}");
            Console.WriteLine($"Summary: {weatherForecast?.Summary}");
        }
    }
}
namespace SerializeBasic
{
    public class WeatherForecast
    {   
        public DateTimeOffset Date { get; set; }
        public int TemperatureCelsius { get; set; }
        public string? Summary { get; set; }


        public class Program
        {
            public static void Main()
            {
                var weatherForecast = new WeatherForecast
                {
                    Date = DateTime.Parse("2019-08-01"),
                    TemperatureCelsius = 25,
                    Summary = "Hot"
                };

                Console.WriteLine(jsonString);
            }
        }
    }
}
