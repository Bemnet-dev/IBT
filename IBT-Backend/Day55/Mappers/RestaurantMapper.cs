using Day55.DTOs;
using Day55.Models;

namespace Day55.Mappers;

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