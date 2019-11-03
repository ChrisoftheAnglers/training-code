using System;
using MediaWorld.Domain.Abstracts;
namespace MediaWorld.Domain.Models
{
  public class Movie : AVideo 
  {
    public Movie()
    {
      Initialize();
    }

    public Movie(string title, TimeSpan duration, int fps) 
    {
      Initialize(title, duration, fps);
    }

    private void Initialize(string t = "Untitled", TimeSpan d = new TimeSpan(), int fps = 24)
    {
      title = t;
      duration = d;
      FrameRate = fps;
    }
  }
}