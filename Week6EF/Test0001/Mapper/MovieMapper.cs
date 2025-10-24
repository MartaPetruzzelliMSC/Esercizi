using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using Test0001.Dtos;
using Test0001.Models;
using Test0001.Requests;

namespace Test0001.Mapper
{
    public static class MovieMapper
    {
        public static MovieDto ToDto(this Movie movie)
        {
            return new MovieDto
            {
                Id = movie.Id,
                CreationDate = movie.CreationDate,
                UpdateDate = movie.UpdateDate,
                Title = movie.Title,
                ReleaseDate = movie.ReleaseDate,
                CategoryId = movie.CategoryId
            };
        }

        public static Movie ToModel(this CreateMovieDto movie)
        {
            return new Movie
            {
                Title = movie.Title,
                ReleaseDate = movie.ReleaseDate,
                CategoryId = movie.CategoryId
            };
        }
    }
}
