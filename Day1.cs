using System;
using System.Collections.Generic;

namespace AdventOfCode
{
    class Day1
    {

        private static string filePath = @"C:\Users\Z004M7NZ\source\repos\adventOfCode\data\day1.txt";
        private static List<List<int>> lines = Preproccesor.FileToIntList(filePath);
        public static void Part1()
        {
            var count = 0;
            for (var i = 0; i < lines.Count - 1; ++i)
            {
                if (lines[i][0] < lines[i + 1][0])
                {
                    ++count;
                }
            }
            Console.WriteLine(count);
        }   
        public static void Part2()
        {
            var count = 0;
            for (var i = 1; i < lines.Count - 2; ++i)
            {
                var window1 = lines[i - 1][0] + lines[i][0] + lines[i + 1][0];
                var window2 = lines[i][0] + lines[i + 1][0] + lines[i + 2][0];
                if (window1 < window2)
                {
                    ++count;
                }
            }
            Console.WriteLine(count);
        }
    }

}
