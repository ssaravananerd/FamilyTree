using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FamilyTree.Web.Startup))]
namespace FamilyTree.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
