
// Registger assembly
using FunctionApp3;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

[assembly: WebJobsStartup(typeof(StartUp))]
namespace FunctionApp3
{
    // Implement IWebJobStartup interface.
    public class StartUp : IWebJobsStartup
    {
        public void Configure(IWebJobsBuilder builder)
        {
            var serviceProvider = builder.Services.BuildServiceProvider();
            var loggerFactory = serviceProvider.GetService<ILoggerFactory>();
            var logger = serviceProvider.GetService<ILogger<StartUp>>();

            logger.LogInformation("Configuring function.");
        }
    }
}
