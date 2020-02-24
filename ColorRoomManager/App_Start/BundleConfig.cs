using System.Web;
using System.Web.Optimization;

namespace ColorRoomManager
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-3.4.1.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/Content/scripts").Include(
                       "~/Content/bower_components/jquery/dist/jquery.min.js",
                       "~/Content/bower_components/jquery-ui/jquery-ui.min.js",
                       "~/Content/bower_components/bootstrap/dist/js/bootstrap.min.js",
                       "~/Content/bower_components/raphael/raphael.min.js",
                       "~/Content/bower_components/morris.js/morris.min.js",
                       "~/Content/bower_components/jquery-sparkline/dist/jquery.sparkline.min.js",
                       "~/Content/plugins/jvectormap/jquery-jvectormap-1.2.2.min.js",
                       "~/Content/plugins/jvectormap/jquery-jvectormap-world-mill-en.js",
                       "~/Content/bower_components/jquery-knob/dist/jquery.knob.min.js",
                       "~/Content/bower_components/moment/min/moment.min.js",
                       "~/Content/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.all.min.js",
                       "~/Content/bower_components/jquery-slimscroll/jquery.slimscroll.min.js",
                       "~/Content/bower_components/fastclick/lib/fastclick.js",
                       "~/Content/dist/js/adminlte.min.js",
                       "~/Content/dist/js/pages/dashboard.js",
                       "~/Content/dist/js/demo.js",
                       "~/Content/plugins/iCheck/icheck.min.js",
                       "~/Content/plugins/input-mask/jquery.inputmask.js",
                       "~/Content/plugins/input-mask/jquery.inputmask.date.extensions.js",
                       "~/Content/plugins/input-mask/jquery.inputmask.extensions.js",
                       "~/Content/bower_components/bootstrap-datepicker/dist/js/bootstrap-datepicker.min.js",
                       "~/Content/bower_components/bootstrap-daterangepicker/daterangepicker.js",
                       "~/Content/bower_components/datetimepicker/bootstrap-datetimepicker.min.js",
                       "~/Content/bower_components/select2/dist/js/select2.full.min.js",
                       "~/Content/plugins/fancybox/jquery.fancybox.min.js",
                       "~/Content/bower_components/datatables.net/js/jquery.dataTables.min.js",
                       "~/Content/bower_components/datatables.net-bs/js/dataTables.bootstrap.min.js",
                       "~/Content/bower_components/bootstrap-dual-listbox/dist/jquery.bootstrap-duallistbox.min.js",
                       "~/Content/bower_components/bootstrap-dual-listbox/dist/jquery.bootstrap-duallistbox.js",
                       "~/Content/bower_components/jquery/src/jquery-3.4.1.slim.min.js"
                       ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bower_components/font-awesome/css/font-awesome.min.css",
                      "~/Content/bower_components/Ionicons/css/ionicons.min.css",
                      "~/Content/dist/css/AdminLTE.min.css",
                      "~/Content/dist/css/skins/_all-skins.min.css",
                      "~/Content/bower_components/morris.js/morris.css",
                      "~/Content/bower_components/jvectormap/jquery-jvectormap.css",
                      "~/Content/bower_components/bootstrap-datepicker/dist/css/bootstrap-datepicker.min.css",
                      "~/Content/bower_components/bootstrap-daterangepicker/daterangepicker.css",
                      "~/Content/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.min.css",
                      "~/Content/plugins/iCheck/all.css",
                      "~/Content/bower_components/datatables.net-bs/css/dataTables.bootstrap.min.css",
                      "~/Content/bower_components/plugins/iCheck/all.css",
                      "~/Content/bower_components/bootstrap-colorpicker/dist/css/bootstrap-colorpicker.min.css",
                      "~/Content/plugins/timepicker/bootstrap-timepicker.min.css",
                      "~/Content/bower_components/datetimepicker/bootstrap-datetimepicker.min.css",
                      "~/Content/bower_components/select2/dist/css/select2.min.css",
                      "~/Content/plugins/fancybox/jquery.fancybox.min.css",
                      "~/Content/bower_components/bootstrap-dual-listbox/dist/bootstrap-duallistbox.css",
                      "~/Content/bower_components/bootstrap-dual-listbox/dist/bootstrap-duallistbox.min.css",
                      "~/Content/bower_components/bootstrap/dist/css/bootstrap.min.css",
                      "~/Content/site.css"));
        }
    }
}
