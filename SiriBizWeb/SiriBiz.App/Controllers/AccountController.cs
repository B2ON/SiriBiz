using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SiriBiz.Core.IRepository;

namespace SiriBiz.App.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly ILogger<AccountController> _logger;
        private readonly IAccountRepository _repository;

        public AccountController(ILogger<AccountController> logger, IAccountRepository accountRepository)
        {
            _logger = logger;
            _repository = accountRepository;
        }

        [Route("Profile")]
        public IActionResult Profile()
        {
            var identity = User.Identity as ClaimsIdentity;
            var email_address = identity.FindFirst(ClaimTypes.Email)?.Value;
            var user_info = _repository.GetUserInfo(email: email_address);
            user_info.LoginType ??= identity.AuthenticationType;
            user_info.FirstName ??= identity.FindFirst(ClaimTypes.GivenName)?.Value;
            user_info.LastName ??= identity.FindFirst(ClaimTypes.Surname)?.Value;

            return View(user_info);
        }

        [HttpGet]
        [Route("SignIn")]
        [Route("Account/SignIn")]
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignIn(string email, string password, bool is_active = false)
        {
            if (User.Identity.IsAuthenticated)
                return RedirectToAction("Index", "Home");

            if (ModelState.IsValid)
            {
                if (_repository.CheckAccountExists(email, password))
                {
                    var user = _repository.GetUserInfo(email: email);
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.NameIdentifier, $"{user.Email}@{user.UserName}"),
                        new Claim(ClaimTypes.Email, user.Email),
                        new Claim(ClaimTypes.Name, user.UserName),
                    };

                    //add role permission
                    claims.AddRange(user.Roles.Select(role => new Claim(ClaimTypes.Role, role.ToString())));

                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    var authProperties = new AuthenticationProperties
                    {
                    };

                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProperties);

                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }

        [Route("SignIn/{provider}")]
        [Route("Account/SignIn/{provider}")]
        [AllowAnonymous]
        public IActionResult SignIn(string provider, string returnUrl = null)
        {
            return Challenge(new AuthenticationProperties { RedirectUri = returnUrl ?? "\\", }, provider);
        }

        [HttpPost]
        [Route("SignUp")]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignUp(string email, string password, bool is_active = false)
        {
            return await SignIn(email, password, is_active);
        }

        public IActionResult SignOut()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }
    }
}
