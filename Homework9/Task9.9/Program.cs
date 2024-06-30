namespace Task9._9
{
    internal class Program
    {
        // Pizza Toppings Enum
        enum PizzaTopping
        {
            Pepperoni,
            Mushroom,
            Onion
        }
        static void Main(string[] args)
        {
            PizzaTopping[] order = {PizzaTopping.Pepperoni, PizzaTopping.Mushroom, PizzaTopping.Onion};
            Console.WriteLine("Your pizza order:");
            foreach(var topping in order)
            {
                Console.WriteLine($"-{topping}");
            }
        }
    }
}
