using System.Web;
using System.Web.Optimization;

namespace Aviv
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

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/Admin").Include(
                      "~/Content/css/lib/bootstrap/bootstrap.min.css",
                      "~/Content/css/lib/calendar2/semantic.ui.min.css",
                      "~/Content/css/lib/calendar2/pignose.calendar.min.css",
                      "~/Content/css/lib/owl.carousel.min.css",
                      "~/Content/css/lib/owl.theme.default.min.css",
                      "~/Content/css/helper.css",
                      "~/Content/css/style.css"));

            bundles.Add(new ScriptBundle("~/bundles/Admin").Include(
                      "~/Scripts/js/lib/jquery/jquery.min.js",
                      "~/Scripts/js/lib/bootstrap/js/popper.min.js",
                      "~/Scripts/js/lib/bootstrap/js/bootstrap.min.js",
                      "~/Scripts/js/jquery.slimscroll.js",
                      "~/Scripts/js/sidebarmenu.js",
                      "~/Scripts/js/lib/sticky-kit-master/dist/sticky-kit.min.js",
                      "~/Scripts/js/lib/morris-chart/raphael-min.js",
                      "~/Scripts/js/lib/morris-chart/morris.js",
                      "~/Scripts/js/lib/morris-chart/dashnoard1-init.js",
                      "~/Scripts/js/lib/calendar-2/moment.latest.min.js",
                      "~/Scripts/js/lib/calendar-2/semantic.ui.min.js",
                      "~/Scripts/js/lib/calendar-2/prism.min.js",
                      "~/Scripts/js/lib/calendar-2/pignose.calendar.min.js",
                      "~/Scripts/js/lib/calendar-2/pignose.init.js",
                      "~/Scripts/js/lib/owl-carousel/owl.carousel.min.js",
                      "~/Scripts/js/lib/owl-carousel/owl.carousel-init.js",
                      "~/Scripts/js/scripts.js",
                      "~/Scripts/js/custom.min.js"));

            bundles.Add(new StyleBundle("~/Content/Login").Include(
                "~/Content/css/lib/bootstrap/bootstrap.min.css",
                "~/Content/css/helper.css",
                "~/Content/css/style.css"
                ));

            bundles.Add(new ScriptBundle("~/bundles/Login").Include(
                "~/Scripts/js/lib/jquery/jquery.min.js",
                "~/Scripts/js/lib/bootstrap/js/popper.min.js",
                "~/Scripts/js/lib/bootstrap/js/bootstrap.min.js",
                "~/Scripts/js/jquery.slimscroll.js",
                "~/Scripts/js/sidebarmenu.js",
                "~/Scripts/js/lib/sticky-kit-master/dist/sticky-kit.min.js",
                "~/Scripts/js/custom.min.js"
                ));

        }
    }
}
