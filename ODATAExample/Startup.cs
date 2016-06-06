using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ODATAExample.Startup))]
namespace ODATAExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
