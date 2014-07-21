using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DiceRoll.Startup))]
namespace DiceRoll
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
