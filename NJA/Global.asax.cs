using Ninject;
using Ninject.Web.Common;
using NJA.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace NJA
{

    //for git ---->
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication //NinjectHttpApplication//
    {
       /* protected override IKernel CreateKernel()
        {
            IKernel kernel = new StandardKernel();

            // kernel.Load(Assembly.GetExecutingAssembly());

            // kernel.Bind<ISomeClass>().To<SomeClass>();

            return kernel;
        }
        * */
        protected void Application_Start()
    //protected override void OnApplicationStarted()
       {
            AreaRegistration.RegisterAllAreas();
            DependencyResolver.SetResolver(new NinjectDependencyResolver());
            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterAuth();
           // ControllerBuilder.Current.SetControllerFactory(new NinjectControllerFactory(CreateKernel()));
        }
    }
}
