using deh.api.DTO;

namespace deh.api.Services;

public interface IUserService
{
    public Task Add(UserRequest userRequest);
}