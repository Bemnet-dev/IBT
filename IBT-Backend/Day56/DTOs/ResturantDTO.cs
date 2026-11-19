using Day56.Models;

namespace Day56.DTOs;

public record RestaurantDTO
(
    int Id,
    string Name,
    string Address,
    string Phone,
    bool IsActive
);