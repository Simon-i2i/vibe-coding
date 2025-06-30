using System.ComponentModel.DataAnnotations;

namespace SimonSays.Authentication.Application.DTOs;

/// <summary>
/// Data Transfer Object for user login requests.
/// Contains validation attributes for input validation.
/// </summary>
public class LoginUserDto
{
    /// <summary>
    /// Gets or sets the email address for login.
    /// Must be a valid email format.
    /// </summary>
    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress(ErrorMessage = "Invalid email format.")]
    public string Email { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the password for login.
    /// Required field for authentication.
    /// </summary>
    [Required(ErrorMessage = "Password is required.")]
    public string Password { get; set; } = string.Empty;
} 