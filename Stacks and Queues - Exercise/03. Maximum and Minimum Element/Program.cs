using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfQueries = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < numOfQueries; i++)
            {
                int[] queries = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                int query = queries[0];

                switch (query)
                {
                    case 1:
                        int numToPush = queries[1];
                        stack.Push(numToPush);
                        break;
                    case 2:
                        if (stack.Any())
                        {
                            stack.Pop();
                        }
                        break;
                    case 3:
                        if (stack.Any())
                        {
                            Console.WriteLine(stack.Max());
                        }
                        break;
                    case 4:
                        if (stack.Any())
                        {
                            Console.WriteLine(stack.Min());
                        }
                        break;
                }
            }

            Console.WriteLine(String.Join(", ", stack));
        }
    }
}
