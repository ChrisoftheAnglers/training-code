namespace MediaWorld.Domain.Models
{
  public class MediaSingleton
  {
    private MediaSingleton() {}
    private static readonly string _instance = "mediaplayer";
    public static string GetInstance()
    {
      return _instance;
    }
  } 
}