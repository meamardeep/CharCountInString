using System;
using System.Collections.Generic;
using System.Linq;

namespace CharCountInString
{
    class Program
    {
        static void Main(string[] args)
        {
            //var groupedResult = from s in studentList
            //                    group s by s.Age;
            //foreach (var item in groupedResult)
            //{
            //    Console.WriteLine(item.Key +"and "+ item.Count());
            //    foreach (var it in item)
            //    {
            //        Console.WriteLine(it.StudentID+" "+ it.StudentName);
            //    }
            //}

            string str = "amardeep";
            char[] str2 = str.Distinct().ToArray();

            IDictionary<char, int> dict = new Dictionary<char, int>();
            int count;
            foreach (var disctinctCharItem in str2)
            {
                count = 0;
                foreach (var strItem in str)
                {
                    if (disctinctCharItem == strItem)
                    {
                        count++;
                    }
                }
                dict.Add(disctinctCharItem, count);
            }

            foreach (var item in dict)
            {
                Console.WriteLine(item.Key + ":" + item.Value);
            }
            Console.ReadLine();

            //Or we can do the above implemetation in a single line using LinqQ method syntax.
            //var sql = str.GroupBy(c => c).Select(new { Char = c.Key, Count = c.count() });
        }
    }
}
