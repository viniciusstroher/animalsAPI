using System.Web.Routing;

namespace AnimaisAPI
{
    /// <summary>
    /// </summary>
    public class RouteConfig
    {
        /// <summary>
        /// </summary>
        /// <param name="routes"></param>
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.Ignore("{resource}.axd/{*pathInfo}");

#if DEBUG // Mapeia as rotas customizadas para tela default.
            routes.MapPageRoute("Documentation_Login", "", "~/Views/Documentation/Login.html");
            routes.MapPageRoute("Documentation_Sandbox", "Sandbox/", "~/Views/Documentation/Sandbox.html");
#endif
        }
    }
}
