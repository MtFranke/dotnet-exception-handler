using deh.api.Exceptions.Base;

namespace deh.api.Exceptions;

public class UserAlreadyExistException : DomainException
{
    private string Pesel { get; }

    public UserAlreadyExistException(string pesel) : base($"User with PESEL {pesel} already exists.")
    {
        Pesel = pesel;
    }
}