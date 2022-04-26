using Flock.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Flock.Repository
{
    public class UserRepository : IUserRepository
    {
        // -- Simulo una lectura de datos
        private List<UserModel> Users
        {
            get
            {
                var ListUser = new List<UserModel>();
                ListUser.Add(new UserModel() { UserID = 1, UserName = "Usuario", UserPass = "Contra" });
                return ListUser;
            }
        }

        public IEnumerable<UserModel> Get()
        {
            return Users;
        }

        public object GetService(Type serviceType)
        {
            throw new NotImplementedException();
        }

        public UserModel GetUser(string userName)
        {
            return Users.Find(u => u.UserName == userName);
        }
    }
}