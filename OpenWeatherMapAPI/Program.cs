using Newtonsoft.Json.Linq;


//namespace OpenWeatherMapAPI
//{
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello, World!");
//        }
//    }
//}
var client = new HttpClient();

var apiKey = "14c8fadb87bba7310e090da9397ddb5c";

Console.WriteLine("enter a city: ");
var cityName = Console.ReadLine();

//https://api.openweathermap.org/data/2.5/weather?q={city name}&appid={API key}

var weatherMapURL = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={apiKey}&units=imperial";
string weatherResponse = client.GetStringAsync(weatherMapURL).Result;
JObject weatherObject = JObject.Parse(weatherResponse);

Console.WriteLine("Weather Object");
Console.WriteLine(weatherObject);

//Console.WriteLine("Weather: ");
//Console.WriteLine($"it is {weatherObject["main"]["temp"]} degrees Fahrenheit in {cityName}");

