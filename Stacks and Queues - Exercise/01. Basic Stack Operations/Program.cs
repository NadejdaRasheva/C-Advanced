using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int numsToPush = nums[0];
            int numsToPop = nums[1];
            int numsToPeek = nums[2];

            int[] pushing = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < numsToPush; i++)
            {
                stack.Push(pushing[i]);
            }

            for (int i = 0; i < numsToPop; i++)
            {
                stack.Pop();
            }

            if (stack.Any())
            {
                if (stack.Contains(numsToPeek))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(stack.Min());
                }
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
