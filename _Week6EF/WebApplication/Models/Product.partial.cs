namespace WebApplicationEF.Models
{

    public partial class Product
    {
        public string WarehouseName
        {
            get { return Warehouse.Location; }
        }
    }
}
