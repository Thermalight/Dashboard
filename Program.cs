namespace Dashboard
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();


            CreateHostBuilder(args).Build().Run();
            }
        


        private static IHostBuilder CreateHostBuilder(string[] args) 
        {
            return Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder => webBuilder.UseStartup<Startup>());
        }
    }
}

       