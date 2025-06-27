namespace SimonSays.Authentication.Domain.Exceptions;

/// <summary>
/// Exception thrown when domain validation fails.
/// Represents business rule violations within the domain layer.
/// </summary>
public class DomainValidationException : Exception
{
    /// <summary>
    /// Initializes a new instance of the DomainValidationException class.
    /// </summary>
    public DomainValidationException() : base() { }

    /// <summary>
    /// Initializes a new instance of the DomainValidationException class with a specified error message.
    /// </summary>
    /// <param name="message">The message that describes the error.</param>
    public DomainValidationException(string message) : base(message) { }

    /// <summary>
    /// Initializes a new instance of the DomainValidationException class with a specified error message
    /// and a reference to the inner exception that is the cause of this exception.
    /// </summary>
    /// <param name="message">The error message that explains the reason for the exception.</param>
    /// <param name="innerException">The exception that is the cause of the current exception.</param>
    public DomainValidationException(string message, Exception innerException) 
        : base(message, innerException) { }
} 