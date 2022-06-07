using System;
using System.Collections.Generic;
using System.Linq;

namespace PartitioningData_SkipWhile_TakeWhile
{
    public static class ExtensionInt
    {
        public static void ShowInConsole(this IEnumerable<int> list)
        {
            foreach (var item in list)
                Console.WriteLine(item);

            Console.WriteLine("---------------------------");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //< Query Kind = "Statements" />

            var numbers = new[] { 3, 3, 2, 2, 1, 1, 2, 2, 3, 3 };

            numbers.Skip(2).Take(6).ShowInConsole();

            new int[] { }.Take(2).ShowInConsole();

            numbers.SkipWhile(i => i == 3).ShowInConsole();
            numbers.TakeWhile(i => i > 1).ShowInConsole();

            int[] numbers2 = { 5, 4, 1, 3, 9, 8, 6, 7 };
            numbers2.SkipWhile(n => n < 9).ShowInConsole();


        }
    }
}
