using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrackExpenses.Startup))]
namespace TrackExpenses
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
