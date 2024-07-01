using System.Formats.Asn1;
using System.Reflection.Metadata;

namespace Task12._14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Calculate Rectangle Properties:
            int length = 5;
            int width = 4;
            
            (int area, int perimetr) = CalculateRectangleProperties(length, width);

            Console.WriteLine($"Rectangle with length {length} and width {width}:");
            Console.WriteLine($"Area: {area}");
            Console.WriteLine($"Perimeter: {perimetr}");
        }
        static (int, int) CalculateRectangleProperties(int length, int width)
        {
            int area = length * width;
            int perimetr = 2 * (length + width);
            return(area, perimetr);
        }
    }
}
