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
    public class ApplicationRepository : IApplicationRepository
    {
        private readonly ILogger<ApplicationRepository> _logger;
        public ApplicationRepository(ILogger<ApplicationRepository> logger)
        {
            _logger = logger;
        }

        public List<MenuItem> ListBlogTopRankMenuItem(int size = 10)
        {
            var top_ranks = new List<MenuItem>();

            //News
            top_ranks.Add(new MenuItem { Group = "Hot News", Title = "ข่าวครูบลู", Type = eMenuType.Link, Url = "/Blog/ข่าวครูบลู" });
            top_ranks.Add(new MenuItem { Group = "Hot News", Title = "ข่าวต่างประเทศ", Type = eMenuType.Link, Url = "/Blog/ข่าวต่างประเทศ" });
            top_ranks.Add(new MenuItem { Group = "Hot News", Title = "ข่าวโควิค", Type = eMenuType.Link, Url = "/Blog/ข่าวโควิค" });
            top_ranks.Add(new MenuItem { Group = "Hot News", Title = "ข่าวเตี้ยมช", Type = eMenuType.Link, Url = "/Blog/ข่าวเตี้ยมช" });
            top_ranks.Add(new MenuItem { Group = "Hot News", Title = "ข่าวราหู", Type = eMenuType.Link, Url = "/Blog/ข่าวราหู" });

            //Life Styles
            top_ranks.Add(new MenuItem { Group = "Top Asia Tends", Title = "ออกกำลังกาย", Type = eMenuType.Link, Url = "/Blog/ออกกำลังกาย" });
            top_ranks.Add(new MenuItem { Group = "Top Asia Tends", Title = "สุขภาพประจำวัน", Type = eMenuType.Link, Url = "/Blog/สุขภาพประจำวัน" });
            top_ranks.Add(new MenuItem { Group = "Top Asia Tends", Title = "สาธารณสุข", Type = eMenuType.Link, Url = "/Blog/สาธารณสุข" });
            top_ranks.Add(new MenuItem { Group = "Top Asia Tends", Title = "ออกแบบคอนโด", Type = eMenuType.Link, Url = "./Blog/ออกแบบคอนโด" });
            top_ranks.Add(new MenuItem { Group = "Top Asia Tends", Title = "ปลูกต้นไม้รอบบ้าน", Type = eMenuType.Link, Url = "./Blog/ปลูกต้นไม้รอบบ้าน" });

            //Knowledge
            top_ranks.Add(new MenuItem { Group = "Twitter Hastag", Title = "#ภาษี59", Type = eMenuType.Link, Url = "/Blog/%23ภาษี59" });
            top_ranks.Add(new MenuItem { Group = "Twitter Hastag", Title = "#หัวฟู", Type = eMenuType.Link, Url = "/Blog/%23หัวฟู" });
            top_ranks.Add(new MenuItem { Group = "Twitter Hastag", Title = "#ลิซ่า", Type = eMenuType.Link, Url = "/Blog/%23ลิซ่า" });
            top_ranks.Add(new MenuItem { Group = "Twitter Hastag", Title = "#มาดามขอนแก่น", Type = eMenuType.Link, Url = "/Blog/%23มาดามขอนแก่น" });
            top_ranks.Add(new MenuItem { Group = "Twitter Hastag", Title = "#หอมชื่น", Type = eMenuType.Link, Url = "/Blog/%23หอมชื่น" });

            return top_ranks;
        }
    }
}
