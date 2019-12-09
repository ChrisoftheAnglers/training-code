using PizzaBox.Domain.Models;
namespace PizzaBox.Domain.Interfaces
{
    interface IPizzaFactory
    {
        Pizza Pepperoni();
        Pizza PepperoniStuffedCrust();
        Pizza BuffaloCkn();
        Pizza BBQCkn();
        Pizza MeatLovers();
        Pizza MeatLoversStuffedCrust();
    }
}