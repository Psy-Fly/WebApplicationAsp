// AlexeyQwake Qwake

using System.Collections.Generic;

namespace WebApplication1.Repositories
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();
        User GetByLogin(string login);
    }
}