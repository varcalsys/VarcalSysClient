using System.Web;
using System.Web.Optimization;


namespace VarcalSysClient.Web
{
    public class BundleConfig
    {
        public static void RegisterBundle(BundleCollection bundles)
        {
            
            //Arquivos JS
            bundles.Add(new ScriptBundle("~/bundle/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundle/jqueryval").Include(
                       "~/Scripts/jquery.validate*"));


            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundle/bootstrap").Include(
                        "~/Scripts/bootstrap.js",
                        "~/Scripts/respond.js"));


            //Arquivos CSS
            bundles.Add(new StyleBundle("~/Content/css").Include(
                        "~/Content/bootstrap.css",
                        "~/Content/bootstrap-theme.css",
                        "~/Content/css/Site.css"));

        }
    }
}