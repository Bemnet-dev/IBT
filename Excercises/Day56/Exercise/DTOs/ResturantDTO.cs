using Day58.Models;

namespace Day58.DTOs;

public record RestaurantDTO
(
    int Id,
    string Name,
    string Address,
    string Phone,
    bool IsActive
);