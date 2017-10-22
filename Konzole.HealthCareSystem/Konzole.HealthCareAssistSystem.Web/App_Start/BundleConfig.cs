using System.Web;
using System.Web.Optimization;

namespace Konzole.HealthCareAssistSystem.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/bootstrap").Include(
                                 "~/Content/css/bootstrap.css",
                                 "~/Content/css/bootstrap-theme.css"));

            bundles.Add(new StyleBundle("~/Content/startmin").Include(
                              "~/Content/css/startmin.css"));

            bundles.Add(new StyleBundle("~/Content/metisMenu").Include(
                                "~/Content/css/metisMenu.min.css"));

            bundles.Add(new StyleBundle("~/Content/timeline").Include(
                                "~/Content/css/timeline.css"));

          

            bundles.Add(new StyleBundle("~/Content/morris").Include(
                                "~/Content/css/morris.css"));

            //bundles.Add(new StyleBundle("~/Content/Site").Include(
            //            "~/Content/Site.css"));

            bundles.Add(new StyleBundle("~/Content/dataTable-style").Include(
                                "~/Content/css/datatables/dataTables.bootstrap.css",
                                "~/Content/css/datatables/dataTables.responsive.css"));

            bundles.Add(new StyleBundle("~/Content/bootstrap-dataTable-style").Include(
                                "~/Content/scripts/bootstrap-datatables/datatables.min.css"));

            bundles.Add(new ScriptBundle("~/Content/jquery").Include(
                                "~/Content/scripts/jquery-2.2.4.js"));

            bundles.Add(new ScriptBundle("~/Content/dataTable-script").Include(
                                "~/Content/scripts/datatables/jquery.dataTables.min.js",
                                "~/Content/scripts/datatables/dataTables.bootstrap.min.js",
                                "~/Content/scripts/datatables/dataTables.fixedColumns.min.js"));

            bundles.Add(new ScriptBundle("~/Content/bootstrap-dataTable-script").Include(
                                "~/Content/scripts/bootstrap-datatables/datatables.min.js"));

            bundles.Add(new ScriptBundle("~/Content/js").Include(
                                "~/Content/scripts/bootstrap.js",
                                "~/Content/scripts/metisMenu.min.js",
                                "~/Content/scripts/raphael.min.js",
                                "~/Content/scripts/startmin.js",
                                "~/Content/scripts/morris.min.js"));
            //"~/Content/scripts/project-data.js"));
            //"~/Content/scripts/morris-data.js"));

            BundleTable.EnableOptimizations = true;
        }
    }
}
