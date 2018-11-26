using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyMLWebsite.Startup))]
namespace MyMLWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
