using System;
using System.Collections.Generic;
using System.Drawing;

namespace _6._Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            Queue<string> queue = new Queue<string>();

            while (input != "End")
            {
                if (input == "Paid")
                {
                    int length = queue.Count;
                    for (int i = 0; i < length; i++)
                    {
                        Console.WriteLine(queue.Dequeue());
                    }
                }
                else
                {
                    queue.Enqueue(input);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}
