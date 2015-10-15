using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Week5Home.Startup))]
namespace Week5Home
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
