using Microsoft.Owin;
using Owin;
using MyWebApplication;

namespace MyWebApplication
{
    public class SignalrStartup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}