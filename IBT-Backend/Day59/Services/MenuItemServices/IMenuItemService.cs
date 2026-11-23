using Day59.Models;

namespace Day59.Services.MenuItemServices;

public interface IMenuItemService

{
    List<MenuItem> GetAll(string? category);
    MenuItem? GetById(int id);
}