using ScreenSound.Database;
using ScreenSound.Menus;
using ScreenSound.Modelos;

var context = new ScreenSoundContext();
var objectDal = new DAL<Artist>(context);

Dictionary<int, Menu> opt = new();
opt.Add(1, new ArtistRegistrationMenu());
opt.Add(2, new RegisterMusicMenu());
opt.Add(3, new MenuShowArtists());
opt.Add(4, new MenuShowMusic());
opt.Add(-1, new ExitMenu());

void DisplayLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine("Welcome to Screen Sound 3.0!");
}

void DisplayMenuOptions()
{
    DisplayLogo();
    Console.WriteLine("\nEnter 1 to register an artist");
    Console.WriteLine("Type 2 to register an artist's song");
    Console.WriteLine("Type 3 to show all artists");
    Console.WriteLine("Type 4 to display all the songs by an artist");
    Console.WriteLine("Type -1 to exit");

    Console.Write("\nEnter your option: ");
    string optionChoice = Console.ReadLine()!;
    int optionChoiceNumerical = int.Parse(optionChoice);

    if (opt.ContainsKey(optionChoiceNumerical))
    {
        Menu menuToBeDisplay = opt[optionChoiceNumerical];
        menuToBeDisplay.Execute(objectDal);
        if (optionChoiceNumerical > 0) DisplayMenuOptions();
    } 
    else
    {
        Console.WriteLine("Invalid option");
    }
}

DisplayMenuOptions();