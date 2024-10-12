namespace ScreenSound.Modelos;

public class Music    
{
    public Music(string name)
    {
        Name = name;
    }

    public string Name { get; set; }
    public int Id { get; set; }
    public int? LaunchYear { get; set; }
    public virtual Artist? Artist { get; set; }

    public void ViewDatasheet()
    {
        Console.WriteLine($"Name: {Name}");
      
    }

    public override string ToString()
    {
        return @$"Id: {Id}
        Nome: {Name}";
    }
}