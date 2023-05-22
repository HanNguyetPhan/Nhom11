using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlineToyStore.Startup))]
namespace OnlineToyStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
