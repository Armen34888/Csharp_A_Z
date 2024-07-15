namespace Task13._4
{
    // Calculate Average Age:

    public struct Person
    {
        public string FirstName;
        public string LastName;
        public int Age;

        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[]
            {
                new Person("Armen", "Barseghyan", 36),
                new Person("Artak", "Xachatryan", 40),
                new Person("Armine", "Abrahamyan", 33),


            };
            double totalage = 0;
            foreach (Person person in people)
            {
                totalage += person.Age;
            }
            double average = totalage / people.Length;
            Console.WriteLine($"Average: {average}");
           
        }
    }
}
