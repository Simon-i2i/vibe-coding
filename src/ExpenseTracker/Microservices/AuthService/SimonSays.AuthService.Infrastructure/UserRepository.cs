using SimonSays.AuthService.Application.Interfaces;
using SimonSays.AuthService.Domain;
using SimonSays.AuthService.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace SimonSays.AuthService.Infrastructure
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;
        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<User?> GetByEmailAsync(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
        }

        public async Task AddAsync(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }
    }
} 