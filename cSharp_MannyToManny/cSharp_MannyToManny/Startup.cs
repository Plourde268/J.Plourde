using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(cSharp_MannyToManny.Startup))]
namespace cSharp_MannyToManny
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
