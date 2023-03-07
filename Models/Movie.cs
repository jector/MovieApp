using System.Net.Mime;

namespace MovieApp.Models;

public class Movie : Media
{
    public string Theater { get; set; }

    public override void Display()
    {
        Console.WriteLine($"{Title} in {Theater}");
    }
}