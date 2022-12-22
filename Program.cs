using System;
using System.Diagnostics;

namespace _13_6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "C:\\Users\\Kurkov_o\\Downloads\\Text1.txt";///путь к файлу
            string readText = File.ReadAllText(filePath);
            // Производительность вставки в обычный список
            var stopWatch1 = Stopwatch.StartNew();
            List<string> List = new List<string>();
            foreach (string line in readText.Split(new char[] { '\n', '\r', ' ' }))
            {
                List.Add(line);
            }
            Console.WriteLine(stopWatch1.Elapsed.TotalMilliseconds);

            // Производительность вставки в связанный список
            var stopWatch2 = Stopwatch.StartNew();
            LinkedList<string> LinkedList = new LinkedList<string>();
            foreach (string line in readText.Split(new char[] { '\n', '\r', ' ' }))
            {
                LinkedList.AddLast(line);
            }
            Console.WriteLine(stopWatch2.Elapsed.TotalMilliseconds);
            Console.ReadKey();
        }
    }
}