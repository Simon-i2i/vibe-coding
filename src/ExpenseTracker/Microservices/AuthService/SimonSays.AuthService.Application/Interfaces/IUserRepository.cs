using SimonSays.AuthService.Domain;
using System.Threading.Tasks;

namespace SimonSays.AuthService.Application.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetByEmailAsync(string email);
        Task AddAsync(User user);
    }
} 