using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;
using static PizzaBox.Domain.Abstracts.AMenu;

namespace PizzaBox.Domain.Factories
{
    public class PizzaFactory : IPizzaFactory
    {
      public Pizza Pepperoni()
      {
        return new Pizza(EToppings.cheese); //Initialize with constructor to get pepperoni pizza
      }
      public Pizza PepperoniStuffedCrust()
      {
        return new Pizza();
      }

      public Pizza BuffaloCkn()
      {
        return new Pizza();
      }

      public Pizza BBQCkn()
      {
        return new Pizza();
      }

      public Pizza MeatLovers()
      {
        return new Pizza();
      }

      public Pizza MeatLoversStuffedCrust()
      {
        return new Pizza();
      }
    }
}