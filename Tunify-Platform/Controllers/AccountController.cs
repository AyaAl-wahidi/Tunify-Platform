using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Tunify_Platform.Models.DTO;
using Tunify_Platform.Repositories.Interfaces;

namespace Tunify_Platform.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccount _context;

        public AccountController(IAccount context)
        {
            _context = context;
        }

        [HttpPost("Register")]
        public async Task<ActionResult<AccountDTO>> Register(RegisterDTO registerDTO)
        {
            var account = await _context.Register(registerDTO);
            return account;
        }

        [HttpPost("Login")]
        public async Task<ActionResult<AccountDTO>> Login(string username, string password)
        {
            var newLogin = await _context.Login(username, password);
            return newLogin;
        }

        [HttpPost("Logout")]
        public async Task<ActionResult<AccountDTO>> Logout(string username)
        {
            var newLogout = await _context.Logout(username);
            return newLogout;
        }
    }
}