using ELearningWebAppUsingMVCArchitecture.Controllers;
using ELearningWebAppUsingMVCArchitecture.Data;
using ELearningWebAppUsingMVCArchitecture.Models;
using Microsoft.EntityFrameworkCore;

namespace ELearningWebAppUsingMVCArchitecture.Repo
{
    public class AdminService :AdminRepo
    {
        private readonly ApplicationDbContext db;

        public AdminService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public void AddCategory(Categories cat)
        {
            db.Database.ExecuteSqlRaw($"exec AddCategory1 '{cat.CategoryName}'");


        }

        public void AddSubCategory(Sub_Categories sub)
        {
            db.Database.ExecuteSqlRaw();

        }



    }
}
