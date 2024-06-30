using System.Diagnostics.Tracing;

namespace Task11._2
{
    internal class Program
    {
        //Clear Bit Using Bitwise AND with Negation.

        [Flags]
        enum FilePermissions
        {
            None = 0,
            Read = 1,
            Write = 2,
            Execute = 4,

        }
        static void Main(string[] args)
        {
           FilePermissions filePermissions = FilePermissions.Read | FilePermissions.Write | FilePermissions.Execute | FilePermissions.Read;
            Console.WriteLine("Initial permisions:" +  filePermissions);
            filePermissions &= ~FilePermissions.Write;
            Console.WriteLine("Permissions after clearing Write: " + filePermissions);
        }
    }
}
