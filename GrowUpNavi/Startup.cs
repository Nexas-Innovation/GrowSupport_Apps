using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GrowUpNavi.Startup))]
namespace GrowUpNavi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
