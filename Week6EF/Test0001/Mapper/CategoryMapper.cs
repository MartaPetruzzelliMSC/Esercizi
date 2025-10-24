using Test0001.Dtos;
using Test0001.Models;
using Test0001.Requests;

namespace Test0001.Mapper
{
    public static class CategoryMapper
    {
        public static CategoryDto ToDto(this Category category)
        {
            return new CategoryDto
            {
                Id = category.Id,
                CreationDate = category.CreationDate,
                UpdateDate = category.UpdateDate,
                Name = category.Name
            };
        }

        public static Category ToModel(this CreateCategoryDto category)
        {
            return new Category
            {
                Name = category.Name,
            };
        }
    }
}
