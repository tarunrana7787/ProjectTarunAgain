using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

//required for OWIN startup
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security.Cookies;

[assembly: OwinStartup(typeof(ProjectTarunAgain.Startup))]

namespace ProjectTarunAgain
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //Instruct the application that where to go when it starts up for the authentication

            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Login.aspx")
            });
        }
    }
}
