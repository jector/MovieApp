namespace MovieApp.Models;

public abstract class Media
{
    public int Id { get; set; }
    public string Title { get; set; }

    public virtual void Display()
    {
        Console.WriteLine($"This is {Title}");
    }
}
