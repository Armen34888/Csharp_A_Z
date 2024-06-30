namespace Task9._4
{
    internal class Program
    {
        // Enum with Associated Values.
        enum TransportType
        {
            Car,
            Bus,
            Bicycle

        }
        static void Main(string[] args)
        {
            TransportType type = TransportType.Car;

            switch (type)
            {
                case TransportType.Car:
                    Console.WriteLine("Type: Car");
                    Console.WriteLine("Max speed: 200km/h");
                    Console.WriteLine("Fuel Efficiency: 12Litr/100km");
                    break;
                case TransportType.Bus:
                    Console.WriteLine("Type: Bus");
                    Console.WriteLine("Max speed: 120km/h");
                    Console.WriteLine("Fuel Efficiency: 8Litr/100km");
                    break;
                case TransportType.Bicycle:
                    Console.WriteLine("Type: Bicycle");
                    Console.WriteLine("Max speed: 40km/h");
                    Console.WriteLine("Fuel Efficiency: 0litr");
                    break;

            }
        }

    }
}
     