using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PostSys.Controllers
{
	public class HomeController : Controller
	{
		[Authorize(Roles = "Marketing Manager, Student, Marketing Coordinator, Guest, Admin")]
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult HomePage()
		{

			return View();
		}
	}
}