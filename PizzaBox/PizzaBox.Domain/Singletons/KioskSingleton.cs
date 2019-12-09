namespace PizzaBox.Domain.Singletons
{
    public class KioskSingleton
    {
      private KioskSingleton() {}
      private static readonly KioskSingleton _instance = new KioskSingleton();
      public static KioskSingleton Instance
      {
        get
        {
          return _instance;
        }
      }
      
    }
}