using System;
using System.Collections.Generic;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Abstracts
{
    public abstract class AInfo : IInfoDisplay
    {
      protected List<Order> Ledger = new List<Order>();
      protected string Name;
      protected string Address;
      protected string Phone;
      protected string Email;
      public virtual void printInfo()
      {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Address: " + Address);
        Console.WriteLine("Phone #: " + Phone);
        Console.WriteLine("Email: " + Email);
      }
      public virtual void changeInfo(string name, string address, string phone, string email)
      {
        Name = name;
        Address = address;
        Phone = phone;
        Email = email;
      }
    }
}