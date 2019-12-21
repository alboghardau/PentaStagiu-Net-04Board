using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardLibrary
{
    public class UserService
    {
        Board board;

        public UserService(){
            board = Board.Instance;            
        }

        public void AddUser(User user)
        {
            board.UserList.Add(user);
        }

        public List<User> GetUsers()
        {
            return board.UserList;
        }

        public void DeleteUserById(int id)
        {
            board.UserList.ForEach(user =>
            {
                if(user.Id == id)
                {
                    board.UserList.Remove(user);
                }
            });
        }

        public void LogUser(User user)
        {
            board.LoggedUser = user;
        }
   
    }
}
