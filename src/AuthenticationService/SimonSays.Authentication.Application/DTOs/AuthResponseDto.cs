namespace SimonSays.Authentication.Application.DTOs;

/// <summary>
/// Data Transfer Object for authentication responses.
/// Contains the JWT token and user information upon successful authentication.
/// </summary>
public class AuthResponseDto
{
    /// <summary>
    /// Gets or sets the JWT access token for authenticated requests.
    /// </summary>
    public string AccessToken { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the token type (typically "Bearer").
    /// </summary>
    public string TokenType { get; set; } = "Bearer";

    /// <summary>
    /// Gets or sets the expiration time of the token in seconds.
    /// </summary>
    public int ExpiresIn { get; set; }

    /// <summary>
    /// Gets or sets the user identifier.
    /// </summary>
    public Guid UserId { get; set; }

    /// <summary>
    /// Gets or sets the user's email address.
    /// </summary>
    public string Email { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the date and time when the token was issued.
    /// </summary>
    public DateTime IssuedAt { get; set; }

    /// <summary>
    /// Gets or sets the date and time when the token expires.
    /// </summary>
    public DateTime ExpiresAt { get; set; }
} 