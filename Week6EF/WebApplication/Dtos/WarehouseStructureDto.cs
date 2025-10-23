namespace WebApplicationEF.Dtos
{
    public class WarehouseStructureDto
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public IEnumerable<ProductStructureDto>? ProductDtos { get; set; }
    }
}
