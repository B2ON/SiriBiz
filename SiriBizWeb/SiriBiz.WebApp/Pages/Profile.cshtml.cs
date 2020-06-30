using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SiriBiz.Core.IRepository;
using SiriBiz.Core.Models;

namespace SiriBiz.WebApp.Pages
{
    [Authorize]
    public class ProfileModel : PageModel
    {
        private readonly IAccountRepository _repository;
        public ProfileModel(IAccountRepository repository)
        {
            _repository = repository;
        }

        public Account Account { get; set; }
        public void OnGet()
        {
            this.Account = _repository.GetUserInfo(email: User.Identity.Name);
        }
    }
}