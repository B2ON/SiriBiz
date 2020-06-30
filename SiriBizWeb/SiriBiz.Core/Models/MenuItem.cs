using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiriBiz.Core.Models
{
    public class MenuItem
    {
        public List<MenuItem> SubMenu { get; set; }
        public eMenuType Type { get; set; }
        public string Group { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
    }
}
