using BeautyLingerie.Services.Token.Contracts;
using BeautyLingerie.ViewModels.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BeautyLingerie.WebApi.Controllers
{
    public class AuthContoller : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly ITokenService _tokenService;
        public AuthContoller(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, ITokenService tokenService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _tokenService = tokenService;
        }

        [HttpPost("/Register")]
        public async Task<IActionResult> Register([FromBody] RegisterViewModel model)
        {
            var user = new IdentityUser { UserName = model.Email, Email = model.Email };
            var result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                return Ok("User created");
            }

            return BadRequest(result.Errors);
        }

        [HttpPost("/Login")]
        public async Task<IActionResult> Login([FromBody] RegisterViewModel model)
        {
            var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, false, false);
            if (result.Succeeded)
            {
                var user = await _userManager.FindByEmailAsync(model.Email);
                var roles = await _userManager.GetRolesAsync(user);
                var isAdmin = roles.Contains("Administrator");

                var token = _tokenService.GenerateJwtToken(model.Email);
                return Ok(new
                {
                    Email = model.Email,
                    AccessToken = token,
                    IsAdmin = isAdmin
                });
            }

            return Unauthorized("Invalid login");
        }


    }

}
