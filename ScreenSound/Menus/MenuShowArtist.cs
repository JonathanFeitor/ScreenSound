using ScreenSound.Database;
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuShowArtists : Menu
{
    public override void Execute(DAL<Artist> artistDAL)
    {
        base.Execute(artistDAL);
        DisplayOptionTitle("Displaying all registered artists in our application");

        foreach (var artist in artistDAL.List())
        {
            Console.WriteLine($"Artist: {artist}");
        }

        Console.WriteLine("\nType a key to return to the main menu");
        Console.ReadKey();
        Console.Clear();
    }
}
