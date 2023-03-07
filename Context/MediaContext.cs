using MovieApp.Models;

namespace MovieApp.Context;

public class MediaContext
{
    public List<Movie> Movies { get; set; }
    public List<Show> Shows { get; set; }
    public List<Video> Videos { get; set; }
    
    public MediaContext()
    {
        Movies = new List<Movie>();
        Movies.Add(new Movie() { Id = 1, Title = "Mission impossible"});
        Movies.Add(new Movie() { Id = 2, Title = "Mission impossible 2"});
        Movies.Add(new Movie() { Id = 3, Title = "Mission impossible 3"});
        Movies.Add(new Movie() { Id = 4, Title = "Mission impossible 4"});
        
        Shows = new List<Show>();
        Shows.Add(new Show() { Id = 1, Title = "Low an Order"});
        Shows.Add(new Show() { Id = 2, Title = "Low an Order 2"});
        Shows.Add(new Show() { Id = 3, Title = "Low an Order 3"});
        Shows.Add(new Show() { Id = 4, Title = "Low an Order 4"});
        
        Videos = new List<Video>();
        Videos.Add(new Video() { Id = 1, Title = "Coding Tutorial"});
        Videos.Add(new Video() { Id = 2, Title = "Coding Tutorial 2"});
        Videos.Add(new Video() { Id = 3, Title = "Coding Tutorial 3"});
        Videos.Add(new Video() { Id = 4, Title = "Coding Tutorial 4"});
        
    }
    
    
    
    
}

