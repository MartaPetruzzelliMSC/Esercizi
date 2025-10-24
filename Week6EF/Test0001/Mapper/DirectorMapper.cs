using Test0001.Dtos;
using Test0001.Models;

namespace Test0001.Mapper
{
    public static class DirectorMapper
    {
        public static DirectorDto ToDto(this Director director)
        {
            return new DirectorDto
            {
                Id = director.Id,
                CreationDate = director.CreationDate,
                UpdateDate = director.UpdateDate,
                Name = director.Name,
                Surname = director.Surname
            };
        }
    }
}
