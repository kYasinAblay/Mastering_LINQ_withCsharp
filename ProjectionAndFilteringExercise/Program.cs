using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectionAndFilteringExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static IEnumerable<int> MyFilter(IEnumerable<int> input)
            {
                var evenNum = input.OfType<int>().AsEnumerable();
                var result = evenNum.Select(i => i * i);
                result = result.Where(i => i > 50);

                return result;
            }

            var numbers = Enumerable.Range(1, 10);

            foreach (var list in MyFilter(numbers))
                Console.WriteLine(list);

        }
    }
}
