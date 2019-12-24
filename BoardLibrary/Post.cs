using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardLibrary
{
    public class Post : IComparable<Post>
    {
        public User Author { get; set; }
        public DateTime PostDate { get; set; }
        public string Content { get; set; }

        ////Empty constructor, useing getters/setters
        public Post()
        {

        }

        public int CompareTo(Post other)
        {
            return other.PostDate.Ticks.CompareTo(this.PostDate.Ticks);
        }
    }
}
