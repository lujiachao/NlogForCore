using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FL.BackgroundHost
{
    internal class TokenRefreshService : BackgroundService
    {
        private readonly ILogger _logger;

        public TokenRefreshService(ILogger<TokenRefreshService> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("Service starting");

            _logger.LogError("DASAD ");

            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogTrace(DateTime.Now.ToLongTimeString() + ": Trace ");
                _logger.LogDebug(DateTime.Now.ToLongTimeString() + ": Debug ");
                _logger.LogError(DateTime.Now.ToLongTimeString() + ": Error ");
                _logger.LogWarning(DateTime.Now.ToLongTimeString() + ": Warning ");
                _logger.LogCritical(DateTime.Now.ToLongTimeString() + ": Critical ");
                _logger.LogInformation(DateTime.Now.ToLongTimeString() + ": Information");
                await Task.Delay(15000, stoppingToken);
            }

            _logger.LogInformation("Service stopping");
        }
    }
}
