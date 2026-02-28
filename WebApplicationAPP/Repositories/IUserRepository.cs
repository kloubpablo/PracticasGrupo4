using WebApplicationAPP.Models;

namespace WebApplicationAPP.Repositories
{
    public interface IUserRepository
    {
        List<User> GetAll();
        void Add(User user);
    }
}
