using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ScrumPlanningBot.Core.Services;

namespace ScrumPlanningBot.Application
{
    class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureLogging((hostContext, logging) =>
                {
                    logging.AddConfiguration(hostContext.Configuration.GetSection("Logging"));
                    logging.AddConsole();
                })
                .ConfigureAppConfiguration(x =>
                {
                    //x.AddUserSecrets<Program>();
                })
                .ConfigureServices((hostContext, services) =>
                {
                    // add services
                    services.AddSingleton<BookService>();
                    services.AddSingleton<UserService>();
                    services.AddSingleton<RoomService>();
                    services.AddSingleton<IChatService, TelegramService>();

                    services.AddLogging();
                    services.AddBotCommands();
                    services.AddHostedService<Bot>();
                });
    }
}
