using PizzaBox.Domain.Abstracts;
using static PizzaBox.Domain.Abstracts.AMenu;

namespace PizzaBox.Domain.Models
{
  public class Store : AInfo
  {
    public Store(string name, string address, string phone, string email)
    {
      Name = name;
      Address = address;
      Phone = phone;
      Email = email;
    }
    public override void changeInfo(string name, string address, string phone, string email)
    {
      System.Console.WriteLine("Access denied, store cannot have info changed");
    }
    
  }

}