namespace Warehouse.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string SKU { get; set; } // Stock Keeping Unit (Unique identifier)
        [Column(TypeName = "decimal(18, 2)")] // Ensures proper precision and scale for currency values
        public decimal Price { get; set; }
        public int Quantity { get; set; } // Current stock level

        // Foreign Key: Links to Category
        public int CategoryId { get; set; }

        // Relationship: Product belongs to a Category (Laravel: belongsTo)
        public Category? Category { get; set; }
    }
}
