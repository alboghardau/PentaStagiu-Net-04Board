using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//SINGLETON BOARD CLASS TO HANDLE THE DATA
namespace BoardLibrary
{
    public class Board
    {
        private static Board instance = null;
        public List<Post> PostList { get; set; }
        public List<User> UserList { get; set; }
        public User LoggedUser { get; set; }

        private Board()
        {
            this.PostList = new List<Post>();
            this.UserList = new List<User>();

            //LOAD BOARD DATA FROM XML
            try
            {
                this.PostList = XmlSerialization.ReadFromXmlFile<List<Post>>("posts.xml");
                this.UserList = XmlSerialization.ReadFromXmlFile<List<User>>("users.xml");
            }
            catch(Exception e)
            {
                Console.WriteLine("###FAILED TO LOAD XML DATA!###");
            }            
        }

        public static Board Instance
        { 
            get
            {
                if(instance == null)
                {
                    instance = new Board();
                }
                return instance;
            }
        }

        //SAVE BOARD DATA TO XML
        public void SaveData()
        {
            XmlSerialization.WriteToXmlFile<List<Post>>("posts.xml", instance.PostList);
            XmlSerialization.WriteToXmlFile<List<User>>("users.xml", instance.UserList);
        }   
    }
}
