using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardLibrary
{
    public class UserService : IUserService
    {
        private List<User> userList;
        private User loggedUser = null;

        //READ DATA FROM XML OR NEW LIST INSTANCE IN CONSTRUCTOR
        public UserService()
        { 
            try
            {
                this.userList = XmlSerialization.ReadFromXmlFile<List<User>>("users.xml");
            }
            catch(Exception e)
            {
                this.userList = new List<User>();
                Console.WriteLine("###FAILED TO LOAD XML DATA!###");
            }
        }

        //SAVE XML DATA IN DESTRUCTOR
        ~UserService()
        {
            XmlSerialization.WriteToXmlFile("users.xml", this.userList);
        }

        public User AddUser(User user)
        {
            this.userList.Add(user);
            return user;
        }

        public List<User> GetUsers()
        {
            return this.userList;
        }

        public bool LoginUser(string username)
        {
            foreach(User user in userList)
            {
                if (user.Username.Equals(username))
                {
                    this.loggedUser = user;
                    return true;
                }
            }
            return false;
        }

        public User GetLoggedUser()
        {
            return this.loggedUser;
        }

   
    }
}
