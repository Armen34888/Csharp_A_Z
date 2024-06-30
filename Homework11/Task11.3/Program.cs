namespace Task11._3
{
    internal class Program
    {
        [Flags]
        //Combine Multiple Flags.
        enum UserRoles
        {
            None = 0,              //No roles
            Admin = 1<<0,          // Admin role: 1
            Moderator = 1<<1,      // Moderator role: 2 
            User = 1<<2,           // Regular User role: 4
            Guest = 1 << 3         // Guest role: 8
            
        }
        static void Main(string[] args)
        {
            UserRoles user1Roles = UserRoles.Admin | UserRoles.Moderator;
            UserRoles user2roles = UserRoles.User;

            Console.WriteLine("User 1 roles:" + user1Roles);
            Console.WriteLine("User 2 roles:" + user2roles);

            if ((user1Roles & UserRoles.Admin) != 0)
            {
                Console.WriteLine("User 1 is an Admin.");
            }

            if ((user2roles & UserRoles.Moderator) != 0)
            {
                Console.WriteLine("User 2 is a Moderator.");
            }



        }
    }
}
