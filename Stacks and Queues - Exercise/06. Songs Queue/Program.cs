using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> songs = new Queue<string>(Console.ReadLine()
                .Split(", "));
            
            while (songs.Any())
            {
                string[] command = Console.ReadLine().Split(" ");

                switch (command[0])
                {
                    case "Play":
                        songs.Dequeue();
                        break;

                    case "Add":
                        string songName = string.Join(" ", command.Skip(1));

                        if (songs.Contains(songName))
                        {
                            Console.WriteLine($"{songName} is already contained!");
                        }
                        else
                        {
                            songs.Enqueue(songName);
                        }
                        break;

                    case "Show":
                        Console.WriteLine(String.Join(", ", songs));
                        break;
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}
