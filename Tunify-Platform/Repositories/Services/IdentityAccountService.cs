using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Tunify_Platform.Models;
using Tunify_Platform.Models.DTO;
using Tunify_Platform.Repositories.Interfaces;

namespace Tunify_Platform.Repositories.Services
{
    public class IdentityAccountService : IAccount
    {
        private readonly UserManager<Account> _userManager;
        private readonly SignInManager<Account> _signInManager;
        //private readonly IHttpContextAccessor _httpContextAccessor;

        public IdentityAccountService(UserManager<Account> context, SignInManager<Account> signInManager)
        {
            _userManager = context;
            _signInManager = signInManager;
        }

        public async Task<AccountDTO> Register(RegisterDTO registerDTO)
        {
            var account = new Account()
            {
                UserName = registerDTO.Username,
                Email = registerDTO.Email
            };
            var resultWithPass = await _userManager.CreateAsync(account, registerDTO.Password);

            // The return type is AccountDTO, so we create an instanse to get the info
            var accDto = new AccountDTO()
            {
                Id = account.Id,
                Username = account.UserName
            };

            return accDto;
        }

        public async Task<AccountDTO> Login(string username, string password)
        {
            var usernameAccount = await _userManager.FindByNameAsync(username);
            bool passValidation = await _userManager.CheckPasswordAsync(usernameAccount, password);

            var result = new AccountDTO()
            {
                Id = usernameAccount.Id,
                Username = usernameAccount.UserName
            };

            return result;
        }

        public async Task<AccountDTO> Logout(string username)
        {
            var logoutAccount = await _userManager.FindByNameAsync(username);
            if (logoutAccount == null)
            {
                // Handle user not found case
                return null;
            }

            // Clear the authentication cookie or token here
            await _signInManager.SignOutAsync();

            var result = new AccountDTO()
            {
                Id = logoutAccount.Id,
                Username = logoutAccount.UserName
            };

            return result;
        }
    }
}