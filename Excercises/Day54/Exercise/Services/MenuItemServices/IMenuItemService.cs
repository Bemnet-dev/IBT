using Day58.Models;

namespace Day58.Services.MenuItemServices;

public interface IMenuItemService

{
    List<MenuItem> GetAll(string? category);
    MenuItem? GetById(int id);
}