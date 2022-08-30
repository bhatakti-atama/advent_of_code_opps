using System;
using System.Collections.Generic;
using System.IO;

namespace AdventOfCode
{
    class Preproccesor
    {
        public static List<string[]> FileToStringList(string filePath)
        {
            var lines = new List<string[]>();
            foreach (var line in File.ReadLines(filePath))
            {
                lines.Add(line.Split(' '));
            }
            return lines;
        }

        public static List<List<int>> FileToIntList(string filePath)
        {
            var lines = FileToStringList(filePath);
            var intLines = new List<List<int>>();
            foreach(var line in lines)
            {
                var temp = new List<int>();
                foreach(var element in line)
                {
                    temp.Add(int.Parse(element));
                }
                intLines.Add(temp);
            }
            return intLines;
        }
    }
}
