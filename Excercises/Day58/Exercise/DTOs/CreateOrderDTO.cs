using Day58.Models;
using System.ComponentModel.DataAnnotations;
using Day58.Validation;

namespace Day58.DTOs;

public record CreateOrderDTO
(
    [Range(1, int.MaxValue, ErrorMessage = "RestaurantId must be a positive integer.")]
    int ResturantId,
    int MenuItemId,
    [Required(ErrorMessage = "CustomerName is required.")]
    string CustomerName,
    [StringLength(60, MinimumLength = 1, ErrorMessage = "DeliveryAddress is required.")]
    string DeliveryAddress,
    [Required(ErrorMessage = "CustomerPhone is required.")]
    [EthiopianMobile]
    string CustomerPhone,
    [Range(1, 50, ErrorMessage = "Quantity must be between 1 and 50.")]
    int Quantity,
    [Required(ErrorMessage = "TotalPrice is required.")]
    [ETBAmount]
    decimal TotalAmount
);