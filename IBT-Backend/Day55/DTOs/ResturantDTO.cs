using Day55.Models;

namespace Day55.DTOs;

public record RestaurantDTO
(
    int Id,
    string Name,
    string Address,
    string Phone,
    bool IsActive
);