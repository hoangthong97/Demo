using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAPI.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			//B1: create project
			//B2: install package Microsoft.AspNet.WebApi.Cors
			//B3: Add webconfig cho CROS
			//B4: Vào webapiconfig trong app_start cấu hình
			ViewBag.Title = "Home Page";

			return View();
		}
	}
}
