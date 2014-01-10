using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PlayVideo.Startup))]
namespace PlayVideo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
