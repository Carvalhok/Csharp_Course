using System;
using StringBuilder.Entities;

namespace StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos post deseja fazer? ");
            int n = int.Parse(Console.ReadLine());
            Post post1;
            Post post2;
            Console.WriteLine("---------------------------------");
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Faça o post{0}: ", i);
                Console.Write("Moment; ");
                DateTime moment = DateTime.Parse(Console.ReadLine());
                Console.Write("Title: ");
                string title = Console.ReadLine();
                Console.WriteLine("Content: ");
                string content = Console.ReadLine();
                int likes = int.Parse(Console.ReadLine());
                post1 = new Post(moment, title, content, likes);
            }
            

            
        }
    }
}
