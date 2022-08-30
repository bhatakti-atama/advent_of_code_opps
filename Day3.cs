using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode
{
    class Day3 : Day
    {
        static string filePath = DirectoryPath + "day3.txt";
        List<string[]> lines = Preproccesor.FileToStringList(filePath);

        public override void Part1()
        {
            var totalLines = 0;
            var numZero = new int[lines[0][0].Length];
            foreach(var line in lines)
            {
                for( var i = 0; i < line[0].Length; ++i)
                {
                    if( line[0][i] == '0')
                    {
                        numZero[i] += 1;
                    }
                }
                ++totalLines;
            }
            string gammaRate = "";
            string epsilonRate = "";
            foreach(var bit in numZero)
            {
                if( bit > (totalLines - bit))
                {
                    gammaRate += "0";
                    epsilonRate += "1";
                }
                else
                {
                    gammaRate += "1";
                    epsilonRate += "0";
                }
            }
            var output = Convert.ToInt32(gammaRate, 2) * Convert.ToInt32(epsilonRate, 2);
            Console.WriteLine(output);
        }
        public override void Part2()
        {
            var current = lines;
            var next = new List<string[]>();
            var pointer = 0;
            while(current.Count != 1)
            {
                var totalLines = 0;
                var numZero = 0;
                foreach(var line in current)
                {
                    if(line[0][pointer] == '0')
                    {
                        ++numZero;
                    }
                    ++totalLines;
                }
                ++pointer;
                char bit = numZero > (totalLines - numZero) ? '0' : '1';
                foreach(var line in current)
                {
                    if(line[0][pointer] == bit)
                    {
                        next.Add(line);
                    }
                }
                current = next;
                next = new List<string[]>();
            }
            Console.WriteLine(current[0][0]);
            current = lines;
            next = new List<string[]>();
            pointer = 0;
            while (current.Count != 1)
            {
                var totalLines = 0;
                var numZero = 0;
                foreach (var line in current)
                {
                    if (line[0][pointer] == '0')
                    {
                        ++numZero;
                    }
                    ++totalLines;
                }
                ++pointer;
                char bit = numZero <= (totalLines - numZero) ? '0' : '1';
                foreach (var line in current)
                {
                    if (line[0][pointer] == bit)
                    {
                        next.Add(line);
                    }
                }
                current = next;
                next = new List<string[]>();
            }
            Console.WriteLine(current[0][0]);
        }
    }
}
