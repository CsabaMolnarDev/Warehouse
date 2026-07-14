using Warehouse.Data.Entities;

namespace WarehouseApp.Services;

public interface IProductService
{
    Task<IEnumerable<Product>> GetAllAsync();
}
