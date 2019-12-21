using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardLibrary
{
    public class Post
    {
        public User author { get; set; }
        public DateTime postDate { get; }
        public string content { get; set; }

        //Date taken on instance construction
        public Post()
        {
            this.postDate = DateTime.Now;
        }

        public Post(User author, string content) : this()
        {
            this.author = author;
            this.content = content;
        }
    }
}
