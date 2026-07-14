using Warehouse.Entities;

namespace Warehouse.Data.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public required string Name { get; set; }   //F.E. Electronics, Furniture, Clothing

        // Relationship -> One Category can have many Products (Laravel: hasMany)
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
