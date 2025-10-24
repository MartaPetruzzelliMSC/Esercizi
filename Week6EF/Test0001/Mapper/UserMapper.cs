using System.Runtime.CompilerServices;
using Test0001.Dtos;
using Test0001.Models;
using Test0001.Requests;

namespace Test0001.Mapper
{
    public static class UserMapper
    {
        public static UserDto ToDto(this User user)
        {
            return new UserDto
            {
                Id = user.Id,
                CreationDate = user.CreationDate,
                UpdateDate = user.UpdateDate,
                Username = user.Username,
                Email = user.Email
            };
        }

        public static User ToModel(this CreateUserDto user)
        {
            return new User
            {
                Username = user.Username,
                Email = user.Email
            };
        }
    }
}
