using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SiriBiz.LineHook.Models
{
    public class LineBotAutorization : AuthorizationHandler<LineBotAutorization>, IAuthorizationRequirement
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, LineBotAutorization requirement)
        {
            if (context.Resource is AuthorizationFilterContext authorizationFilterContext)
            {
                var authorization = context.Resource as AuthorizationFilterContext;
                const string AUTHKEY = "authorization";
                var headers = authorization.HttpContext.Request.Headers;
                if (headers.ContainsKey(AUTHKEY))
                {
                    if (!CheckToken(headers[AUTHKEY]))
                        context.Fail();
                }
                else
                    context.Fail();
            }

            return Task.CompletedTask;
        }

        private bool CheckToken(string token)
        {
            return false;
        }
    }
}

