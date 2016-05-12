using System;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Ninject;
using NinjectAzureWebJob.Loggers;

namespace NinjectAzureWebJob
{
    public class Functions
    {
        [Inject]
        public ILogger Logger { get; set; }

        [NoAutomaticTrigger]
        public async Task DoWork()
        {
            Console.WriteLine(await Logger.Log());
        }
    }
}
