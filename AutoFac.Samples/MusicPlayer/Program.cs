using Autofac;
using MusicPlayer.Interfaces;
using MusicPlayer.Services;

namespace MusicPlayer
{
    class Program
    {
        private static IContainer Container { get;set; }
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<VLCMediaPlayer>().As<IPlayer>();

            Container = builder.Build();

            IPlayer player = Container.Resolve<IPlayer>();
            player.Play("Beliver.mp3");
            player.Pause();
            player.Stop();
        }
    }
}
