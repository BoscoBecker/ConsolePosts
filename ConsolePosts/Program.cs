using ConsolePosts.Entities.Comments;
using ConsolePosts.Entities.Post;

namespace ConsolePosts
{
    class Program
    {
        static void Main(string[] args)
        {

            Comment comment1 = new Comment("Have a Nice tripe");
            Comment comment2 = new Comment("How That's Awesome");

            Post post1 = new Post(
                DateTime.Parse("21/06/2018 12:00:00"),
                "Travelling to new Zealand",
                "I'm going to visit this wonderful contry",
                12);

            post1.AddComment(comment1);

            Post post2 = new Post(
                DateTime.Parse("01/06/2020 19:00:01"),
                "Traveling to new USA",
                "I'm going to visit this contry, American Dream",
                50);

            post2.AddComment(comment2);


            Console.WriteLine(post1.ToString());
            Console.WriteLine(post2.ToString());


        }
    } 
}












































































































































































































