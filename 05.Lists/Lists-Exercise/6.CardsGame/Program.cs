﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> deck1 = Console.ReadLine()
                                    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToList();

            List<int> deck2 = Console.ReadLine()
                                    .Split()
                                    .Select(int.Parse)
                                    .ToList();

            while (deck1.Count !=0 && deck2.Count !=0)
            {
                int firstPlayerCard = deck1[0];//first card of first player
                int secondPlayerCard = deck2[0];//first card of second player


                if (firstPlayerCard > secondPlayerCard)
                {
                    deck1.Add(firstPlayerCard);
                    deck1.Add(secondPlayerCard);

                    //deck1.RemoveAt(0);//directly at index only
                    //deck2.RemoveAt(0);
                }
                else if (firstPlayerCard<secondPlayerCard)
                {
                    deck2.Add(secondPlayerCard);
                    deck2.Add(firstPlayerCard);

                    //deck1.RemoveAt(0);
                    //deck2.RemoveAt(0);
                }
                deck1.RemoveAt(0);
                deck2.RemoveAt(0);

                //else
                //{
                //    deck1.RemoveAt(0);
                //    deck2.RemoveAt(0);
                //}
            }
            if (deck1.Count==0)
            {
                Console.WriteLine($"Second player wins! Sum: {deck2.Sum()}");
            }
            else
            {
                Console.WriteLine($"First player wins! Sum: {deck1.Sum()}");
            }
        }
    }
}
