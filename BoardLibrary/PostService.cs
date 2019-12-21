using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardLibrary
{
    public class PostService
    {
        Board board;

        public PostService()
        {
            board = Board.Instance;
        }

        public void AddPost(Post post)
        {
            board.PostList.Add(post);
        }
    }
}
