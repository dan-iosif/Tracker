using System;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.Owin;
using Owin;
using Tracker.App_Start;

[assembly: OwinStartup(typeof(Tracker.Startup))]

namespace Tracker
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();
            OAuthConfig.ConfigureOAuth(app);
            UnityConfig.RegisterComponents(config);
            WebApiConfig.Register(config);
            app.UseWebApi(config);
        }
    }
}
