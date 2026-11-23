using Day59.Models;
using Microsoft.AspNetCore.Mvc;
using Day59.Services.MenuItemServices;

namespace Day59.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]

    public class MenuItemController : ControllerBase
    {
        private readonly IMenuItemService _menuItemService;

        public MenuItemController(IMenuItemService menuItemService)
        {
            _menuItemService = menuItemService;
        }

        [HttpGet()]
        public IActionResult GetAll([FromQuery] string? category)
        {
            var result = _menuItemService.GetAll(category);
            return Ok(result);
        }


        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var result = _menuItemService.GetById(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        
    }
}