using Day56.Models;
using Day56.DTOs;

namespace Day56.Services.OrderServices;

public class OrderService : IOrderService
{
    private static readonly List<Order> _orders = new List<Order>();

    private static int _nextid = 1;

    public Order ? GetById(int id)
    {
        return _orders.FirstOrDefault(o => o.Id == id);
    }

    public Order CreateOrder(CreateOrderDTO createDTO)
    {
        Order o = new Order
        {
            Id = _nextid++,
            ResturantId = createDTO.ResturantId,
            MenuItemId = createDTO.MenuItemId,
            CustomerName = createDTO.CustomerName,
            DeliveryAddress = createDTO.DeliveryAddress,
            CustomerPhone = createDTO.CustomerPhone,
            Quantity = createDTO.Quantity,
            TotalAmount = createDTO.TotalAmount
        };

        _orders.Add(o);
        return o;
    }

}