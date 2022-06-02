﻿using System;
using System.Linq;

namespace GenerationOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //        < Query Kind = "Statements" >

            //< Reference > &lt; RuntimeDirectory & gt;\System.Drawing.dll </ Reference >

            //      < Namespace > System.Drawing </ Namespace >
            //    </ Query >

            Console.WriteLine(Enumerable.Empty<int>());

            Console.WriteLine(Enumerable.Repeat("hello", 3));

            Console.WriteLine(Enumerable.Range(1, 10));
            Console.WriteLine(Enumerable.Range('a', 'z' - 'a').Select(c => (char)c));
            Console.WriteLine(Enumerable.Range(1, 10).Select(i => new string('x', i)));
        }
    }
}
