using Day58.Models;
using Day58.DTOs;
using Day58.Common;

namespace Day58.Services.OrderServices;

public interface IOrderService
{
    Order? GetById(int id);
    Result<Order> CreateOrder(CreateOrderDTO createDTO);
    
}