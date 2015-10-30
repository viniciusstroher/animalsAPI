using System.Web.Http;
using AnimaisAPI.AppCode.WebApiFilters;

namespace AnimaisAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(name: "DefaultApi", routeTemplate: "api/{controller}/{id}", defaults: new { id = RouteParameter.Optional });
            config.Filters.Add(new AuthenticationFilterAttribute());

            //config.Routes.MapHttpRoute("Documentation", "");


            // If using dependency inject, this may be better to do.
            //config.Filters.Add((AuthenticationFilterAttribute)config.DependencyResolver.GetService(typeof(AuthenticationFilterAttribute)));
        }
    }
}
