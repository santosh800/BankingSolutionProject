using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BankingSolutionProject.Startup))]
namespace BankingSolutionProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
