using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOPostSnippet
{
    class Program
    {
        static void Main(string[] args)
        {
            string title, description;
            title = "this is the title";
            description = "this is the description";
            //title = "";
            //description = "";
            var post = new Post();
            post.Downvote();
            post.Publish(title, description);
            post.Upvote();
            for (int i = 0; i < 8; i++)
            {
                post.Downvote();
            }
            Console.WriteLine("Up: {0}, Down: {1}", post.Upvotes, post.Downvotes);
        }
    }
}
