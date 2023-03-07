using System;
using System.Net.Http.Headers;
using MovieApp.Context;
using MovieApp.Models;

namespace ApplicationTemplate.Services;

/// <summary>
///     You would need to inject your interfaces here to execute the methods in Invoke()
///     See the commented out code as an example
/// </summary>
public class MainService : IMainService
{
    public MainService()
    {
        
    }

    public void Invoke() // Consider this your program.cs Main
    {
       // Write code here
       
       MediaContext context = new MediaContext();

       List<Media> media = new List<Media>();
       media.AddRange(context.Movies);
       media.AddRange(context.Shows);
       media.AddRange(context.Videos);


       foreach (var m in media)
       {
           m.Display();
       }
    }
}
