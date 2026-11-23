using Day58.DTOs;
using Day58.Models;

namespace Day58.Mappers;

public static class RestaurantMapper
{
    public static RestaurantDTO ToDTO(this Restaurant restaurant)
    {
        return new RestaurantDTO(
            restaurant.Id,
            restaurant.Name,
            restaurant.Address,
            restaurant.Phone,
            restaurant.IsActive
        );
    }
};