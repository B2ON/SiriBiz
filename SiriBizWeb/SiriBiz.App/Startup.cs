using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Facebook;
using Microsoft.AspNetCore.Authentication.OAuth;
using Microsoft.AspNetCore.Authentication.Twitter;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SiriBiz.Core.IRepository;
using SiriBiz.Core.Models;
using SiriBiz.Core.Repository;

namespace SiriBiz.App
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddScoped<IAccountRepository, AccountRepository>();
            services.AddScoped<IApplicationRepository, ApplicationRepository>();

            // Identity Config
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            })
            .AddFacebook(options =>
             {
                 options.AppId = Configuration["Authentication:Facebook:AppId"];
                 options.AppSecret = Configuration["Authentication:Facebook:AppSecret"];
                 options.Events.OnCreatingTicket = ticket => ExternalLoginCallBack<OAuthCreatingTicketContext, OAuthOptions>(ticket);
             })
            .AddGoogle(options =>
            {
                options.ClientId = Configuration["Authentication:Google:ClientId"];
                options.ClientSecret = Configuration["Authentication:Google:ClientSecret"];
                options.Events.OnCreatingTicket = ticket => ExternalLoginCallBack<OAuthCreatingTicketContext, OAuthOptions>(ticket);
            })
            .AddTwitter(options =>
            {
                options.ConsumerKey = Configuration["Authentication:Twitter:ConsumerKey"];
                options.ConsumerSecret = Configuration["Authentication:Twitter:ConsumerSecret"];
                options.Events.OnCreatingTicket = ticket => ExternalLoginCallBack<TwitterCreatingTicketContext, TwitterOptions>(ticket);
            })
            .AddMicrosoftAccount(options =>
            {
                options.ClientId = Configuration["Authentication:MicrosoftAccount:ClientId"];
                options.ClientSecret = Configuration["Authentication:MicrosoftAccount:ClientSecret"];
                options.Events.OnCreatingTicket = ticket => ExternalLoginCallBack<OAuthCreatingTicketContext, OAuthOptions>(ticket);
            })
             .AddCookie(cfg =>
             {
                 cfg.LoginPath = "/SignIn";
             });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            // Identity Config
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(name: "blog",
                    pattern: "Blog/{*article}",
                    defaults: new { controller = "Blog", action = "Blog" });
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }

        private Task ExternalLoginCallBack<TContext, TOptions>(TContext context) where TContext : ResultContext<TOptions> where TOptions : RemoteAuthenticationOptions
        {
            if (context.Principal.Identity.IsAuthenticated)
            {
                var repository = context.HttpContext.RequestServices.GetService<IAccountRepository>();
                var identity = ((ClaimsIdentity)context.Principal.Identity);
                var email_address = identity.FindFirst(ClaimTypes.Email)?.Value;
                var user_info = repository.GetUserInfo(email: email_address);
                foreach (var role in user_info?.Roles)
                {
                    identity.AddClaim(new Claim(ClaimTypes.Role, role.ToString()));
                }
            }
            return Task.CompletedTask;
        }
    }
}
