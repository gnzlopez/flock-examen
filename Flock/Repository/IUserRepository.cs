using Flock.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flock.Repository
{
    public interface IUserRepository : IServiceProvider
    {
        IEnumerable<UserModel> Get();

        UserModel GetUser(String userName);
    }
}
