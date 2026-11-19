using Day56.Services.OrderServices;
using Day56.DTOs;
using Day56.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day56.Controllers;

[ApiController]
[Route("api/[controller]")]

public class OrderController : ControllerBase
{
    private readonly IOrderService _orderService;

    public OrderController(IOrderService orderService)
    {
        _orderService = orderService;
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var order = _orderService.GetById(id);

        if (order == null)
        {
            return NotFound();
        }
        return Ok(order);
    }

    [HttpPost()]
    public IActionResult CreateOrder([FromBody]CreateOrderDTO createDTO)
    {
        var order = _orderService.CreateOrder(createDTO);

        return CreatedAtAction( nameof(GetById), new { id = order.Id }, order);
    }

}



