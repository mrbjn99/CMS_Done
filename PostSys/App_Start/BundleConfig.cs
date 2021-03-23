using System.Web;
using System.Web.Optimization;

namespace PostSys
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
					  "~/Scripts/bootstrap.js"));

			bundles.Add(new StyleBundle("~/Content/css").Include(
					  "~/Content/bootstrap.css",
					  "~/Content/site.css"));

			//////////////////////////
			///Datta Table Template///
			//////////////////////////
			bundles.Add(new StyleBundle("~/assets/css").Include(
				"~/assets/css/style.css"));

			bundles.Add(new ScriptBundle("~/assets/js").Include(
				"~/assets/js/pcoded.min.js",
				"~/assets/js/vendor-all.min.js"));

			bundles.Add(new StyleBundle("~/assets/plugins/animation").Include(
				"~/assets/plugins/animation/css/animate.min.css"));

			bundles.Add(new StyleBundle("~/assets/plugins/bootstrap/css").Include(
				"~/assets/plugins/bootstrap/css/bootstrap.css",
				"~/assets/plugins/bootstrap/css/bootstrap.min.css"));

			bundles.Add(new ScriptBundle("~/assets/plugins/bootstrap/js").Include(
				"~/assets/plugins/bootstrap/js/bootstrap.js",
				"~/assets/plugins/bootstrap/js/bootstrap.min.js",
				"~/assets/plugins/bootstrap/js/popover.js"));

			bundles.Add(new ScriptBundle("~/assets/plugins/jquery/js").Include(
				"~/assets/plugins/jquery/js/jquery.min.js"));

			bundles.Add(new StyleBundle("~/assets/plugins/jquery-scrollbar/css").Include(
				"~/assets/plugins/jquery-scrollbar/css/jquery.scrollbar.min.css"));

			bundles.Add(new ScriptBundle("~/assets/plugins/jquery-scrollbar/js").Include(
				"~/assets/plugins/jquery-scrollbar/js/jquery.scrollbar.min.js"));

			bundles.Add(new ScriptBundle("~/assets/plugins/jquery-ui/js").Include(
				"~/assets/plugins/jquery-ui/js/jquery-ui.js"));


			//////////////////////////////
			///////////HomePage//////////
			////////////////////////////
			bundles.Add(new StyleBundle("~/css/").Include(
					  "~/css/bootstrap.css",
					  "~/css/fontawesome-all.css",
					  "~/css/styles.css",
					  "~/css/magnific-popup.css",
					  "~/css/swiper.css"));

			bundles.Add(new ScriptBundle("~/js/").Include(
					  "~/js/bootstrap.min.js",
					  "~/js/jquery.easing.min.js",
					  "~/js/jquery.magnific-popup.js",
					  "~/js/jquery.min.js",
					  "~/js/popper.min.js",
					  "~/js/scripts.js",
					  "~/js/swiper.min.js",
					  "~/js/validator.min.js"));

		}
	}
}
