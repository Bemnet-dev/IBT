using Day56.DTOs;
using Day56.Models;

namespace Day56.Mappers;

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