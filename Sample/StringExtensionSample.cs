using System;
using System.Collections.Generic;
using System.Linq;
using SharpTool.Factory;
using SharpTool.Diagnostics;
using static SharpTool.Extension.CollectionExtention;
using static SharpTool.Extension.StringExtension;

namespace Sample
{
    public class StringExtensionSample
    {
        internal static void Sample()
        {
            string test = "BBBB";
            if (test.AnyOne("AAAA", "BBBB", "CCCC"))
            {
                Console.WriteLine($"{test} is match!");
            }
            if (test.AnyOne("DDD", "BBB", "HHHH"))
            {
                Console.WriteLine($"{test} is match!");
            }
            else
            {
                Console.WriteLine($"{test} is unmatch!");
            }

            List<string> list = new() { "aaa", "bbb", "ccc" };
            Console.WriteLine(list.ToString());
            if (list.Any("bbb"))
            {
                Console.WriteLine($"'bbb' list is match!");
            }
            if (!list.Any("ddd"))
            {
                Console.WriteLine($"'ddd' list is unmatch!");
            }

            List<string> bigList = new(10000000);
            string id = GuidFactory.GenerateLabel();
            for (int i = 0; i < 10000000; i++)
            {
                bigList.Add(id);
            }

            Console.WriteLine();

            using (new Performance())
            {
                if (bigList.All(id))
                {
                    Console.WriteLine($"match!");
                }
                else
                {
                    Console.WriteLine($"unmatch!");
                }
            }

            using (new Performance())
            {
                if (bigList.ParallelAll(id))
                {
                    Console.WriteLine($"match!");
                }
                else
                {
                    Console.WriteLine($"unmatch!");
                }
            }
        }
    }
}
