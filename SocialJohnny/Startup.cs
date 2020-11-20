using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SocialJohnny.Startup))]
namespace SocialJohnny
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
