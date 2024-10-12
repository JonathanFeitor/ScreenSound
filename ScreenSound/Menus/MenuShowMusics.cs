using ScreenSound.Database;
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuShowMusic : Menu
{
    public override void Execute(DAL<Artist> artistDAL)
    {
        base.Execute(artistDAL);
        DisplayOptionTitle("View artist details");
        Console.Write("Enter the name of the artist you want to learn more about: ");
        string nameOfArtist = Console.ReadLine()!;
        var recoveryArtist = artistDAL.RecoveryByObject(artistDAL => artistDAL.Name.Equals(nameOfArtist));
        if (recoveryArtist is not null)
        {
            Console.WriteLine("\nDiscography:");
            recoveryArtist.ViewDiscography();
            Console.WriteLine("\nEnter a key to return to the main menu");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"\nThe artist {nameOfArtist} not found!");
            Console.WriteLine("Enter a key to return to the main menu");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
