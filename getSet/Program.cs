using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace getSet
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\Team\Saikat\getSet\Text.txt";

            List<string> texts = File.ReadAllLines(filePath).ToList();

            while (true)
            {
                Console.WriteLine("press 1 for add or 2 for show or other for exit");
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == 1)
                {
                    Console.WriteLine("Please write something:");
                    string add = Console.ReadLine();
                    texts.Add(add);
                }
                else if(input==2)
                {
                    foreach (string s in texts)
                    {
                        Console.WriteLine(s);
                    }
                }
                else
                {
                    break;
                }
            }
        }
    }
}

 