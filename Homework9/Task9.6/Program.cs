namespace Task9._6
{
    internal class Program
    {
        // Seasons Enum.
        public enum Seasons
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }
        static void Main(string[] args)
        {
           Seasons seasons = Seasons.Winter;
           int monthNow = 6;
           switch (monthNow)
           {
                case 12:
                case 1:
                case 2:
                    seasons = Seasons.Winter;
                    break;
                case 3:
                case 4:
                case 5:
                    seasons = Seasons.Spring;
                    break;
                case 6:
                case 7:
                case 8:
                    seasons = Seasons.Summer; 
                    break;
                case 9:
                case 10:
                case 11:
                    seasons = Seasons.Autumn;
                    break;
                    

           }
            
           
            Console.WriteLine($"Current season: {seasons}");


             

            
        }
    }
}
