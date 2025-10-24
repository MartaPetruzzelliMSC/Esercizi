namespace Test0001.Models
{
    public class Director : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public IEnumerable<Movie> Movies { get; set; }
    }
}
