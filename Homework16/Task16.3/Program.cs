namespace Task16._3
{
    internal class Program
    {
        // Multiple Interfaces:
        static void Main(string[] args)
        {
            
            MediaPlayer player = new MediaPlayer();
            player.Play();
            player.Record();
            player.Pause();
            player.StopRecording(); 
           
        }
    }
    interface IPlayable
    {
        void Play();
        void Pause();
    }
    interface IRecordable
    {
        void Record();
        void StopRecording();
    }
    class MediaPlayer : IPlayable, IRecordable
    {
        public void Play()
        {
            Console.WriteLine("Playing!");
        }
        public void Pause()
        {
            Console.WriteLine("Pausing!");
        }
        public void Record()
        {
            Console.WriteLine("Recording!");
        }
        public void StopRecording()
        {
            Console.WriteLine("StopRecording!");
        }

    }
}
