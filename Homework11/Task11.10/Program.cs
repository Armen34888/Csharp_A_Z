namespace Task11._10
{
    internal class Program
    {
        [Flags]
        enum PizzaToppings
        {
            None = 0,
            Pepperoni = 1 << 0,  // 1
            Mushroom = 1 << 1,   // 2
            Onion = 1 << 2,      // 4
            Olives = 1 << 3,     // 8
            ExtraCheese = 1 << 4 // 16
        }
        //Flags Enum with Multiple Selections:
        static void Main(string[] args)
        {
            PizzaToppings selectedToppings = PizzaToppings.Pepperoni | PizzaToppings.Mushroom;

            // Print out selected toppings
            Console.WriteLine("Selected toppings: " + selectedToppings);

            // Check if Pepperoni is selected
            if ((selectedToppings & PizzaToppings.Pepperoni) != 0)
            {
                Console.WriteLine("Pepperoni is selected.");
            }

            // Check if Onion is selected (it shouldn't be)
            if ((selectedToppings & PizzaToppings.Onion) != 0)
            {
                Console.WriteLine("Onion is selected.");
            }
            else
            {
                Console.WriteLine("Onion is not selected.");
            }

            // Example: Add Olives topping
            selectedToppings |= PizzaToppings.Olives;

            // Print out updated selected toppings
            Console.WriteLine("Updated selected toppings: " + selectedToppings);
        }
    }
}
