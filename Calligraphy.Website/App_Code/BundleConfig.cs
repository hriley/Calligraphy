using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Calligraphy.App_Code
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles) {
            bundles.Add(new ScriptBundle("~/bundles/JsLibraries").Include("~/Scripts/Libs/Angular/angular.js",
                                                                      "~/Scripts/Libs/Angular/angular-route.js",
                                                                      "~/Scripts/Libs/Angular/angular-resource.js",
                                                                      "~/Scripts/Libs/JQuery/jquery-1.9.1.js",
                                                                      "~/Scripts/Libs/bootstrap.js",
                                                                      "~/Scripts/Libs/jssor.js",
                                                                      "~/Scripts/Libs/jssor.slider.js",
                                                                      "~/Scripts/Libs/json2.js"));

            bundles.Add(new ScriptBundle("~/bundles/Fancybox").Include("~/content/fancybox/jquery.mousewheel-3.0.4.pack.js",
                                                                      "~/content/fancybox/jquery.fancybox-1.3.4.pack.js"));

            bundles.Add(new ScriptBundle("~/bundles/AppCode").Include("~/Scripts/Calligraphy.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.unobtrusive*",
            //            "~/Scripts/jquery.validate*"));

            //// Use the development version of Modernizr to develop with and learn from. Then, when you're
            //// ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            //bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/CSS/site.css"));

            //bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
            //            "~/Content/themes/base/jquery.ui.core.css",
            //            "~/Content/themes/base/jquery.ui.resizable.css",
            //            "~/Content/themes/base/jquery.ui.selectable.css",
            //            "~/Content/themes/base/jquery.ui.accordion.css",
            //            "~/Content/themes/base/jquery.ui.autocomplete.css",
            //            "~/Content/themes/base/jquery.ui.button.css",
            //            "~/Content/themes/base/jquery.ui.dialog.css",
            //            "~/Content/themes/base/jquery.ui.slider.css",
            //            "~/Content/themes/base/jquery.ui.tabs.css",
            //            "~/Content/themes/base/jquery.ui.datepicker.css",
            //            "~/Content/themes/base/jquery.ui.progressbar.css",
            //            "~/Content/themes/base/jquery.ui.theme.css"));
            //BundleTable.EnableOptimizations = true;
        }
        
    }
}