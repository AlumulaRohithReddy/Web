using System;
using System.Collections.Generic;
using System.Linq;
namespace Linqdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integerList = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };

            var filteredResult = integerList.Where(item => item%2==0);
            foreach (var item in filteredResult)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            var sortedDescendingResult = integerList.OrderByDescending(item =>item);
            foreach (var item in sortedDescendingResult)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            var groupedResult = integerList.GroupBy(n => n % 2 == 0 ? "Even" : "Odd");
            foreach (var group in groupedResult)
            {
                Console.WriteLine(group.Key);
                foreach (var num in group)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            var QuerySyntax = from obj in integerList
                              where obj > 5
                              select obj;

            foreach (var item in QuerySyntax)
            {
                Console.Write(item + " ");
            }
            integerList[2] = 10;
            Console.WriteLine();

            foreach (var item in QuerySyntax)
            {
                Console.Write(item + " ");
            }
            //Console.ReadKey();
        }
    }
}

