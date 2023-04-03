using GoBizy.Application.Common.Models.Requests;
using GoBizy.Application.Common.Models.Responses;

namespace GoBizy.Application.Common.Interfaces;

public interface IAuthenticationService
{
    Task<LoginResponse> RegisterUserAndLoginAsync(RegisterUserRequest request);

    Task<LoginResponse> LoginUserAsync(LoginUserRequest request);

    Task<RefreshTokenResponse> RefreshTokenAsync(RefreshTokenRequest request);
}
