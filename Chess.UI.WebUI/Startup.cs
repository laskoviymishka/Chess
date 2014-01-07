using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Chess.UI.WebUI.Startup))]
namespace Chess.UI.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
