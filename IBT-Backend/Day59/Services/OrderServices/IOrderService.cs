using Day59.Models;
using Day59.DTOs;
using Day59.Common;

namespace Day59.Services.OrderServices;

public interface IOrderService
{
    Order? GetById(int id);
    Result<Order> CreateOrder(CreateOrderDTO createDTO);
    
}