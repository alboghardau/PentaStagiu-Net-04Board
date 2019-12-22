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
        bool LoginUser();
        User GetLoggedUser();
    }
}
