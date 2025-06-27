namespace SimonSays.Authentication.Application.Interfaces;

/// <summary>
/// Interface for password hashing operations using bcrypt.
/// Provides methods for hashing passwords and verifying password hashes.
/// </summary>
public interface IPasswordHasher
{
    /// <summary>
    /// Asynchronously hashes a plain text password using bcrypt.
    /// </summary>
    /// <param name="password">The plain text password to hash.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the hashed password.</returns>
    Task<string> HashPasswordAsync(string password);

    /// <summary>
    /// Asynchronously verifies a plain text password against a hashed password.
    /// </summary>
    /// <param name="password">The plain text password to verify.</param>
    /// <param name="hashedPassword">The hashed password to verify against.</param>
    /// <returns>A task that represents the asynchronous operation. The task result is true if the password matches; otherwise, false.</returns>
    Task<bool> VerifyPasswordAsync(string password, string hashedPassword);
} 