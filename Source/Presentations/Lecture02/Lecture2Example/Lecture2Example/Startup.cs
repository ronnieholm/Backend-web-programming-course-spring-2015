using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lecture2Example.Startup))]
namespace Lecture2Example
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
