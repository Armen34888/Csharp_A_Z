namespace Task9._7
{
    internal class Program
    {
        // User Role Enum.
        enum UserRole
        {
            Administrator,
            Moderator,
            User
        }
        static void Main(string[] args)
        {
            UserRole userRole = UserRole.Administrator;
            switch (userRole)
            {
                case UserRole.Administrator:
                    Console.WriteLine("You are Administrator");
                    break;
                case UserRole.Moderator:
                    Console.WriteLine("You are Moderator");
                    break;
                case UserRole.User:
                    Console.WriteLine("You are Use");
                    break;
                default:
                    Console.WriteLine("Unknown role");
                    break;
            }
        }
    }
}
