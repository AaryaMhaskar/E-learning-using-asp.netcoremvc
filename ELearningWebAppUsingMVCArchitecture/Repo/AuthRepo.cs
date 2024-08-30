using ELearningWebAppUsingMVCArchitecture.Models;

namespace ELearningWebAppUsingMVCArchitecture.Repo
{
    public interface AuthRepo
    {

        void AddUser(User u);

        int AuthenticateUser(User u);
    }
}
