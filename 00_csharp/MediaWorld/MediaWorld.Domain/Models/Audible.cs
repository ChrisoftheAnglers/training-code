using System;
using MediaWorld.Domain.Abstracts;
namespace MediaWorld.Domain.Models
{
  public class Audible : AAudio 
  {
    public Audible()
    {
      Initialize();
    }

    public Audible(string t, TimeSpan d, int bit)
    {
      Initialize(t, d, bit);
    }
    
    private void Initialize(string t = "Untitled", TimeSpan d = new TimeSpan(), int bit = 320)
    {
      title = t;
      duration = d;
      BitRate = bit;
    }
  }
}