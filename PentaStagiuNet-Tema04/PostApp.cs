using BoardLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardApp
{
    class PostApp
    {
        public PostApp(Board board)
        {
            Post post = new Post();
            
            if(board.GetLoggedUser() != null)
            {
                BoardMessages.PrintSpace();
                Console.WriteLine("##########################################");
                Console.WriteLine("CREATE NEW POST");
                Console.WriteLine("##########################################");

                Console.Write("New message: ");
                string content = Console.ReadLine();
                
                post.Author = board.GetLoggedUser();
                post.Content = content;
                post.PostDate = DateTime.Now;

                board.AddPost(post);
            }
            else
            {
                Console.WriteLine("Please login in order submit new post!");
            }

            


        }
    }
}
