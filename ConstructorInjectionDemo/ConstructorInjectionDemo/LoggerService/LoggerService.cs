namespace ConstructorInjectionDemo.LoggerService
{
    public class LoggerService : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Log:{message}");
        }

    }
}
