using ScreenSound.Database;
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class ArtistRegistrationMenu : Menu
{
    public override void Execute(DAL<Artist> artistDAL)
    {
        base.Execute(artistDAL);
        DisplayOptionTitle("RegiArtist Register");
        Console.Write("Enter the name of the artist you want to register: ");
        string nameOfArtist = Console.ReadLine()!;
        Console.Write("Enter the bio of the artist you wish to register: ");
        string bioDoArtista = Console.ReadLine()!;
        Artist artist = new Artist(nameOfArtist, bioDoArtista);
        artistDAL.AddValue(artist);
        Console.WriteLine($"The artist {nameOfArtist} has been successfully registered!");
        Thread.Sleep(4000);
        Console.Clear();
    }
}
