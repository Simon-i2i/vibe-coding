using System.Text.RegularExpressions;
using SimonSays.Authentication.Domain.Exceptions;

namespace SimonSays.Authentication.Domain.ValueObjects;

/// <summary>
/// Represents an email address value object with validation.
/// Ensures email format compliance using regex pattern validation.
/// </summary>
public class Email : IEquatable<Email>
{
    /// <summary>
    /// Gets the email address value.
    /// </summary>
    public string Value { get; private set; }

    /// <summary>
    /// Regex pattern for email validation.
    /// Validates standard email format including local part, @ symbol, and domain.
    /// </summary>
    private static readonly Regex EmailRegex = new(
        @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$",
        RegexOptions.Compiled | RegexOptions.IgnoreCase
    );

    /// <summary>
    /// Initializes a new instance of the Email class.
    /// </summary>
    /// <param name="value">The email address string.</param>
    /// <exception cref="DomainValidationException">Thrown when email format is invalid.</exception>
    public Email(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new DomainValidationException("Email cannot be null or empty.");
        }

        if (!EmailRegex.IsMatch(value))
        {
            throw new DomainValidationException("Email format is invalid.");
        }

        Value = value.Trim().ToLowerInvariant();
    }

    /// <summary>
    /// Private constructor for EF Core.
    /// </summary>
    private Email() { }

    /// <summary>
    /// Implicit conversion from string to Email.
    /// </summary>
    /// <param name="value">The email string value.</param>
    public static implicit operator Email(string value) => new(value);

    /// <summary>
    /// Implicit conversion from Email to string.
    /// </summary>
    /// <param name="email">The Email value object.</param>
    public static implicit operator string(Email email) => email.Value;

    /// <summary>
    /// Determines whether the specified Email is equal to the current Email.
    /// </summary>
    /// <param name="other">The Email to compare with the current Email.</param>
    /// <returns>True if the specified Email is equal to the current Email; otherwise, false.</returns>
    public bool Equals(Email? other)
    {
        if (other is null) return false;
        if (ReferenceEquals(this, other)) return true;
        return Value == other.Value;
    }

    /// <summary>
    /// Determines whether the specified object is equal to the current Email.
    /// </summary>
    /// <param name="obj">The object to compare with the current Email.</param>
    /// <returns>True if the specified object is equal to the current Email; otherwise, false.</returns>
    public override bool Equals(object? obj)
    {
        return Equals(obj as Email);
    }

    /// <summary>
    /// Serves as the default hash function.
    /// </summary>
    /// <returns>A hash code for the current Email.</returns>
    public override int GetHashCode()
    {
        return Value.GetHashCode();
    }

    /// <summary>
    /// Returns a string that represents the current Email.
    /// </summary>
    /// <returns>A string that represents the current Email.</returns>
    public override string ToString()
    {
        return Value;
    }

    /// <summary>
    /// Equality operator for Email objects.
    /// </summary>
    /// <param name="left">The left Email operand.</param>
    /// <param name="right">The right Email operand.</param>
    /// <returns>True if the Email objects are equal; otherwise, false.</returns>
    public static bool operator ==(Email? left, Email? right)
    {
        return EqualityComparer<Email>.Default.Equals(left, right);
    }

    /// <summary>
    /// Inequality operator for Email objects.
    /// </summary>
    /// <param name="left">The left Email operand.</param>
    /// <param name="right">The right Email operand.</param>
    /// <returns>True if the Email objects are not equal; otherwise, false.</returns>
    public static bool operator !=(Email? left, Email? right)
    {
        return !(left == right);
    }
} 