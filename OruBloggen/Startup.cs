using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OruBloggen.Startup))]
namespace OruBloggen
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
