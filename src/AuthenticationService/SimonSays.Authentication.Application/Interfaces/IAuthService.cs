using SimonSays.Authentication.Application.DTOs;

namespace SimonSays.Authentication.Application.Interfaces;

/// <summary>
/// Interface for authentication service operations.
/// Provides methods for user registration and login functionality.
/// </summary>
public interface IAuthService
{
    /// <summary>
    /// Asynchronously registers a new user with the provided credentials.
    /// </summary>
    /// <param name="registerDto">The registration data containing email and password.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the authentication response with JWT token.</returns>
    /// <exception cref="ApplicationException">Thrown when registration fails (e.g., email already exists).</exception>
    Task<AuthResponseDto> RegisterAsync(RegisterUserDto registerDto);

    /// <summary>
    /// Asynchronously authenticates a user with the provided credentials.
    /// </summary>
    /// <param name="loginDto">The login data containing email and password.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the authentication response with JWT token.</returns>
    /// <exception cref="ApplicationException">Thrown when authentication fails (e.g., invalid credentials).</exception>
    Task<AuthResponseDto> LoginAsync(LoginUserDto loginDto);
} 