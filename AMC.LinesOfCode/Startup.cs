using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AMC.LinesOfCode.Startup))]
namespace AMC.LinesOfCode
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
