using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MasonDatabase.Startup))]
namespace MasonDatabase
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
