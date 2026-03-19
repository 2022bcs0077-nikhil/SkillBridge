using SkillBridge.DTOs.Auth;

namespace SkillBridge.Services.Auth
{
    public interface IAuthService
    {
        Task<string> RegisterAsync(RegisterDto dto);

        Task<string> LoginAsync(LoginDto dto);
    }
}
