using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HaftFasl.Startup))]
namespace HaftFasl
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
