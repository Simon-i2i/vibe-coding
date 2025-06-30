using SimonSays.Authentication.Domain.ValueObjects;
using SimonSays.Authentication.Domain.Exceptions;

namespace SimonSays.Authentication.Domain.Entities;

/// <summary>
/// Represents a user in the authentication system.
/// This entity encapsulates user identity and authentication data.
/// </summary>
public class User
{
    /// <summary>
    /// Gets the unique identifier for the user.
    /// </summary>
    public Guid Id { get; private set; }

    /// <summary>
    /// Gets the user's email address.
    /// </summary>
    public Email Email { get; private set; }

    /// <summary>
    /// Gets the hashed password for the user.
    /// </summary>
    public PasswordHash PasswordHash { get; private set; }

    /// <summary>
    /// Gets the date and time when the user was created.
    /// </summary>
    public DateTime CreatedAt { get; private set; }

    /// <summary>
    /// Gets the date and time when the user was last updated.
    /// </summary>
    public DateTime UpdatedAt { get; private set; }

    /// <summary>
    /// Gets a value indicating whether the user account is active.
    /// </summary>
    public bool IsActive { get; private set; }

    /// <summary>
    /// Initializes a new instance of the User class.
    /// </summary>
    /// <param name="email">The user's email address.</param>
    /// <param name="passwordHash">The hashed password.</param>
    /// <exception cref="DomainValidationException">Thrown when validation fails.</exception>
    public User(Email email, PasswordHash passwordHash)
    {
        Id = Guid.NewGuid();
        Email = email ?? throw new DomainValidationException("Email cannot be null.");
        PasswordHash = passwordHash ?? throw new DomainValidationException("Password hash cannot be null.");
        CreatedAt = DateTime.UtcNow;
        UpdatedAt = DateTime.UtcNow;
        IsActive = true;
    }

    /// <summary>
    /// Private constructor for EF Core.
    /// </summary>
    private User() { }

    /// <summary>
    /// Updates the user's password hash.
    /// </summary>
    /// <param name="newPasswordHash">The new hashed password.</param>
    /// <exception cref="DomainValidationException">Thrown when the new password hash is null.</exception>
    public void UpdatePassword(PasswordHash newPasswordHash)
    {
        PasswordHash = newPasswordHash ?? throw new DomainValidationException("New password hash cannot be null.");
        UpdatedAt = DateTime.UtcNow;
    }

    /// <summary>
    /// Deactivates the user account.
    /// </summary>
    public void Deactivate()
    {
        IsActive = false;
        UpdatedAt = DateTime.UtcNow;
    }

    /// <summary>
    /// Activates the user account.
    /// </summary>
    public void Activate()
    {
        IsActive = true;
        UpdatedAt = DateTime.UtcNow;
    }

    /// <summary>
    /// Validates if the provided password hash matches the user's stored password hash.
    /// </summary>
    /// <param name="passwordHash">The password hash to validate.</param>
    /// <returns>True if the password hash matches; otherwise, false.</returns>
    public bool ValidatePassword(PasswordHash passwordHash)
    {
        return PasswordHash.Equals(passwordHash);
    }
} 