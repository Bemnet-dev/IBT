using Day59.Services.RestaurantServices;
using Day59.DTOs;
using Day59.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace Day59.Controllers;

[ApiController]
[Route("api/v1/[controller]")]

public class  RestaurantController : ControllerBase
{
    private readonly IRestaurantService _restaurantService;

    public RestaurantController(IRestaurantService restaurantService)
    {
        _restaurantService = restaurantService;
    }

    [HttpGet("{id:int:min(1)}")]
    public IActionResult GetRestaurantById(int id)
    {
        var restaurant = _restaurantService.GetById(id);

        if (restaurant == null)
        {
            return NotFound();
        }
        return Ok(restaurant);
    }

    [HttpGet()]
    public IActionResult GetAllRestaurants([FromQuery] RestaurantQuery query)
    {
        var restaurants = _restaurantService.GetAll(query);
        return Ok(restaurants);
    }

    [HttpGet("active")]
    public IActionResult GetAllActiveRestaurants()
    {
        var restaurants = _restaurantService.GetAllActive();
        var restaurantDTOs = restaurants.Select(r => r.ToDTO()).ToList();
        return Ok(restaurantDTOs);
    }
}