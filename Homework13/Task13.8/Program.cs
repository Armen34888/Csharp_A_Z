using Task13._8;

namespace Task13._8
{
    // Custom Struct with Methods:

    public struct Temperature
    {
        public double Celsius;
        public double ToFahrenheyt()
        {
            return Celsius * 9/5 + 32;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Temperature temperature = new Temperature();
            temperature.Celsius = 28.0;

            double tempFahrenheit = temperature.ToFahrenheyt();
            Console.WriteLine($"Temperature in Celsius: {temperature.Celsius} C");
            Console.WriteLine($"Temperature in Fahrenheit: {tempFahrenheit} F");
        }
    }
}
