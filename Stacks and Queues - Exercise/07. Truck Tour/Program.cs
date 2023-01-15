using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _07._Truck_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfStations = int.Parse(Console.ReadLine());

            Queue <int[]> stations = new Queue<int[]>();

            for (int i = 0; i < numOfStations; i++)
            {
                int[] stationsInfo = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                stations.Enqueue(stationsInfo);
            }

            int startIndex = 0;

            while (true)
            {
                bool isComplete = true;
                int totalLiters = 0;

                foreach (var station in stations)
                {
                    int liters = station[0];
                    int distance = station[1];

                    totalLiters += liters;

                    if (totalLiters - distance < 0)
                    {
                        startIndex++;
                        int[] currStation = stations.Dequeue();
                        stations.Enqueue(currStation);
                        isComplete = false;
                        break;
                    }

                    totalLiters -= distance;
                }

                if (isComplete)
                {
                    Console.WriteLine(startIndex);
                    break;
                }
            }

        }
    }
}
