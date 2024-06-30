namespace Task9._8
{
    internal class Program
    {
        // Traffic Light Enum.
        enum TrafficLight
        {
           Red,
           Yellow,
           Green,
        }
        static void Main(string[] args)
        {
            TrafficLight trafficLight = TrafficLight.Red;
            while (true)
            {
                Console.WriteLine($"Traffic lihgt is {trafficLight}");
                switch (trafficLight)
                {
                    case TrafficLight.Red:
                        trafficLight = TrafficLight.Green;
                        Thread.Sleep(3000);
                        break;
                    case TrafficLight.Yellow:
                        trafficLight = TrafficLight.Red;
                        Thread.Sleep(5000);
                        break;
                    case TrafficLight.Green:
                        trafficLight = TrafficLight.Yellow;
                        Thread.Sleep(3000);
                        break;
                }
            }
        }
    }
}
