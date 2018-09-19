using System;
using System.Reflection;

namespace SOPostSnippet
{
    public class Post
    {
        // needs to have props for title, description, date/time
        // should be able to upvote and downvote
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateTime { get; private set; }
        public int Upvotes { get; private set; }
        public int Downvotes { get; private set; }
        private bool isPostValid;

        public Post()
        {
            Upvotes = 0;
            Downvotes = 0;
            isPostValid = false;
        }
         
        public int Upvote()
        {
            return isPostValid ? Upvotes++ : throw new Exception("Cannot vote on this post yet");
        }

        public int Downvote()
        {
            return isPostValid ? Downvotes++ : throw new Exception("Cannot vote on this post yet");
        }

        public void Publish(string title, string description)
        {
            if (!String.IsNullOrEmpty(title) && !(String.IsNullOrEmpty(description)))
            {
                DateTime = DateTime.Now;
                Title = title;
                Description = description;
                isPostValid = true;
                Console.WriteLine("Post published successfully");
            }
            else
            {
                throw new Exception("Your post is invalid");
            }
        }
    }
}