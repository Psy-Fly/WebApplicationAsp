// AlexeyQwake Qwake

using System;
using System.Collections.Generic;
using System.Linq;

namespace WebApplication1.Repositories
{
    public class UserRepository : IUserRepository
    {
        private List<User> users;

        public UserRepository()
        {
            users = new List<User>();
            var user1 = new User()
            {
                Id = Guid.NewGuid(),
                FirstName = "Alex",
                LastName = "Bogrov",
                Email = "alex@mail.ru",
                Password = "1234",
                Login = "bogrov",
                Role = new Role()
                {
                    Id = 1,
                    Name = "user"
                }
            };
            
            var user2 = new User()
            {
                Id = Guid.NewGuid(),
                FirstName = "Kolyan",
                LastName = "Pashkov",
                Email = "kolyan@mail.ru",
                Password = "2222",
                Login = "kolkol",
                Role = new Role()
                {
                    Id = 2,
                    Name = "admin"
                }
            };
            
            var user3 = new User()
            {
                Id = Guid.NewGuid(),
                FirstName = "Liza",
                LastName = "Markova",
                Email = "lizka@mail.ru",
                Password = "3334",
                Login = "lizz",
                Role = new Role()
                {
                    Id = 1,
                    Name = "user"
                }
            };
            
            users.Add(user1);
            users.Add(user2);
            users.Add(user3);
        }
        
        public IEnumerable<User> GetAll()
        {
            return users;
        }

        public User GetByLogin(string login)
        {
            return users.FirstOrDefault(x => x.Login == login);
        }
    }
}