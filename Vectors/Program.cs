using System;
using System.Globalization;

namespace Vectors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());
            Room[] room = new Room[10];
            
            for (int i = 0; i < n; i++) {
                Console.WriteLine($"Rent #{i + 1}");
                Console.Write("Name: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = (Console.ReadLine());
                Console.Write("Room number: ");
                int roomNumber = int.Parse(Console.ReadLine());
                room[roomNumber] = new Room(nome, email, roomNumber);
            }

            Console.WriteLine("Busy rooms: ");
            for (int i = 0; i < 10; i++)
            {
                if(room[i] != null)
                {
                    Console.WriteLine(room[i]);
                }
            }
        }
    }
}
