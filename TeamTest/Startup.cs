using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TeamTest.Startup))]
namespace TeamTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
