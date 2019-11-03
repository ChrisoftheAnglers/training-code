using System;
using MediaWorld.Domain.Abstracts;
namespace MediaWorld.Domain.Models
{
  public class Photo : AVideo 
  {
    public Photo()
    {
      Initialize();
    }

    public Photo(string t, TimeSpan d, int fps)
    {
      Initialize(t, d, fps);
    }

    private void Initialize(string t = "Untitled", TimeSpan d = new TimeSpan(), int fps = 0)
    {
      title = t;
      duration = d;
      FrameRate = fps;
    }
  }
}