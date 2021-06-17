using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace CApp
{
    class Program
    {
        static string path = "";
        
        static void Main(string[] args)
        {
            // string path = Directory.GetCurrentDirectory();
            // string path = System.AppDomain.CurrentDomain.BaseDirectory;
            // // Console.WriteLine(path);
            // var tmp = File.ReadLines(path + "/check.txt");
            //
            // List<string> list = new List<string>();
            //
            // foreach (var line in tmp)
            // {
            //     // Console.WriteLine(line);
            //     list.Add(line);
            // }

            
            
            if (args.Length > 0)
            {
                path = args[0];
            }

            List<string> list = ReadTestInput(path);
            List<int> resutl = AplusPowB(list);
            WriteToOutputfile(path, resutl);
            
        }


        static List<string> ReadTestInput(string path)
        {
            if (path.Length <= 0)
            {
                return new List<string>();
            }
            var tmp = File.ReadLines(path);
            List<string> list = new List<string>();
            foreach (var line in tmp)
            {
                list.Add(line);
            }
            return list;
        }

        static void WriteToOutputfile(string path, List<int> list)
        {
            // string path = System.AppDomain.CurrentDomain.BaseDirectory;

            if (path.Length <= 0)
            {
                return;
            }
            
            string outPath = Regex.Replace(path, @"(.*)(input)(\d+\.txt)", "$1output$3");
            Console.WriteLine(outPath);
            using (StreamWriter writer = new StreamWriter(outPath))
            {
                foreach (var res in list)
                {
                    writer.WriteLine(res);
                }
                writer.Close();
            }

        }

        static List<int> AplusPowB(List<string> list)
        {
            List<int> resultList = new List<int>();

            foreach (var s in list)
            {
                int[] nums = Array.ConvertAll(s.Split(' '), m => int.Parse(m));
                resultList.Add((int) (nums[0] + Math.Pow(nums[1], 2)));
            }
            
            // Console.WriteLine(string.Join(" " , resultList));
            string path = Directory.GetCurrentDirectory();
            // string path = System.AppDomain.CurrentDomain.BaseDirectory;
            // using (StreamWriter writer = new StreamWriter(path + "/output.txt"))
            // {
            //
            //     foreach (var res in resultList)
            //     {
            //         writer.WriteLine(res);
            //         
            //     }
            //     writer.Close();
            // }

            return resultList;
        }
    }
}