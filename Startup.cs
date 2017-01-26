using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_DB_lec.Startup))]
namespace MVC_DB_lec
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
