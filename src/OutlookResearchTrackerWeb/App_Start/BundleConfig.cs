﻿using System.Web;
using System.Web.Optimization;

namespace OutlookResearchTrackerWeb
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/knockoutjs").Include(
                        "~/Scripts/knockout-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/notifications").Include(
                      "~/Scripts/toastr.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/office").Include(
                        "~/Scripts/Office/1.1/office.js",
                        "~/Scripts/Office/MicrosoftAjax.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/toastr.css",
                      "~/Content/bootstrap.css",
                      "~/Content/bootstrap-theme.css",
                      "~/Content/office.css",
                      "~/Content/site.css",
                      "~/Content/app.css",
                      "~/Content/research.css"));

        }
    }
}
