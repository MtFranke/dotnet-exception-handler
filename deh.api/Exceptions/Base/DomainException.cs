namespace deh.api.Exceptions.Base;

public abstract class DomainException : CustomException
{
    public DomainException()
    {
    }

    public DomainException(string? message) : base(message)
    {
    }
}