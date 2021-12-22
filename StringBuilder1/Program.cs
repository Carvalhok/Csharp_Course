using System;
using System.Collections.Generic;
using StringBuilder1.Entiites;

namespace StringBuilder1
{
    class Program
    {
        static void Main(string[] args)
        {

            Comment comentario1 = new Comment("Have a nice trip");
            Comment comentario2 = new Comment("Wow, Thats Awesome?!");
            Post post1 = new Post
            {
                Moment = DateTime.Parse("21/06/2018 13:05:44 "),
                Title = "Treveling to New Zealand",
                Content = "I'm going to visit this wonderfull country",
                Likes = 12,
            };

            post1.AddComment(comentario1);
            post1.AddComment(comentario2);

            Comment comentario3 = new Comment("Good Night");
            Comment comentario4 = new Comment("May the force be with you!");

            Post post2 = new Post
            {
                Moment = DateTime.Now,
                Title = "Good Night Guys",
                Content = "See you tomorrow",
                Likes = 5
            };

            post2.AddComment(comentario3);
            post2.AddComment(comentario4);

            Console.WriteLine(post1);
            Console.WriteLine(post2);
        }

    }
}
