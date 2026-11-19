using Day56.Models;

namespace Day56.DTOs;

public record CreateOrderDTO
(

    int ResturantId,
    int MenuItemId,
    string CustomerName,
    string DeliveryAddress,
    string CustomerPhone,
    int Quantity,
    decimal TotalAmount
);
