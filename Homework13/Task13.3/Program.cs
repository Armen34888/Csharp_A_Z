namespace Task13._3
{
    // Parameterized Constructor:

    public struct Person
    {
        public string FirstName;
        public string LastName;
        public int Age;

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Armen";
            person.LastName = "Barseghyan";
            person.Age = 36;
            Console.WriteLine($"Name: {person.FirstName} | Surname: {person.LastName} | Age: {person.Age}");

            
        }
    }
}
