using System;
using System.Collections.Generic;

namespace _8._Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int counter = 0;

            Queue<string> queue = new Queue<string>();

            while (input != "end")
            {
                if (input == "green")
                {
                    if (queue.Count >= n)
                    {
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine($"{queue.Dequeue()} passed!");
                            counter++;
                        }
                    }
                    else
                    {
                        int count = queue.Count;
                        for (int i = 0; i < count; i++)
                        {
                            Console.WriteLine($"{queue.Dequeue()} passed!");
                            counter++;
                        }
                    }
                }
                else
                {
                    queue.Enqueue(input);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}
