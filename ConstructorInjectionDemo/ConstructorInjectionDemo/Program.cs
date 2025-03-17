
using ConstructorInjectionDemo.AppService;
using ConstructorInjectionDemo.LoggerService;
using Microsoft.Extensions.DependencyInjection;

class Program
{
    static void Main(string[] args)
    {
        // Set up Dependency Injection
        var serviceProvider = new ServiceCollection()
            .AddSingleton<ILogger, LoggerService>()  // Register LoggerService as ILogger
            .AddSingleton<AppService>()  // Register AppService
            .BuildServiceProvider();

        // Resolve dependencies and run
        var appService = serviceProvider.GetService<AppService>();
        appService?.Run();  // Calling the Run method which uses the injected ILogger
    }
}