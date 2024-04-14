using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsolePosts.Entities.Comments;

namespace ConsolePosts.Entities.Post
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int likes { get; set; }

        private List<Comment> Comments { get; set; } = new List<Comment>();

        public Post(){
            
        }

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            this.likes = likes;
        }

        public void AddComment(Comment comment) {
            Comments.Add(comment);
        }

        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }

        public override string ToString()
        {
            StringBuilder sbPosts = new StringBuilder();
            sbPosts.AppendLine(Title);
            sbPosts.Append(likes);
            sbPosts.AppendLine(" Likes - ");
            sbPosts.AppendLine(Moment.ToString("dd/mm/yyy HH:mm:ss"));
            sbPosts.AppendLine(Content);
            foreach (Comment comment in Comments) {
                sbPosts.AppendLine(comment.Text);
            }
            return sbPosts.ToString();

        }
    }
}
