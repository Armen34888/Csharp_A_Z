namespace Task9._1
{
    internal class Program
    {
        // Declare and Assign Enum Constants.
        enum WeatherCondition
        {
            Sunny,
            Cloudy,
            Rainy
        }
        static void Main(string[] args)
        {
            WeatherCondition weatherCondition = WeatherCondition.Sunny;
            Console.WriteLine(weatherCondition);
        }
    }
}
