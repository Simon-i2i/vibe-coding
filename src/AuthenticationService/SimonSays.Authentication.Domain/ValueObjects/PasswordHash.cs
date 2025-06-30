using SimonSays.Authentication.Domain.Exceptions;

namespace SimonSays.Authentication.Domain.ValueObjects;

/// <summary>
/// Represents a hashed password value object.
/// Encapsulates the hashed password data and provides validation.
/// </summary>
public class PasswordHash : IEquatable<PasswordHash>
{
    /// <summary>
    /// Gets the hashed password value.
    /// </summary>
    public string Value { get; private set; }

    /// <summary>
    /// Initializes a new instance of the PasswordHash class.
    /// </summary>
    /// <param name="value">The hashed password string.</param>
    /// <exception cref="DomainValidationException">Thrown when the hashed password is invalid.</exception>
    public PasswordHash(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new DomainValidationException("Password hash cannot be null or empty.");
        }

        if (value.Length < 10)
        {
            throw new DomainValidationException("Password hash appears to be invalid (too short).");
        }

        Value = value;
    }

    /// <summary>
    /// Private constructor for EF Core.
    /// </summary>
    private PasswordHash() { }

    /// <summary>
    /// Implicit conversion from string to PasswordHash.
    /// </summary>
    /// <param name="value">The password hash string value.</param>
    public static implicit operator PasswordHash(string value) => new(value);

    /// <summary>
    /// Implicit conversion from PasswordHash to string.
    /// </summary>
    /// <param name="passwordHash">The PasswordHash value object.</param>
    public static implicit operator string(PasswordHash passwordHash) => passwordHash.Value;

    /// <summary>
    /// Determines whether the specified PasswordHash is equal to the current PasswordHash.
    /// </summary>
    /// <param name="other">The PasswordHash to compare with the current PasswordHash.</param>
    /// <returns>True if the specified PasswordHash is equal to the current PasswordHash; otherwise, false.</returns>
    public bool Equals(PasswordHash? other)
    {
        if (other is null) return false;
        if (ReferenceEquals(this, other)) return true;
        return Value == other.Value;
    }

    /// <summary>
    /// Determines whether the specified object is equal to the current PasswordHash.
    /// </summary>
    /// <param name="obj">The object to compare with the current PasswordHash.</param>
    /// <returns>True if the specified object is equal to the current PasswordHash; otherwise, false.</returns>
    public override bool Equals(object? obj)
    {
        return Equals(obj as PasswordHash);
    }

    /// <summary>
    /// Serves as the default hash function.
    /// </summary>
    /// <returns>A hash code for the current PasswordHash.</returns>
    public override int GetHashCode()
    {
        return Value.GetHashCode();
    }

    /// <summary>
    /// Returns a string that represents the current PasswordHash.
    /// </summary>
    /// <returns>A string that represents the current PasswordHash.</returns>
    public override string ToString()
    {
        return Value;
    }

    /// <summary>
    /// Equality operator for PasswordHash objects.
    /// </summary>
    /// <param name="left">The left PasswordHash operand.</param>
    /// <param name="right">The right PasswordHash operand.</param>
    /// <returns>True if the PasswordHash objects are equal; otherwise, false.</returns>
    public static bool operator ==(PasswordHash? left, PasswordHash? right)
    {
        return EqualityComparer<PasswordHash>.Default.Equals(left, right);
    }

    /// <summary>
    /// Inequality operator for PasswordHash objects.
    /// </summary>
    /// <param name="left">The left PasswordHash operand.</param>
    /// <param name="right">The right PasswordHash operand.</param>
    /// <returns>True if the PasswordHash objects are not equal; otherwise, false.</returns>
    public static bool operator !=(PasswordHash? left, PasswordHash? right)
    {
        return !(left == right);
    }
} 