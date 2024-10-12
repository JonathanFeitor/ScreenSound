using ScreenSound.Database;
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class Menu
{
    public void DisplayOptionTitle(string title)
    {
        int numberOfLetters = title.Length;
        string asterisks = string.Empty.PadLeft(numberOfLetters, '*');
        Console.WriteLine(asterisks);
        Console.WriteLine(title);
        Console.WriteLine(asterisks + "\n");
    }
    public virtual void Execute(DAL<Artist> dal)
    {
        Console.Clear();
    }
}
