﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiriBiz.Core.Models
{
    public class Account
    {
        public eAccountRole Role { get; set; }
        public string Profile { get; set; }
        public string LoginType { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public bool IsShowEmail { get; set; }
    }
}
