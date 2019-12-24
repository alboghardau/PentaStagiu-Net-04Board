using BoardLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardApp
{
    class ReadApp
    {
        public ReadApp(Board board)
        {
            List<Post> posts = board.GetPostList();

            posts.ForEach(post =>
            {
                Console.WriteLine("##########################################");
                Console.WriteLine(post.PostDate);
                Console.WriteLine(post.Author.GetFullName());
                Console.WriteLine(post.Content);
                Console.WriteLine("##########################################");
                BoardMessages.PrintSpace();
            });
        }
    }
}
