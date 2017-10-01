using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vidley.Startup))]
namespace Vidley
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
