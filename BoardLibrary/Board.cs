using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Singleton class for the board data
namespace BoardLibrary
{
    public class Board
    {
        private static readonly Board instance = new Board();
        List<Post> postList = new List<Post>();
        List<User> userList = new List<User>();
        User loggedUser;

        static Board()
        {

        }

        private Board()
        {

        }
        public static Board Instance
        { 
            get
            {
                return instance;
            }
        }

    }
}
