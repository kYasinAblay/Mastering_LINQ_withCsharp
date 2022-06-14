﻿using System;
using System.Linq;

namespace MergeOptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(1, 20).ToArray();
            //NotBuffered
            var results = numbers.AsParallel().WithMergeOptions(ParallelMergeOptions.FullyBuffered)
                .Select(x =>
                {
                    var result = Math.Log10(x);
                    Console.Write($"P {result}\t");
                    return result;
                });

            foreach (var result in results)
            {
                Console.Write($"C {result}\t");
            }
        }
    }
}
