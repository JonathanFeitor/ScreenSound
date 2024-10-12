using ScreenSound.Database;
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class ExitMenu : Menu
{
    public override void Execute(DAL<Artist> dal)
    {
        Console.WriteLine("Buy Buy :)");
    }
}
