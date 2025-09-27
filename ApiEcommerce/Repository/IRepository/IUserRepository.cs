using ApiEcommerce.Models.Dtos;
using ApiEcommerce.Models;

namespace ApiEcommerce.Repository.IRepository
{
    public interface IUserRepository
    {
        ICollection<ApplicationUser> GetUsers();
        ApplicationUser? GetUser(string id);
        bool IsUniqueUser(string username);
        Task<UserLoginResponseDto> Login(UserLoginDto userLoginDto);
        Task<UserDataDto> Register(CreateUserDto createUserDto);
    }
}
