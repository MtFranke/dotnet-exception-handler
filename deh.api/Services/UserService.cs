using deh.api.DTO;
using deh.api.Exceptions;

namespace deh.api.Services;

public class UserService : IUserService
{
    private readonly List<UserRequest> _users;

    public UserService()
    {
        _users = new List<UserRequest>();
    }

    public async Task Add(UserRequest userRequest)
    {
        if (_users.Exists(x => x.PESEL == userRequest.PESEL))
            throw new UserAlreadyExistException(userRequest.PESEL);

        _users.Add(userRequest);

    }
}