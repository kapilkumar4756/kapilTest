using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Jason_CRUD.Startup))]
namespace Jason_CRUD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
