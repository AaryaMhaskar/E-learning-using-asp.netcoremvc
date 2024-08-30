using Microsoft.AspNetCore.Mvc;

namespace ELearningWebAppUsingMVCArchitecture.Controllers
{


	public class IndexController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult About()
		{
			return View();
		}
		public IActionResult Courses()
		{
			return View();
		}
		public IActionResult Blog()
		{
			return View();
		}
	}
}
