using Tunify_Platform.Models.DTO;

namespace Tunify_Platform.Repositories.Interfaces
{
    public interface IAccount
    {
        public Task<AccountDTO> Register(RegisterDTO registerDTO);

        public Task<AccountDTO> Login(string username, string password);
        public Task<AccountDTO> Logout(string username);
    }
}