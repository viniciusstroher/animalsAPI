using System;
using System.Web.Http;
using System.Web.Optimization;
using System.Web.Routing;

namespace AnimaisAPI
{
    /// <summary>
    /// </summary>
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            GlobalConfiguration.Configure(config =>
            {
                config.MapHttpAttributeRoutes();
                WebApiConfig.Register(config);
            });

            RouteConfig.RegisterRoutes(RouteTable.Routes);

            BundleTable.EnableOptimizations = true;
            BundleConfig.RegisterBundles(BundleTable.Bundles);

#if DEBUG
            SwaggerConfig.Register();
#endif
        }
    }
}
