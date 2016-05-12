using Ninject.Modules;
using NinjectAzureWebJob.Loggers;

namespace NinjectAzureWebJob.Modules
{
    public class WebJobModule : NinjectModule
    {
        public override void Load()
        {
            Kernel.Bind<ILogger>().To<SimpleLogger>();
            //Kernel.Bind<ILogger>().To<AdvancedLogger>();
        }     
    }
}