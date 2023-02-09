using deh.api.Exceptions.Base;

namespace deh.api.Exceptions;

public class UserNotFoundException : NotFoundException
{
    
    public UserNotFoundException(string pesel) : base($"User with pesel {pesel} was not found.")
    {
    }
}