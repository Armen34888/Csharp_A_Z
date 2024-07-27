namespace Task15._2
{
    internal class Program
    {
        // Define an abstract class Animal:
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.MakeSound();
            Cat cat = new Cat();
            cat.MakeSound();
            Bird bird = new Bird();
            bird.MakeSound();
        }

    }
    abstract class Animal
    {
        public abstract void MakeSound();
    }
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Haf-Haf");
        }
    }
    class Cat : Animal { 
        public override void MakeSound() 
        {
            Console.WriteLine("Myau-Myau");
        } 
    }
    class Bird : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Civ-Civ");
        }
    }
}
