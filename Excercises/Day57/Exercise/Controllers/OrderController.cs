using Day58.Services.OrderServices;
using Day58.DTOs;
using Day58.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day58.Controllers;

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
        var result = _orderService.CreateOrder(createDTO);

        if (!result.IsSuccess)
        {
            return Problem(title: result.Error? .Message, detail: result.Error?.Code, statusCode: result.Error?.Status);
        }

        var order = result.Value;

        return CreatedAtAction(nameof(GetById), new { id = result.Value.Id }, result.Value);
    }

}



