using Day55.Services.RestaurantServices;
using Day55.DTOs;
using Day55.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace Day55.Controllers;

[ApiController]
[Route("api/v1/[controller]")]

public class  RestaurantController : ControllerBase
{
    private readonly IRestaurantService _restaurantService;

    public RestaurantController(IRestaurantService restaurantService)
    {
        _restaurantService = restaurantService;
    }

    [HttpGet("{id}")]
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
    public IActionResult GetAllRestaurants([FromQuery] string? address, [FromQuery] int page=1, [FromQuery] int pageSize=3)
    {
        var restaurants = _restaurantService.GetAll(address, page, pageSize);
        var restaurantDTOs = restaurants.Select(r => r.ToDTO()).ToList();
        return Ok(restaurantDTOs);
    }

}