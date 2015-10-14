using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Week5.Startup))]
namespace Week5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
