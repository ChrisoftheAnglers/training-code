using PizzaBox.Domain.Interfaces;
using System;
using System.Globalization;
namespace PizzaBox.Domain.Abstracts
{
    public abstract class AMenu : IMenuSelection
    {
      protected int[] ExtraCosts = new int[] {0, 50, 100, 150}; 
      public enum EToppings{cheese, pepperoni, chicken, sausage};
      public enum ECrusts{thin, thick, stuffed};
      public enum ESauces{tomato, buffalo, barbeque};
      protected int basePrice = 500;
      protected struct item
      {
        int Price;
        string Name;
        public item(int price, string name)
        {
          Name = name.ToLower();
          Price = price;
        }
      }
        // public void printMenuItem()
        // {
        //   Console.WriteLine("This Pizza has: ");
        //   Console.WriteLine(topping.Name);
        //   Console.WriteLine(crust.Name);
        //   Console.WriteLine(sauce.Naming);
        //   Console.WriteLine("and it costs {cost}", totalCost());

        // }

        // public string totalCost()
        // {
        //   int total = sauce.Pricing + topping.Pricing + crust.Pricing;
        //   return total.ToString("C2", CultureInfo.CurrentCulture);
        // }
    }
}