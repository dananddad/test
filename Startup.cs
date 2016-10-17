using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace DanAndDad.Web
{
    public class Startup
    {
        public void ConfigureService(IServiceCollection services)
        {

        }

        public void Configure(IApplicationBuilder app)
        {
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World, from DanAndDad!");
            });
        }
    }

}