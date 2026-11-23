using Day58.Models;
using Day58.DTOs;

namespace Day58.Services.RestaurantServices;

public interface IRestaurantService
{
	Restaurant? GetById(int id);
    PaginatedResultDTO<RestaurantDTO> GetAll(RestaurantQuery query);
    List<Restaurant> GetAllActive();

}