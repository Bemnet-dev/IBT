using Day59.Models;
using Day59.DTOs;
using Day59.Common;
using Day59.Services.RestaurantServices;

namespace Day59.Services.OrderServices;

public class OrderService : IOrderService
{
    private static readonly List<Order> _orders = new List<Order>();

    private static int _nextid = 1;

    private readonly IRestaurantService _restaurantService;

    private readonly ILogger<OrderService> _logger;

    public OrderService(IRestaurantService restaurantService)
    {
        _restaurantService = restaurantService;
        _logger = logger
    }

    public Order ? GetById(int id)
    {
        return _orders.FirstOrDefault(o => o.Id == id);
    }

    public Result<Order> CreateOrder(CreateOrderDTO createDTO)
    {

        var restaurant = _restaurantService.GetById(createDTO.ResturantId);
        if(restaurant == null)
        {
            return Result<Order>.Fail("RESTAURANT_NOT_FOUND","the restaurant does not exist.", 404);
        }
        if(!restaurant.IsActive)
        {
            return Result<Order>.Fail("RESTAURANT_NOT_ACTIVE","the restaurant is not active.", 409);
        }

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
        return Result<Order>.OK(o);
    }

}