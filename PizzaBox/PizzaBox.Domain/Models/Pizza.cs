using PizzaBox.Domain.Abstracts;
namespace PizzaBox.Domain.Models
{
  public class Pizza : AMenu
  {
    public Pizza(EToppings a, ECrusts b, ESauces c)
    {
      string topName;
      int topPrice;
      string crustName;
      int crustPrice;
      string sauceName;
      int saucePrice;
      switch (a)
      {
        case EToppings.chicken:
          topName = EToppings.chicken.ToString();
          topPrice = ExtraCosts[3];
          break;
        case EToppings.pepperoni:
          topName = EToppings.pepperoni.ToString();
          topPrice = ExtraCosts[2];
          break;
        case EToppings.sausage:
          topName = EToppings.sausage.ToString();
          topPrice = ExtraCosts[3];
          break;
        case EToppings.cheese:
        default:
          topName = EToppings.cheese.ToString();
          topPrice = ExtraCosts[0];
          break;
      }
      switch (b)
      {
        case ECrusts.stuffed:
          crustName = ECrusts.stuffed.ToString();
          crustPrice = ExtraCosts[2];
          break;
        case ECrusts.thin:
          crustName = ECrusts.thin.ToString();
          crustPrice = ExtraCosts[0];
          break;
        case ECrusts.thick:
        default:
          crustName = ECrusts.thick.ToString();
          crustPrice = ExtraCosts[0];
          break;
      }
      switch (c)
      {
        case ESauces.barbeque:
          sauceName = ESauces.barbeque.ToString();
          saucePrice = ExtraCosts[1];
          break;
        case ESauces.buffalo:
          sauceName = ESauces.buffalo.ToString();
          saucePrice = ExtraCosts[1];
          break;
        case ESauces.tomato:
        default:
          sauceName = ESauces.tomato.ToString();
          saucePrice = ExtraCosts[0];
          break;
      }
      item Topping = new item(topPrice, topName);
      item Sauce = new item(saucePrice, sauceName);
      item Crust = new item(crustPrice, crustName);
    }
  }
}