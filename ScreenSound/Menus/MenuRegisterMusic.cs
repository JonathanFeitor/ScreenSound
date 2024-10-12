using ScreenSound.Database;
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class RegisterMusicMenu : Menu
{
    public override void Execute(DAL<Artist> musictDAL)
    {
        base.Execute(musictDAL);
        DisplayOptionTitle("Music registration");
        Console.Write("Enter the artist whose song you want to register: ");
        string nameOfMusic = Console.ReadLine()!;
        var recoveryMusic = musictDAL.RecoveryByObject(a => a.Name.Equals(nameOfMusic));
        if (recoveryMusic is not null)
        {
            Console.Write("Now enter the song title: ");
            string musicTitle = Console.ReadLine()!;
            Console.Write("Now enter the launch year of music: ");
            string launchYear = Console.ReadLine()!;
            recoveryMusic.AddMusic(new Music(musicTitle) { LaunchYear = Convert.ToInt32(launchYear) });
            Console.WriteLine($"The song {musicTitle} by {nameOfMusic} has been successfully registered!");

            musictDAL.UpdateValue(recoveryMusic);
            Thread.Sleep(4000);
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"\nThe Artist {nameOfMusic} not found!");
            Console.WriteLine("Type a key to return to the main menu");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
