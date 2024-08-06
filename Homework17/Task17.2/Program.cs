using System.Collections;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Task17._2
{
    // Zoo Animals:
    internal class Program
    {   
        static void Main(string[] args)
        {
            Vandak vandak = new Vandak();
            vandak.AddAnimal(new Animal("Cat"));
            vandak.AddAnimal(new Animal("Dog"));
            vandak.AddAnimal(new Animal("Lion"));
            vandak.AddAnimal(new Animal("Wolf"));
            vandak.AddAnimal(new Animal("Bear"));

            foreach(var animal in vandak)
            {
                Console.WriteLine(animal);
            }

            
        }
    }
    class Animal
    {
        public string Tesak { get; set; }
        public Animal(string tesak)
        {
            Tesak = tesak;
        }
        public override string ToString()
        {
            return $"{Tesak}";
        }
    }
    class Vandak : IEnumerable<Animal> 
    {
        public List<Animal> animals = new List<Animal>();
        public void AddAnimal(Animal animal)
        {
            animals.Add( animal);
        }
        public IEnumerator<Animal> GetEnumerator()
        {
            return animals.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
   

}