using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SiriBiz.Core.IRepository;
using SiriBiz.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace SiriBiz.Core.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly ILogger<AccountRepository> _logger;
        public AccountRepository(ILogger<AccountRepository> logger)
        {
            _logger = logger;
        }

        public bool CheckAccountExists(string username, string password)
        {
            var user = new { user = username, Id = username };

            // return null if user not found
            if (user == null) return false;

            return true;
        }

        public Account GetUserInfo(string username = "", string email = "")
        {
            return new Account
            {
                Address = "199/330",
                City = "Bangkok",
                Country = "Thailand",
                Email = email,
                //FirstName = "Boontham",
                //LastName = "Homchuen",
                Profile = "",
                UserName = email.Split('@').FirstOrDefault(),
                ZipCode = "",
                IsShowEmail = true,
                Role = eAccountRole.Member
            };
        }
    }
}
