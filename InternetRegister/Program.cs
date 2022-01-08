using System;
using System.Collections.Generic;
using InternetRegister.Entities;
using System.IO;


namespace InternetRegister
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<User> user = new HashSet<User>();
            string originPath = @"C:\Users\keverson.carvalho\Desktop\Keverson\Csharp_Course\InternetRegister\in.txt";
            Console.WriteLine("Enter file full path:");

            try
            {
                using (StreamReader sr = File.OpenText(originPath))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(" ");
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);
                        user.Add(new User(name, instant));
                    }

                }

                Console.Write("Total users: ");
                Console.WriteLine(user.Count);

            }

            catch (Exception e)
            {
                Console.WriteLine("Something goes wrong: " + e.Message);
            }

        }
    }
}