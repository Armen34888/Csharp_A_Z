namespace Task11._8
{
    internal class Program
    {
        [Flags]
        enum UIElements
        {
            None = 0,
            Button = 1 << 0,     // 1
            TextBox = 1 << 1,    // 2
            Checkbox = 1 << 2,   // 4
            Label = 1 << 3,      // 8
            Image = 1 << 4       // 16
        }
        //Flags for UI Elements:
        static void Main(string[] args)
        {
            // Example: UI elements currently visible or enabled
            UIElements visibleElements = UIElements.Button | UIElements.TextBox | UIElements.Checkbox;

            // Print current visible or enabled UI elements
            Console.WriteLine("Currently visible or enabled UI elements: " + visibleElements);

            // Example: Disable TextBox and enable Image
            visibleElements &= ~(UIElements.TextBox);  // Disable TextBox
            visibleElements |= UIElements.Image;        // Enable Image

            // Print updated visible or enabled UI elements
            Console.WriteLine("Updated visible or enabled UI elements: " + visibleElements);

            // Check if Button is currently visible or enabled
            if ((visibleElements & UIElements.Button) != 0)
            {
                Console.WriteLine("Button is currently visible or enabled.");
            }
            else
            {
                Console.WriteLine("Button is not currently visible or enabled.");
            }
        }
    }
}
