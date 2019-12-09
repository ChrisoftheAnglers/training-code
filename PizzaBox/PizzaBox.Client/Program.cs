using System;
using PizzaBox.Domain.Singletons;

namespace PizzaBox.Client
{
    internal class Program
    {
      private static void Main()
      {
        OrderUp();
      }
      static void OrderUp()
      {
        var Kiosk = KioskSingleton.Instance;
        Console.WriteLine("We're not accepting orders today");
      }
      // static User UserLogin()
      // {
        
      //   return new User();
      // }
    }
}
