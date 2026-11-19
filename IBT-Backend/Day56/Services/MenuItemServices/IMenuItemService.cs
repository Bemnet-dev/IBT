using Day56.Models;

namespace Day56.Services.MenuItemServices;

public interface IMenuItemService

{
    List<MenuItem> GetAll(string? category);
    MenuItem? GetById(int id);
}