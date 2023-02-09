namespace deh.api.Exceptions.Base;

public abstract class NotFoundException : CustomException
{
    public NotFoundException()
    {
    }

    public NotFoundException(string? message) : base(message)
    {
    }
}