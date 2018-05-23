using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShoppingCartApp.Startup))]
namespace ShoppingCartApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
