namespace Task13._7
{
    // Nested Structs:
    public struct Address
    {
        public string Street;
        public string City;
        public string PostalCode;

        public Address(string street, string city, string postalCode)
        { 
           Street = street;
           City = city;
           PostalCode = postalCode;
        }

    }
    public struct Person
    {
        public string Name;
        public int Age;
        public Address Address;
        

        public Person(string name,  int age, Address address) 
        { 
        
        Name = name;
        Age = age;
        Address = address;
        
        }
        public void Print()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age} ");
            Console.WriteLine($"Addres: {Address.Street}, {Address.City}, {Address.PostalCode} ");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address("31 poxoc", "Yeravan", "8900");
            Person person = new Person("Armen", 36, address);
            person.Print();
        }
    }
}
