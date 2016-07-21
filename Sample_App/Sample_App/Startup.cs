using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sample_App.Startup))]
namespace Sample_App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
