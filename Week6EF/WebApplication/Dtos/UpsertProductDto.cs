namespace WebApplicationEF.Dtos
{
    public class UpsertProductDto
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int WarehouseId { get; set; }
    }
}
