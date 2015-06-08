[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(MessagingBoard.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(MessagingBoard.App_Start.NinjectWebCommon), "Stop")]

namespace MessagingBoard.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using MessagingBoard.Services;
    using MessagingBoard.Data;
    using System.Web.Http;
    using WebApiContrib.IoC.Ninject;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);

                GlobalConfiguration.Configuration.DependencyResolver = 
                    new NinjectResolver(kernel);

                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
#if DEBUG
            //within an individual request, everyone that asks for a web service gets the same instance of that web service(InRequestScope)
            kernel.Bind<IMailService>().To<MockMailService>().InRequestScope();
#else
            kernel.Bind<IMailService>().To<MailService>().InRequestScope();
#endif
            kernel.Bind<MessagingBoardContext>().To<MessagingBoardContext>().InRequestScope();
            kernel.Bind<IMessagingBoardRepository>().To<MessagingBoardRepository>().InRequestScope();
        }        
    }
}
