using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode
{
    class Day2
    {
        private static string filePath = @"C:\Users\Z004M7NZ\source\repos\adventOfCode\data\day2.txt";
        private static List<string[]> lines = Preproccesor.FileToStringList(filePath);
        public static void Part1()
        {
            int depth = 0;
            int horizontalPostiton = 0;
            foreach(var line in lines)
            {
                int move = int.Parse(line[1]);
                if(line[0] == "up")
                {
                    depth -= move; 
                }
                if(line[0] == "down")
                {
                    depth += move;
                }
                if(line[0] == "forward")
                {
                    horizontalPostiton += move;
                }

            }
            Console.WriteLine(depth * horizontalPostiton);
        }
        public static void Part2()
        {
            int depth = 0;
            int horizontalPostiton = 0;
            int aim = 0;
            foreach (var line in lines)
            {
                int move = int.Parse(line[1]);
                if (line[0] == "up")
                {
                    aim -= move;
                }
                if (line[0] == "down")
                {
                    aim += move;
                }
                if (line[0] == "forward")
                {
                    horizontalPostiton += move;
                    depth += aim * move;
                }
            }
            Console.WriteLine(depth * horizontalPostiton);
        }
    }
}
