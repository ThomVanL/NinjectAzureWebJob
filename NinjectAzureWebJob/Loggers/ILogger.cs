using System.Threading.Tasks;

namespace NinjectAzureWebJob.Loggers
{
    public interface ILogger
    {
        Task<string> Log();
    }
}