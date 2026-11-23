using Day59.Models;
using Day59.DTOs;

namespace Day59.Services.RestaurantServices;

public interface IRestaurantService
{
	Restaurant? GetById(int id);
    PaginatedResultDTO<RestaurantDTO> GetAll(RestaurantQuery query);
    List<Restaurant> GetAllActive();

}