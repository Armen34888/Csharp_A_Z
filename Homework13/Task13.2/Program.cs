namespace Task13._2
{
    
    // Create Struct Instances:`

    public struct Person
    {
        public string Name;
        public string proffesion;
        public int age;
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person();
            Person person3 = new Person();

            person1.Name = "Armen";
            person1.proffesion = "Developer";
            person1.age = 36;
            Console.WriteLine($"Person1: {person1.Name} | Proffesion: {person1.proffesion} | Age: {person1.age}");

            person2.Name = "Artak";
            person2.proffesion = "Doctor";
            person2.age = 42;  
            Console.WriteLine($"Person2: {person2.Name} | Proffesion: {person2.proffesion} | Age: {person2.age}");

            person3.Name = "Artur";
            person3.proffesion = "Driver";
            person3.age = 30;
            Console.WriteLine($"Person3: {person3.Name} | Proffesion: {person3.proffesion} | Age {person3.age}");
        }
    }
}
