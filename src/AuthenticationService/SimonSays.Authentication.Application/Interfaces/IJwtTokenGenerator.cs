using SimonSays.Authentication.Application.DTOs;
using SimonSays.Authentication.Domain.Entities;

namespace SimonSays.Authentication.Application.Interfaces;

/// <summary>
/// Interface for JWT token generation operations.
/// Provides methods for creating authentication tokens for users.
/// </summary>
public interface IJwtTokenGenerator
{
    /// <summary>
    /// Asynchronously generates a JWT token for the specified user.
    /// </summary>
    /// <param name="user">The user for whom to generate the token.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the authentication response with the JWT token.</returns>
    Task<AuthResponseDto> GenerateTokenAsync(User user);

    /// <summary>
    /// Asynchronously validates a JWT token and extracts user information.
    /// </summary>
    /// <param name="token">The JWT token to validate.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the user ID if the token is valid; otherwise, null.</returns>
    Task<Guid?> ValidateTokenAsync(string token);
} 