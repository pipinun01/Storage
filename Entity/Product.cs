namespace Entity
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;
        public string SKU { get; set; } = null!;
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public DateTime CreatedAt { get; set; }

        public ICollection<StockOperation> StockOperations { get; set; } = new List<StockOperation>();
    }
}
