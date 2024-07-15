using System.Runtime.ExceptionServices;

namespace Task13._1
{
    // Basic Struct Definition:
    public struct Person
    {
        public string FirstName;
        public string LastName;
        public int age;
    }
    internal class Program
    {
        
         static void Main(string[] args)
         {
            Person person;
            person.FirstName = "Armen";
            person.LastName = "Barseghyan";
            person.age = 36;
            Console.WriteLine($"Name: {person.FirstName} | Surname: {person.LastName} | Age: {person.age}");
         }

    }
    
}
