﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();

            int maxCapacity = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            while (command !="end")
            {
                string[] commandArguments = command.Split();

                if (commandArguments[0]=="Add")
                {
                    wagons.Add(int.Parse(commandArguments[1]));
                }
                else
                {
                    int passengers = int.Parse(commandArguments[0]);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        int currentWagon = wagons[i];
                        bool isEnoughSpace = currentWagon + passengers <= maxCapacity;

                        if (isEnoughSpace)
                        {
                            wagons[i] += passengers;
                            break;
                        }
                    }
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",wagons));
            
        }
    }
}
