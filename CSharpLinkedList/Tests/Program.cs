namespace CSharpLinkedList.Tests
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using CSharpLinkedList.Classes;

    public class Program
    {
        public static void Main(string[] args)
        {
            IReadOnlyCollection<string> testCases = new[] { "TestOne", "TestTwo" };

            foreach (string testName in testCases)
            {
                LinkedList list = new LinkedList();
                string fileaddress = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + $"\\Information\\{testName}.txt";

                foreach (string line in File.ReadLines(fileaddress))
                {
                    string[] lineInputs = line.Split(':');

                    Action<string> actionOnList = lineInputs[0] switch
                    {
                        "i" => (item) => list.Insert(item),
                        "d" => (item) => list.Delete(item),
                        _ => (item) => Console.WriteLine($"\'{item}\' was not either \'i\' or \'d\'."),
                    };

                    actionOnList(lineInputs[1]);
                }

                list.PrintAll();
                Console.ReadLine();
            }
        }
    }
}