﻿using System;

namespace _4.ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            string reversed = "";

            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversed += word[i];
            }
            Console.WriteLine($"{reversed}");
        }
    }
}
