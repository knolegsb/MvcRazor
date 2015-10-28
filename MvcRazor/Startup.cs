using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcRazor.Startup))]
namespace MvcRazor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
