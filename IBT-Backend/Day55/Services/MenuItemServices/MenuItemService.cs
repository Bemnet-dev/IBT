using Day55.Models;

namespace Day55.Services.MenuItemServices;

public class MenuItemService : IMenuItemService
{
    private readonly List<MenuItem> _menuItems = new()
    {
        new MenuItem { Id = 1, Name = "Pizza", Category = "Main Course" , Price = 9.99m },
        new MenuItem { Id = 2, Name = "Burger", Category = "Main Course", Price = 7.99m  },
        new MenuItem { Id = 3, Name = "Pasta", Category = "Main Course", Price = 8.99m  }
    };
    public List<MenuItem> GetAll(string? category)
    {
        var items = _menuItems
            .Where(x => category == null || x.Category == category)
            .ToList();
        return items;
    }
    public MenuItem? GetById(int id)
    {
        return _menuItems.Where(m => m.Id == id).FirstOrDefault();
    }
};