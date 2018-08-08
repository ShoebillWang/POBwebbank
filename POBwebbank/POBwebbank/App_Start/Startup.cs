using Owin;
using Abp.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Owin;
using POBwebbank;

[assembly: OwinStartup(typeof(Startup))]

namespace POBwebbank {
   public class Startup
   {
      public void Configuration(IAppBuilder app) {

            app.UseAbp();

         //app.UseOAuthBearerAuthentication(AccountController.OAuthBearerOptions);

         //app.UseCookieAuthentication(new CookieAuthenticationOptions {
         //   AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
         //   LoginPath = new PathString("/Account/Login"),
         //   // by setting following values, the auth cookie will expire after the configured amount of time (default 14 days) when user set the (IsPermanent == true) on the login
         //   ExpireTimeSpan = new TimeSpan(int.Parse(ConfigurationManager.AppSettings["AuthSession.ExpireTimeInDays.WhenPersistent"] ?? "14"), 0, 0, 0),
         //   SlidingExpiration = bool.Parse(ConfigurationManager.AppSettings["AuthSession.SlidingExpirationEnabled"] ?? bool.FalseString)

         //});

         //app.UseExternalSignInCookie(DefaultAuthenticationTypes.ExternalCookie);

         app.MapSignalR();
         

         //ENABLE TO USE HANGFIRE dashboard (Requires enabling Hangfire in MVCABPWebModule)
         //app.UseHangfireDashboard("/hangfire", new DashboardOptions
         //{
         //    Authorization = new[] { new AbpHangfireAuthorizationFilter() } //You can remove this line to disable authorization
         //});
      }
   }
}