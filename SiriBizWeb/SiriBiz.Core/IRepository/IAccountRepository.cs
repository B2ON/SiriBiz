using SiriBiz.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiriBiz.Core.IRepository
{
    public interface IAccountRepository
    {
        bool CheckAccountExists(string username, string password);
        Account GetUserInfo(string username = "", string email = "");
    }
}
