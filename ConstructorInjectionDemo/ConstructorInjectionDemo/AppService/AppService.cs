using ConstructorInjectionDemo.LoggerService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorInjectionDemo.AppService
{
    public class AppService
    {
        private readonly ILogger _logger;

        // Constructor Injection
        public AppService(ILogger logger)
        {
            _logger = logger;
        }

        public void Run()
        {
            _logger.Log("AppService is running!");
        }
    }
}
