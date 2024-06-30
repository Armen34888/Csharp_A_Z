namespace Task11._7
{
    internal class Program
    {
        [Flags]
        enum CustomPermissions
        {
            None = 0,
            Read = 1 << 0,      // 1
            Write = 1 << 1,     // 2
            Delete = 1 << 2,    // 4
            Execute = 1 << 3    // 8
        }
        //Custom Permissions Enum:
        static void Main(string[] args)
        {
            // Example: User1 has Read and Execute permissions
            CustomPermissions user1Permissions = CustomPermissions.Read | CustomPermissions.Execute;

            // Example: User2 has Write, Delete, and Execute permissions
            CustomPermissions user2Permissions = CustomPermissions.Write | CustomPermissions.Delete | CustomPermissions.Execute;

            // Check if User1 has Read and Execute permissions
            if (HasPermissions(user1Permissions, CustomPermissions.Read | CustomPermissions.Execute))
            {
                Console.WriteLine("User1 has Read and Execute permissions.");
            }
            else
            {
                Console.WriteLine("User1 does not have Read and Execute permissions.");
            }

            // Check if User2 has Write and Delete permissions
            if (HasPermissions(user2Permissions, CustomPermissions.Write | CustomPermissions.Delete))
            {
                Console.WriteLine("User2 has Write and Delete permissions.");
            }
            else
            {
                Console.WriteLine("User2 does not have Write and Delete permissions.");
            }
        }

        // Method to check if a user has specific permissions
        static bool HasPermissions(CustomPermissions userPermissions, CustomPermissions requiredPermissions)
        {
            // Perform bitwise AND operation to check if all required permissions are present
            return (userPermissions & requiredPermissions) == requiredPermissions;
        }
    
    }
}
