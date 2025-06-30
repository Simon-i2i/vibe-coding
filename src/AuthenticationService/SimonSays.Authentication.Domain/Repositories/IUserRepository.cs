using SimonSays.Authentication.Domain.Entities;
using SimonSays.Authentication.Domain.ValueObjects;

namespace SimonSays.Authentication.Domain.Repositories;

/// <summary>
/// Repository interface for User entity operations.
/// Defines the contract for user data access operations.
/// </summary>
public interface IUserRepository
{
    /// <summary>
    /// Asynchronously retrieves a user by their email address.
    /// </summary>
    /// <param name="email">The email address to search for.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the user if found; otherwise, null.</returns>
    Task<User?> GetByEmailAsync(Email email);

    /// <summary>
    /// Asynchronously retrieves a user by their unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the user.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the user if found; otherwise, null.</returns>
    Task<User?> GetByIdAsync(Guid id);

    /// <summary>
    /// Asynchronously adds a new user to the repository.
    /// </summary>
    /// <param name="user">The user to add.</param>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task AddAsync(User user);

    /// <summary>
    /// Asynchronously updates an existing user in the repository.
    /// </summary>
    /// <param name="user">The user to update.</param>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task UpdateAsync(User user);

    /// <summary>
    /// Asynchronously checks if a user with the specified email exists.
    /// </summary>
    /// <param name="email">The email address to check.</param>
    /// <returns>A task that represents the asynchronous operation. The task result is true if the user exists; otherwise, false.</returns>
    Task<bool> ExistsAsync(Email email);

    /// <summary>
    /// Asynchronously saves all changes made to the repository.
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task SaveChangesAsync();
} 