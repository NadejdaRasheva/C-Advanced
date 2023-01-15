using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> clothes = new Stack<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse));

            int capacity = int.Parse(Console.ReadLine());

            int countOfRacks = 1;
            int currRackCapacity = capacity;

            while (clothes.Any())
            {
                if (clothes.Peek() <= currRackCapacity)
                {
                    currRackCapacity -= clothes.Pop();
                }
                else
                {
                    countOfRacks++;
                    currRackCapacity = capacity;
                    currRackCapacity -= clothes.Pop();
                }
            }

            Console.WriteLine(countOfRacks);
        }
    }
}
