using ELearningWebAppUsingMVCArchitecture.Models;

namespace ELearningWebAppUsingMVCArchitecture.Repo
{
    public interface AdminRepo
    {
        void AddCategory(Categories cat);
        void AddSubCategory(Sub_Categories sub);

    }
}
