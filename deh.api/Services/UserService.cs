using deh.api.Exceptions;
using deh.api.Requests;

namespace deh.api.Services;

public class UserService : IUserService
{
    private readonly List<UserRequest> _users;

    public UserService()
    {
        //Dummy db mock
        _users = new List<UserRequest>();
    }

    public async Task AddAsync(UserRequest userRequest)
    {
        if (_users.Exists(x => x.PESEL == userRequest.PESEL))
            throw new UserAlreadyExistException(userRequest.PESEL);

        _users.Add(userRequest);
    }

    public async Task<UserRequest> GetAsync(string Pesel)
    {
        var user = _users.Find(x => x.PESEL == Pesel);
        if (user is null)
            throw new UserNotFoundException(Pesel);

        return user;
    }
}