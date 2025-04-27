using System.Web;
using System.Web.Optimization;

namespace MvcPROJEKampp
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                      "~/Scripts/roles/jquery-3.6.0.min.js")); // Burada kendi jquery dosya adını kullan

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                     "~/Scripts/roles/jquery.validate.min.js")); // validate dosyasının adı neyse ona göre ayarlayabilirsin

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/roles/modernizr-2.8.3.js")); // veya varsa farklı modernizr dosyanı ekle

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/roles/bootstrap.min.js")); // veya hangi versiyon varsa ona göre değiştir

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
