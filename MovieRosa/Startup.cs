using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MovieRosa.Startup))]
namespace MovieRosa
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
