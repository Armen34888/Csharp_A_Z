using System.Collections;

namespace Task17._4
{
    // Traveling by Train Stops:
    internal class Program
    {
        static void Main(string[] args)
        {
            Ertuxi stations = new Ertuxi();
            stations.AddStation(new Station("Punkt A"));
            stations.AddStation(new Station("Punkt B"));
            stations.AddStation(new Station("Punkt C"));

            foreach (Station station in stations)
            {
                Console.WriteLine(station);
            }
        }
    }
    class Station
    {
        public string Name { get; set; }
        public Station(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }
    class Ertuxi : IEnumerable<Station>
    {
        public List<Station> Stations = new List<Station>();
        public void AddStation(Station station)
        {
            Stations.Add(station);
        }
        public IEnumerator<Station> GetEnumerator()
        {
            return Stations.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
