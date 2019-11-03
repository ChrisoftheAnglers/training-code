using MediaWorld.Domain.Abstracts;
using MediaWorld.Domain.Interfaces;
using static MediaWorld.Domain.Delegates.ControlDelegate;

namespace MediaWorld.Domain.Singletons
{
  public class MediaSingleton : IPlayer
  {
    private MediaSingleton() {}
    private static readonly MediaSingleton _instance = new MediaSingleton();
    public static MediaSingleton Instance 
    { 
      get 
      {
        return _instance;
      } 
    }

    public bool Execute(ButtonDelegate button, AMedia media)
    {
      media.ResultEvent += ResultHandler;
      return button();
    }
    
    public void ResultHandler(AMedia media)
    {
      System.Console.WriteLine("{0} is playing...", media.title);
    }

    bool IVolume.VolumeUp()
    {
      return true;
    }

    bool IVolume.VolumeDown()
    {
      return true;
    }

    bool IVolume.VolumeMute()
    {
      return false;
    }
  } 
}