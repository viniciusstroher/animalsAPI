using System.Web.Optimization;

namespace AnimaisAPI
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Clear();
            bundles.ResetAll();

            ScriptBundle loginBundle = new ScriptBundle("~/js/login");
            loginBundle.Include("~/Content/js/lib/jquery-1.8.0.min.js");
            loginBundle.Include("~/Views/Documentation/Login.js");

            bundles.Add(loginBundle);

            ScriptBundle sandboxBundle = new ScriptBundle("~/js/sandbox");
            sandboxBundle.Include("~/Content/js/lib/jquery-1.8.0.min.js");
            sandboxBundle.Include("~/Content/js/lib/jquery.slideto.min.js");
            sandboxBundle.Include("~/Content/js/lib/jquery.wiggle.min.js");
            sandboxBundle.Include("~/Content/js/lib/jquery.ba-bbq.min.js");
            sandboxBundle.Include("~/Content/js/lib/handlebars-2.0.0.js");
            sandboxBundle.Include("~/Content/js/lib/underscore-min.js");
            sandboxBundle.Include("~/Content/js/lib/backbone-min.js");
            sandboxBundle.Include("~/Content/js/swagger-ui.js");
            sandboxBundle.Include("~/Content/js/lib/highlight.7.3.pack.js");
            sandboxBundle.Include("~/Content/js/lib/marked.js");
            sandboxBundle.Include("~/Content/js/lib/swagger-oauth.js");
            sandboxBundle.Include("~/Views/Documentation/Sandbox.js");

            bundles.Add(sandboxBundle);

            bundles.Add(new StyleBundle("~/css/login").Include("~/Content/css/login.css"));

            bundles.Add(new StyleBundle("~/css/sandbox").Include("~/Content/css/reset.css",
                                                                       "~/content/css/typography.css",
                                                                       "~/content/css/screen.css"));
        }
    }
}
