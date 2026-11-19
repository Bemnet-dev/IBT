using Day54.Models;

namespace Day54.Services.MenuItemServices;

public interface IMenuItemService

{
    List<MenuItem> GetAll(string? category);
    MenuItem? GetById(int id);
}