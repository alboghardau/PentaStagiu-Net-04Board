using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardLibrary
{
    public interface IUserService
    {
        User AddUser(User user);
        List<User> GetUsers();
        bool LoginUser(string email, string password);
        User GetLoggedUser();
    }
}
