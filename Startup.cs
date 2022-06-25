namespace Dashboard
{
    public class Startup
    {
        public List<string> Tokens {get; set;} = new List<string>();
        public void ConfigureServices(IServiceCollection services) 
        {
            services.AddResponseCompression(options => 
            {
                options.EnableForHttps = true;
            });

        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseResponseCompression()
               .UseDefaultFiles()
               .UseStaticFiles()
               .UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    context.Response.Headers.Add("Content-Type", "text/html");
                    await context.Response.WriteAsync(System.IO.File.ReadAllText(@"./wwwroot/index.html"));
                });

                endpoints.MapGet("/{**any}", async context =>
                {
                    context.Response.Headers.Add("Content-Type", "text/html");
                    await context.Response.WriteAsync(System.IO.File.ReadAllText(@"./wwwroot/index.html"));
                });
            });
        }
    }
}
