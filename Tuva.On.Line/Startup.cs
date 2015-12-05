using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tuva.On.Line.Startup))]
namespace Tuva.On.Line
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
