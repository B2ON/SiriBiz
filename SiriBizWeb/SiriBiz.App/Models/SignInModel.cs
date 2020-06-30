using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiriBiz.App.Models
{
    public class SignInModel
    {
        public string email { get; set; }
        public string password { get; set; }
        public bool keep_signin { get; set; } = false;
    }
}
