using Day59.Models;

namespace Day59.DTOs;

public record RestaurantDTO
(
    int Id,
    string Name,
    string Address,
    string Phone,
    bool IsActive
);