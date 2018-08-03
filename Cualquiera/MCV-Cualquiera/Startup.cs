using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MCV_Cualquiera.Startup))]
namespace MCV_Cualquiera
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
