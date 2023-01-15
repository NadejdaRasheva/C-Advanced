using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToArray();
            int numsToEnque = nums[0];
            int numsToDeque = nums[1];
            int numToFind = nums[2];

            int[] enqueing = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> queue = new Queue<int>();
            for (int i = 0; i < numsToEnque; i++)
            {
                queue.Enqueue(enqueing[i]);
            }

            for (int i = 0; i < numsToDeque; i++)
            {
                queue.Dequeue();
            }

            if (queue.Any())
            {
                if (queue.Contains(numToFind))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(queue.Min());
                }
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
