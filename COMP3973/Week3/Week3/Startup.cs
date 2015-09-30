using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Week3.Startup))]
namespace Week3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
