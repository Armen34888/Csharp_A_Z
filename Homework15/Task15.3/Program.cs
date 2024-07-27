namespace Task15._3
{
    internal class Program
    {
        //  Demonstrating casting from Vehicle to Car and vice versa:
        static void Main(string[] args)
        {
            Car car = new Car(1999, "Mersedes");
            car.Info();
            Motorcycle motorcycle = new Motorcycle(350, "Yamaha");
            motorcycle.Info();
            Vehicle c = new Car(2006,"BMW");             // Implicit upcasting
            c.Info();
            Vehicle m = new Motorcycle(400, "Kawasaki"); // Implicit upcasting
            m.Info();
           
           //Car c1 = (Car)c;                 // Explicit downcasting        
           //Motorcycle m2 = (Motorcycle)m;  // Explicit downcasting

           Car? c1 = c as Car;
            if (c1 != null)
            {
                Console.WriteLine("Casting succeeded.");
            
            }
            else
            {
                Console.WriteLine("Casting failed.");    
            }
            if (m is Motorcycle)
            {
                m.Info();
                Console.WriteLine("Casting succeeded.");
            }
            else
            {
                Console.WriteLine("Casting failed.")
            }


        }

    }
    abstract class Vehicle
    {
        public abstract void Info();
           
    }
    class Car : Vehicle 
    {
        public int Made {  get; set; }
        public string Model {  get; set; }

        public Car(int made,string model) 
        {
            Made = made;
            Model = model;
        }
        public override void Info()
        {
            Console.WriteLine($"Made in {Made}, Model - {Model}.");
        }
    }
    class Motorcycle : Vehicle
    {
        public int maxSpeed { get; set;}
        public string Model { get; set; }
        public Motorcycle(int maxspeed,string model)
        {
            maxSpeed = maxspeed;
            Model = model;
        }   
        public override void Info()
        {
            Console.WriteLine($"Model - {Model}, Maxspeed is {maxSpeed}.");  
        }
    }

}
