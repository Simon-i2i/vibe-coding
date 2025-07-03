using SimonSays.AuthService.Application.DTOs;
using SimonSays.AuthService.Application.Interfaces;
using SimonSays.AuthService.Domain;
using System.Threading.Tasks;
using System;

namespace SimonSays.AuthService.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<AuthResponseDto> RegisterAsync(RegisterUserDto dto)
        {
            var existing = await _userRepository.GetByEmailAsync(dto.Email);
            if (existing != null)
                throw new Exception("User already exists");

            var user = new User
            {
                Id = Guid.NewGuid(),
                UserName = dto.UserName,
                Email = dto.Email,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(dto.Password),
                CreatedAt = DateTime.UtcNow
            };
            await _userRepository.AddAsync(user);
            // Token generation will be handled by OpenIddict
            return new AuthResponseDto { UserName = user.UserName, Email = user.Email };
        }

        public async Task<AuthResponseDto> LoginAsync(LoginUserDto dto)
        {
            var user = await _userRepository.GetByEmailAsync(dto.Email);
            if (user == null || !BCrypt.Net.BCrypt.Verify(dto.Password, user.PasswordHash))
                throw new Exception("Invalid credentials");
            // Token generation will be handled by OpenIddict
            return new AuthResponseDto { UserName = user.UserName, Email = user.Email };
        }
    }
} 