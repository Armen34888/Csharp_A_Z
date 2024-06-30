namespace Task11._5
{
    internal class Program
    {
        //Toggle a Flag On/Off:
        [Flags]
        enum GameSettings
        {
            None = 0,           // No settings
            SoundOn = 1 << 0,   // SoundOn setting: 1
            MusicOn = 1 << 1,   // MusicOn setting: 2
            FullScreen = 1 << 2 // FullScreen setting: 4
        }
        static void Main(string[] args)
        {
           
            GameSettings settings = GameSettings.SoundOn | GameSettings.MusicOn | GameSettings.FullScreen;
            Console.WriteLine("Initial settings: " + settings);

            settings ^= GameSettings.SoundOn;

            Console.WriteLine("Settings after toggling SoundOn: " + settings);
            if ((settings & GameSettings.SoundOn) == 0)
            {
                Console.WriteLine("SoundOn setting is now disabled.");
            }
        }
    }
}
