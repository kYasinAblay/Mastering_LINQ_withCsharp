using System;
using System.Collections.Generic;
using System.Linq;

namespace ConcenationOperations_Concat
{  // Define other methods and classes here
    static class ExtensionMethods
    {
        public static IEnumerable<T> Prepend<T>(
                this IEnumerable<T> values, T value)
        {
            yield return value;
            foreach (var item in values)
            {
                yield return item;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //< Query Kind = "Program" />


            var integralTypes = new[] { typeof(int), typeof(short) };
            var fpTypes = new[] { typeof(float), typeof(double) };

            Console.WriteLine(
                integralTypes.Concat(fpTypes)
                             .Prepend(typeof(byte))
            );
        }

      
    }
}
