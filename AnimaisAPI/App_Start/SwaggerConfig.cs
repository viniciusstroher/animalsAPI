using System;
using System.IO;
using System.Web.Http;
using Swashbuckle.Application;

namespace AnimaisAPI
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration.EnableSwagger("api_docs/{apiVersion}/", c =>
            {
                c.SingleApiVersion("v1", "API de testes do sistema.");
                c.DescribeAllEnumsAsStrings();
                c.IncludeXmlComments(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bin", thisAssembly.GetName().Name + ".xml"));
            });
        }
    }
}
