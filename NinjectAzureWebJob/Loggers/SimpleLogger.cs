using System.Threading.Tasks;

namespace NinjectAzureWebJob.Loggers
{
    public class SimpleLogger : ILogger
    {
        public async Task<string> Log()
        {
            await Task.Delay(1000);
            return "Simple done.";
        }
    }
}