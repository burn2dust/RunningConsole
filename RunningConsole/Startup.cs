using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RunningConsole.Startup))]
namespace RunningConsole
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
