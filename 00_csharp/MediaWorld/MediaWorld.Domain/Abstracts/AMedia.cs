using System.Threading;
using MediaWorld.Domain.Interfaces;
using static MediaWorld.Domain.Delegates.ControlDelegate;

namespace MediaWorld.Domain.Abstracts
{
  public abstract class AMedia : IControl
  {
    public event ResultDelegate ResultEvent;
    
    public string title { get; set; }
    public System.TimeSpan duration { get; set; }
    
    public abstract bool Rewind();

    public abstract bool Forward();

    public virtual bool Pause()
    {
      throw new System.NotImplementedException();
    }

    public virtual bool Play()
    {
      int count = 0;
      if (ResultEvent == null)
      {
        return false;
      }
      while(count < 10)
      {
        Thread.Sleep(2000);
        ResultEvent(this);
        count++;
      }
      return true;
    }


    public bool Stop()
    {
      throw new System.NotImplementedException();
    }

    public override string ToString()
    {
      return $"{this}";
    }
  }
}