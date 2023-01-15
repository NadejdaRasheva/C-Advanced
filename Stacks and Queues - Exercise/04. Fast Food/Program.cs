using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int food = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < orders.Length; i++)
            {
                queue.Enqueue(orders[i]);
            }
            int biggestOrder = queue.Max();

            for (int i = 0; i < orders.Length; i++)
            {
                if (food - queue.Peek() >= 0)
                {
                    food -= orders[i];
                    queue.Dequeue();
                }
            }

            Console.WriteLine(biggestOrder);
            if (queue.Any())
            {
                Console.WriteLine($"Orders left: {String.Join(" ", queue)}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
