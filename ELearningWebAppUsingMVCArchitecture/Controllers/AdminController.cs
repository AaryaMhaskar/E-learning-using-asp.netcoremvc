using ELearningWebAppUsingMVCArchitecture.Models;
using ELearningWebAppUsingMVCArchitecture.Repo;
using Microsoft.AspNetCore.Mvc;

namespace ELearningWebAppUsingMVCArchitecture.Controllers
{
    public class AdminController : Controller
    {
        private readonly AdminRepo repo;

        public AdminController(AdminRepo repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Categories()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Categories(Categories cat)
        {
            repo.AddCategory(cat);
            return View();
        }

        public IActionResult Sub_Categories()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Sub_Categories(Sub_Categories sub_Categories)
        {
            
            return View();
        }

    }
}
