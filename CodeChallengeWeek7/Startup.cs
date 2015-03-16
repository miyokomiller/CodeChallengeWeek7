using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CodeChallengeWeek7.Startup))]
namespace CodeChallengeWeek7
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
