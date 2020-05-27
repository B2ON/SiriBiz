using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SiriBiz.LineHook.Models
{
    public class LineAuthorizationAttribute : TypeFilterAttribute
    {
        public LineAuthorizationAttribute() : base(typeof(LineAuthorizationFilter))
        {

        }
    }

    public class LineAuthorizationFilter : IAuthorizationFilter
    {
        // private readonly Claim _claim;
        private readonly LineBotSettings settings;
        public LineAuthorizationFilter(IOptions<LineBotSettings> options)
        {
            settings = options.Value;
            //_claim = new Claim(ClaimTypes.Authentication, "LineBot");
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (context.Filters.Any(item => item is IAllowAnonymousFilter)) return;

            const string AUTHKEY = "authorization";
            var headers = context.HttpContext.Request.Headers;
            if (headers.ContainsKey(AUTHKEY))
            {
                var chanel_token = $"Bearer {settings.ChannelAccessToken}";
                if (!chanel_token.Equals(headers[AUTHKEY]))
                    context.Result = new ForbidResult();
            }
            else
                context.Result = new ForbidResult();
        }

        private bool CheckToken(string token)
        {
            return $"Bearer {settings.ChannelAccessToken}".Equals(token);
        }
    }
}
