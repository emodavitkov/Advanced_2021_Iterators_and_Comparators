﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Froggy
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> stones = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToList();

            Lake lake = new Lake(stones);

            //foreach (int stone in lake)
            //{
            //    Console.WriteLine(stone);

                
            //}

            Console.WriteLine(string.Join(", ", lake));
        }
    }
}