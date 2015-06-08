using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MessagingBoard.Startup))]
namespace MessagingBoard
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
