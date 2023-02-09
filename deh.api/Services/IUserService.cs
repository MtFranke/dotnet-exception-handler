using deh.api.Requests;

namespace deh.api.Services;

public interface IUserService
{
    public Task AddAsync(UserRequest userRequest);
    public Task<UserRequest> GetAsync(string Pesel);
}