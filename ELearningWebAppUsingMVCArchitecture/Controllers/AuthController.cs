using ELearningWebAppUsingMVCArchitecture.Models;
using ELearningWebAppUsingMVCArchitecture.Repo;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ELearningWebAppUsingMVCArchitecture.Controllers
{
	
	
	public class AuthController : Controller
	{
		private readonly AuthRepo repo;
		public AuthController(AuthRepo repo)
		{
			this.repo= repo;	
		}
		public IActionResult SignUp()
		{
			return View();
		}

		[HttpPost]
		public IActionResult SignUp(User u)
		{
			repo.AddUser(u);
			return RedirectToAction("Index","Index");
		}

		public IActionResult SignIn()
		{

			return View();
		}

		[HttpPost]
		public IActionResult SignIn(User u)
		{
			var data = repo.AuthenticateUser(u);
			if (data == 1)
			{
                var identity = new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, u.Username) },
                        CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);
                HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme, principal);
                HttpContext.Session.SetString("Admin", u.Username);
                return RedirectToAction("Admin", "Index");
                
            }
			else if (data == 2)
			{
                var identity = new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, u.Username) },
                        CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);
                HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme, principal);
                HttpContext.Session.SetString("User", u.Username);
                return RedirectToAction("Index", "Index");
			}
			else
			{
				return View();
			}
			
		}
	}
}
