using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using SiriBiz.Core.IRepository;
using SiriBiz.Core.Models;
using SiriBiz.Core.Repository;

namespace SiriBiz.WebApp.Pages
{
    public class SignInModel : PageModel
    {
        private readonly IAccountRepository _repository;
        public SignInModel(IAccountRepository repository)
        {
            _repository = repository;
        }

        [BindProperty]
        public string email { get; set; }

        [BindProperty]
        public string password { get; set; }


        [BindProperty]
        public bool keep_signin { get; set; } = false;

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (User.Identity.IsAuthenticated)
                return RedirectToPage("./Index");

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
                        new Claim(ClaimTypes.Role,$"{(int)user.Role}"),
                    };

                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    var authProperties = new AuthenticationProperties
                    {
                    };

                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProperties);
                    return RedirectToPage("./Index");
                }
            }

            return Page();

        }

        public async Task<IActionResult> OnPostConfirmationAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            //// Get the information about the user from the external login provider
            //var info = await _signInManager.GetExternalLoginInfoAsync();

            //if (info == null)
            //{
            //    ErrorMessage =
            //        "Error loading external login information during confirmation.";

            //    return RedirectToPage("./Login", new { ReturnUrl = returnUrl });
            //}

            //if (ModelState.IsValid)
            //{
            //    var user = new IdentityUser
            //    {
            //        UserName = Input.Email,
            //        Email = Input.Email
            //    };

            //    var result = await _userManager.CreateAsync(user);

            //    if (result.Succeeded)
            //    {
            //        result = await _userManager.AddLoginAsync(user, info);

            //        if (result.Succeeded)
            //        {
            //            // If they exist, add claims to the user for:
            //            //    Given (first) name
            //            //    Locale
            //            //    Picture
            //            if (info.Principal.HasClaim(c => c.Type == ClaimTypes.GivenName))
            //            {
            //                await _userManager.AddClaimAsync(user,
            //                    info.Principal.FindFirst(ClaimTypes.GivenName));
            //            }

            //            if (info.Principal.HasClaim(c => c.Type == "urn:google:locale"))
            //            {
            //                await _userManager.AddClaimAsync(user,
            //                    info.Principal.FindFirst("urn:google:locale"));
            //            }

            //            if (info.Principal.HasClaim(c => c.Type == "urn:google:picture"))
            //            {
            //                await _userManager.AddClaimAsync(user,
            //                    info.Principal.FindFirst("urn:google:picture"));
            //            }

            //            // Include the access token in the properties
            //            var props = new AuthenticationProperties();
            //            props.StoreTokens(info.AuthenticationTokens);
            //            props.IsPersistent = true;

            //            await _signInManager.SignInAsync(user, props);

            //            _logger.LogInformation(
            //                "User created an account using {Name} provider.",
            //                info.LoginProvider);

            //            return LocalRedirect(returnUrl);
            //        }
            //    }

            //    foreach (var error in result.Errors)
            //    {
            //        ModelState.AddModelError(string.Empty, error.Description);
            //    }
            //}

            //LoginProvider = info.LoginProvider;
            //ReturnUrl = returnUrl;
            return Page();
        }
    }
}