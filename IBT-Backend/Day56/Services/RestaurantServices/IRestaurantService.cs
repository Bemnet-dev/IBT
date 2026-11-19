using Day56.Models;
using Day56.DTOs;

namespace Day56.Services.RestaurantServices;

public interface IRestaurantService
{
	Restaurant? GetById(int id);
    PaginatedResultDTO<RestaurantDTO> GetAll(RestaurantQuery query);
    List<Restaurant> GetAllActive();

}