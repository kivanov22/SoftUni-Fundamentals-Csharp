﻿using System;
using System.Numerics;

namespace _3._ExactSumOfRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());

            decimal sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += decimal.Parse(Console.ReadLine());
                
            }
            Console.WriteLine(sum);
        }
    }
}
