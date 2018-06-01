using System.Web;
using System.Web.Optimization;

namespace Dream_Getaway
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/script").Include(
                      "~/assets/js/jquery.min.js",
                      "~/assets/js/bootstrap.min.js",
                      "~/assets/js/owl.carousel.min.js",
                      "~/assets/js/magnific-popup-1.1.0.js",
                      "~/assets/js/jquery.nice-select.min.js",
                      "~/assets/js/jquery.waypoints.4.0.0.min.js",
                      "~/assets/js/jquery.counterup.min.js",
                      "~/assets/js/jquery.slicknav.min.js",
                      "~/assets/js/main.js"
                      ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/assets/css/bootstrap.min.css",
                      "~/assets/css/font-awesome.min.css",
                      "~/assets/css/material-design-iconic-font.min.css",
                      "~/assets/css/owl.carousel.min.css",
                      "~/assets/css/magnific-popup.css",
                      "~/assets/css/nice-select.css",
                      "~/assets/css/slicknav.min.css",
                      "~/assets/css/style.css",
                      "~/assets/css/responsive.css"
                      ));
        }
    }
}
