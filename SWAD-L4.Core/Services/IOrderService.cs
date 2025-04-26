using SWAD_L4.Core.Entities;

namespace SWAD_L4.Core.Services
{
    public interface IOrderService
    {
        Task<OrderEntity> CreateCustomOrderAsync(OrderEntity order);
        Task<OrderEntity> CreateBirthdayOrderAsync();
        Task<OrderEntity> UpdateOrderAsync(OrderEntity order);
        Task DeleteOrderAsync(int orderId);
        Task<decimal> CalculateOrderPriceAsync(int orderId);
        Task<OrderEntity> GetOrderByIdAsync(int orderId);
    }
}
