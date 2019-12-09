using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Interfaces
{
    public interface IKiosk
    {
        void ReadyOrder();
        void PrintOrder();
        void PrintStoreInfo();
        void PrintUserInfo();
    }
}