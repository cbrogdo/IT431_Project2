using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MasonDatabase_Project2.Startup))]
namespace MasonDatabase_Project2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
