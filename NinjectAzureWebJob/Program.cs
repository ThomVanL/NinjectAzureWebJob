using Microsoft.Azure.WebJobs;
using Ninject;
using NinjectAzureWebJob.Activators;
using NinjectAzureWebJob.Modules;

namespace NinjectAzureWebJob
{
    // To learn more about Microsoft Azure WebJobs SDK, please see http://go.microsoft.com/fwlink/?LinkID=320976
    public class Program
    {
        static void Main()
        {
            var kernel = CreateKernel();
            var hostConfig = new JobHostConfiguration
            {
                JobActivator = new NinjectActivator(kernel)
            };
            var host = new JobHost(hostConfig);
            host.Call(typeof(Functions).GetMethod("DoWork"));
        }

        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel(new WebJobModule());
            return kernel;
        }
    }
}
