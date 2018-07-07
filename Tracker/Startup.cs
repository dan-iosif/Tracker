using System;
using System.IO;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using Microsoft.Owin;
using Microsoft.Owin.FileSystems;
using Microsoft.Owin.StaticFiles;
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

            var fsOptions = new FileServerOptions
            {
                EnableDirectoryBrowsing = false,
                EnableDefaultFiles = true,
                FileSystem = new PhysicalFileSystem(Path.Combine(HttpRuntime.AppDomainAppPath, @"Client\dist"))
            };
            app.UseFileServer(fsOptions);


            app.UseWebApi(config);
        }
    }
}
