namespace DTO
{
    public class ProductRequestDto
    {
        public string Name { get; set; } = null!;
        public string SKU { get; set; } = null!;
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
