namespace PieShop.Models
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
