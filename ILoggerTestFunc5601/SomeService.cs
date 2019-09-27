using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Logging;

namespace ILoggerTestFunc5601
{
    public class SomeService : ISomeService
    {
        private readonly ILogger _logger;
        public SomeService(ILogger<Function1> logger)
        {
            _logger = logger;
        }

        public void LogSomething()
        {
            _logger.LogInformation("Logging from inside class not instantiated in Function method.");
        }
    }
}
