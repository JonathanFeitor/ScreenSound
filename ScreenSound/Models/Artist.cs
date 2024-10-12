namespace ScreenSound.Modelos; 

public class Artist 
{
    public virtual ICollection<Music> Musics { get; set; } = new List<Music>();

    public Artist(string name, string bio)
    {
        Name = name;
        Bio = bio;
        ProfilePhoto = "https://cdn.pixabay.com/photo/2016/08/08/09/17/avatar-1577909_1280.png";
    }

    public string Name { get; set; }
    public string ProfilePhoto { get; set; }
    public string Bio { get; set; }
    public int Id { get; set; }

    public void AddMusic(Music music)
    {
        Musics.Add(music);
    }
    public void ViewDiscography()
    {
        Console.WriteLine($"Artist discography {Name}");
        foreach (var music in Musics)
        {
            Console.WriteLine($"Music: {music.Name} - Launch Year: {music.LaunchYear}");
        }
    }

    public override string ToString()
    {
        return $@"Id: {Id}
            Name: {Name}
            Profile Photo: {ProfilePhoto}
            Bio: {Bio}";
    }
}