using SiriBiz.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiriBiz.Core.IRepository
{
    public interface IApplicationRepository
    {
        List<MenuItem> ListBlogTopRankMenuItem(int size = 10);
    }
}
