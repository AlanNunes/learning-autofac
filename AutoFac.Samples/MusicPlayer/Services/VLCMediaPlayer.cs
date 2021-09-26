using MusicPlayer.Interfaces;
using System;

namespace MusicPlayer.Services
{
    public class VLCMediaPlayer : IPlayer
    {
        private const string Name = "VLC Media Player";
        public void Pause()
        {
            Console.WriteLine("Music paused...");
        }

        public void Play(string path)
        {
            Console.WriteLine($"Playing music through {Name}");
        }

        public void Stop()
        {
            Console.WriteLine("Music stopped...");
        }
    }
}
