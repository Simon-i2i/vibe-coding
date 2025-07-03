using SimonSays.AuthService.Application.DTOs;
using System.Threading.Tasks;

namespace SimonSays.AuthService.Application.Interfaces
{
    public interface IUserService
    {
        Task<AuthResponseDto> RegisterAsync(RegisterUserDto dto);
        Task<AuthResponseDto> LoginAsync(LoginUserDto dto);
    }
} 