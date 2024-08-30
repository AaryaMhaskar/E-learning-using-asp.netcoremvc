using ELearningWebAppUsingMVCArchitecture.Data;
using ELearningWebAppUsingMVCArchitecture.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;

namespace ELearningWebAppUsingMVCArchitecture.Repo
{
    public class AuthService:AuthRepo
    {
        private readonly ApplicationDbContext db;
         public AuthService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public void AddUser(User u)
        {
            u.Urole = "User";
            db.Database.ExecuteSqlRaw($"exec AddUser '{u.Username}','{u.Email}','{u.Password}','{u.Urole}'");
            //var identity = new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, u.Username) },CookieAuthenticationDefaults.AuthenticationScheme);
            //var principal = new ClaimsPrincipal(identity);
            

        }

        public int AuthenticateUser(User u)
        {
            var data = db.Users.Where(x => x.Username.Equals(u.Username)).SingleOrDefault();
            if (data != null)
            {
                bool us = data.Username.Equals(u.Username) && data.Password.Equals(u.Password);
                if(us)
                {
                    if(data.Urole =="Admin")
                    {
                        return 1;
                        
                    }
                    else
                    {
                        return 2;
                    }

                    
                }

                
            }
            return 0;
        }


        public void AddCategory()
        {

        }
        public void AddVideos()
        {

        }
        
    }
}
