using System.Web;
using System.Web.Optimization;

namespace Tuva.On.Line
{
    public class BundleConfig
    {
        //Дополнительные сведения об объединении см. по адресу: http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                          "~/Scripts/jquery-{version}.js"
                        , "~/Scripts/Plugins/jquery.slimscroll.min.js"
                        , "~/Scripts/Plugins/fastclick.min.js"
                        , "~/Scripts/Plugins/jquery.maskedinput.min.js"
                        , "~/Scripts/Plugins/select2.full.min.js"
                        , "~/Content/iCheck/icheck.min.js"
                        , "~/Scripts/knockout-{version}.js"
                        , "~/Scripts/Plugins/knockout.simplegrid.3.js"
                        , "~/Scripts/handlebars.min.js"
                        , "~/Scripts/app/typeahead.bundle.js"
                        , "~/Scripts/App/app.js"
                        , "~/Scripts/App/Utils.js"
                        , "~/Scripts/App/ko-custom-bindings.js"
                        , "~/Scripts/App/int.navigation.js"
                        , "~/Scripts/App/entities.js"
                        , "~/Scripts/App/DataTable.js"
                        , "~/Scripts/App/DataTableWithPagination.js"
                        , "~/Scripts/App/DataTableWithPaginationExt.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Используйте версию Modernizr для разработчиков, чтобы учиться работать. Когда вы будете готовы перейти к работе,
            // используйте средство сборки на сайте http://modernizr.com, чтобы выбрать только нужные тесты.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"
                      , "~/Scripts/respond.js"
                      , "~/Scripts/Plugins/bootstrap-notify.js"
                      ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css"
                      , "~/css/font-awesome.min.css"
                      , "~/Content/adminLTE.css"
                      , "~/Content/skins/_all-skins.css"
                      , "~/Content/ionicons.css"
                      , "~/Content/site.css"
                      , "~/Content/Typeahead-BS3-css.css"
                      , "~/Content/select2.min.css"
                      ));
        }
    }
}
