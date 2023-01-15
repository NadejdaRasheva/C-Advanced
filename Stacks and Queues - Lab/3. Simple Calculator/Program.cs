using System;
using System.Collections.Generic;

namespace _3._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] problem = Console.ReadLine().Split();

            Stack<string> expression = new Stack<string>(new Stack<string>(problem));


            while (expression.Count > 1)
            {
                int left = int.Parse(expression.Pop());
                string sign = expression.Pop();
                int right = int.Parse(expression.Pop());

                if (sign == "+")
                {
                    expression.Push((left + right).ToString());
                }
                else if (sign == "-")
                {
                    expression.Push((left - right).ToString());
                }
            }

            Console.WriteLine(expression.Pop());
        }
    }
}
