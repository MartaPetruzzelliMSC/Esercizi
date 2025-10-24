namespace Test0001.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }

        public IEnumerable<Movie> Movies { get; set; }
    }
}
