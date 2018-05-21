using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ServiceStack.Hello.Startup))]
namespace ServiceStack.Hello
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
