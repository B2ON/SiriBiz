using Microsoft.AspNetCore.Mvc;
using SiriBiz.Core.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiriBiz.App.Components
{
    public class BlogMenuViewComponent : ViewComponent
    {
        private IApplicationRepository _repository;
        public BlogMenuViewComponent(IApplicationRepository repository)
        {
            _repository = repository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(_repository.ListBlogTopRankMenuItem());
        }
    }
}
