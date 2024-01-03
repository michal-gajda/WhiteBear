namespace WhiteBear.Domain.Exceptions;

public sealed class IncorrectIsbnException : Exception
{
    public IncorrectIsbnException(string message) : base(message)
    {
    }
}
