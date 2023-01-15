using System;
using System.Collections.Generic;

namespace _7._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> players = new Queue<string>(Console.ReadLine().Split());
            int n = int.Parse(Console.ReadLine());

            while (players.Count > 1)
            {
                for (int i = 0; i < n - 1; i++)
                {
                    string currPlayer = players.Dequeue();
                    players.Enqueue(currPlayer);
                }

                Console.WriteLine($"Removed {players.Dequeue()}");
            }

            Console.WriteLine($"Last is {players.Dequeue()}");
        }
    }
}
