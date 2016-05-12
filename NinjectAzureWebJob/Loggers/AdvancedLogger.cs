using System.Threading.Tasks;

namespace NinjectAzureWebJob.Loggers
{
    public class AdvancedLogger : ILogger
    {
        public async Task<string> Log()
        {
            await Task.Delay(2000);
            return "Advanced done.";
        }
    }
}