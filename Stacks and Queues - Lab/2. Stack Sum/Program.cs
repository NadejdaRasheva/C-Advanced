using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse));

            string input = Console.ReadLine().ToLower();

            while (input != "end")
            {
                string[] commInfo = input.Split();
                string comm = commInfo[0];

                switch (comm)
                {
                    case "add":
                        int first = int.Parse(commInfo[1]);
                        int second = int.Parse(commInfo[2]);
                        stack.Push(first);
                        stack.Push(second);
                        break;

                    case "remove":
                        int count = int.Parse(commInfo[1]);

                        if (stack.Count >= count)
                        {
                            for (int i = 0; i < count; i++)
                            {
                                stack.Pop();
                            }
                        }
                        break;
                }

                input = Console.ReadLine().ToLower();
            }

            int sum = 0;
            int length = stack.Count();
            for (int i = 0; i < length; i++)
            {
                sum += stack.Pop();
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
