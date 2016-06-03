using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace corerc2firstapp
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.Run(async ctx=>
            {
               await ctx.Response.WriteAsync($"Hello from Rc2. Path : {ctx.Request.Path}");
               
                
            }
            );
            
        }
    }
}