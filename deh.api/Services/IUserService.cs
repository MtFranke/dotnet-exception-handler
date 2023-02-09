using deh.api.Requests;
using deh.api.Responses;

namespace deh.api.Services;

public interface IUserService
{
    public Task AddAsync(UserRequest userRequest);
    public Task<UserResponse> GetAsync(string Pesel);
}