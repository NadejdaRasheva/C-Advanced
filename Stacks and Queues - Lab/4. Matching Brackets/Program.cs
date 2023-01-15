using System;
using System.Collections.Generic;

namespace _4._Matching_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    stack.Push(i);
                }
                else if (input[i] == ')')
                {
                    int index = stack.Pop();
                    string expression = string.Empty;
                    for (int j = index; j <= i; j++)
                    {
                        expression += input[j];
                    }
                    Console.WriteLine(expression);
                }
            }
        }
    }
}
