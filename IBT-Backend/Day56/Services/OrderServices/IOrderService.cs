using Day56.Models;
using Day56.DTOs;

namespace Day56.Services.OrderServices;

public interface IOrderService
{
    Order? GetById(int id);
    Order CreateOrder(CreateOrderDTO createDTO);
    
}