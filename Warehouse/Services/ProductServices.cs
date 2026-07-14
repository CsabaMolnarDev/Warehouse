using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;
using Warehouse.Data;
using Warehouse.Data.Entities;

namespace WarehouseApp.Services;

public class ProductService : ICategoryService
{
    private readonly AppDbContext _context;
    public ProductService(AppDbContext context) => _context = context;

    public async Task<IEnumerable<Category>> GetAllAsync()
    {
        return await _context.Categories.ToListAsync();
    }

}