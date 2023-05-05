using KpiNew.Dtos;
namespace KpiNew.Interface.Service
{
    public interface IUserService
    {
        Task<BaseRespond<UserDto>> GetUserByIdAsync(int id);
        Task<BaseRespond<UserDto>> GetUserByEmailAsync(string email);
        Task<BaseRespond<ICollection<UserDto>>> GetAllUserAsync();
        Task<BaseRespond<UserDto>> Login(LoginUserDto model);

    }
}