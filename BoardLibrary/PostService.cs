using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardLibrary
{
    public class PostService : IPostService
    {
        Board board;
        private List<Post> postList;

        //READ DATA FROM XML OR NEW LIST INSTANCE IN CONSTRUCTOR
        public PostService()
        {
            try
            {
                this.postList = XmlSerialization.ReadFromXmlFile<List<Post>>("posts.xml");
            }
            catch (Exception e)
            {
                this.postList = new List<Post>();
                Console.WriteLine("###FAILED TO LOAD XML DATA!###");
            }
        }

        ~PostService()
        {
            XmlSerialization.WriteToXmlFile("posts.xml", this.postList);
        }

        public Post AddPost(Post post)
        {
            this.postList.Add(post);
            return post;
        }
    }
}
