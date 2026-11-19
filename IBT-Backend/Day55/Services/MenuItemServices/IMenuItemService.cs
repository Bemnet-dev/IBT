using Day55.Models;

namespace Day55.Services.MenuItemServices;

public interface IMenuItemService

{
    List<MenuItem> GetAll(string? category);
    MenuItem? GetById(int id);
}