namespace MusicPlayer.Interfaces
{
    public interface IPlayer
    {
        void Play(string path);
        void Pause();
        void Stop();
    }
}
