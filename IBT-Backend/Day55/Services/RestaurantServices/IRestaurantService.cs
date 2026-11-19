using Day55.Models;

namespace Day55.Services.RestaurantServices;

public interface IRestaurantService
{
	Restaurant? GetById(int id);
	List<Restaurant> GetAll(string? address, int page, int pageSize);

}