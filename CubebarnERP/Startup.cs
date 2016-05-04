using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CubebarnERP.Startup))]
namespace CubebarnERP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
