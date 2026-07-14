using Warehouse.Data.Entities;

namespace WarehouseApp.Services;

public interface ICategoryService
{
    Task<IEnumerable<Category>> GetAllAsync();
}