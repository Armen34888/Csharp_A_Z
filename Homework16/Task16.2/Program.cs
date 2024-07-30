namespace Task16._2
{
    internal class Program
    {
        // Explicit Interface Implementation:
        static void Main(string[] args)
        {
           IAnimal dog = new Dog();
           dog.Eat();
           dog.Sleep();
        }
    }
    interface IAnimal
    {
       void Eat();
       void Sleep();

    }
    class Dog : IAnimal
    {
        void IAnimal.Eat()
        {
            Console.WriteLine("The dog is eating.");
        }
        void IAnimal.Sleep() 
        {
            Console.WriteLine("The dog is sleeping.");
                
        }
    }
}
