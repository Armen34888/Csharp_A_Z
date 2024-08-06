using System.Collections;

namespace Task17._5
{
    //  City Attractions Enumerator
    internal class Program
    {
        static void Main(string[] args)
        {
            var cityAttractions = new CityAttractions();
            cityAttractions.AddAttraction(new Attraction("Central Park", "A large public park in New York City.", "Park"));
            cityAttractions.AddAttraction(new Attraction("Metropolitan Museum", "A famous art museum located in New York City.", "Museum"));
            cityAttractions.AddAttraction(new Attraction("Times Square", "A major commercial intersection and entertainment center in New York City.", "Entertainment"));
            foreach (var attraction in cityAttractions)
            {
                Console.WriteLine(attraction);
            }
        }
    }
    class Attraction
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public Attraction(string name, string description, string category)
        {
            Name = name;
            Description = description;
            Category = category;
        }
        public override string ToString()
        {
            return $"{Name} {Category} {Description}";
        }
    }
    class CityAttractions : IEnumerable<Attraction>
    {
        public List<Attraction> Attractions = new List<Attraction>();

        public void AddAttraction(Attraction a)
        {
            Attractions.Add(a);
        }
        public IEnumerator<Attraction> GetEnumerator()
        {
            return Attractions.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    class AttractionEnumerator : IEnumerator<Attraction>
    {
        public List <Attraction> Attractions;
        private int position = -1;
        public AttractionEnumerator(List<Attraction> attractions, int position)
        {
            Attractions = attractions;
            
        }
        public Attraction Current
        {
            get
            {
                if(position < 0 || position >= Attractions.Count)
                {
                    throw new IndexOutOfRangeException();
                }
                return Attractions[position];
            }
        }

        object IEnumerator.Current => throw new NotImplementedException();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
           if(++position >= Attractions.Count)
            {
                return false;
            }
           return true;
        }
        public void Reset()
        {
           position = -1;
        }
    }

}
