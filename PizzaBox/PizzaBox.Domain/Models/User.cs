using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  public class User : AInfo
  {
    public User(string name, string address, string phone, string email)
    {
      Name = name;
      Address = address;
      Phone = phone;
      Email = email;
    }
  }
}