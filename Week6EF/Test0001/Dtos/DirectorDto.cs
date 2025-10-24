using Test0001.Models;

namespace Test0001.Dtos
{
    public class DirectorDto : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        //public IEnumerable<MovieDto> Movies { get; set; }
    }
}
