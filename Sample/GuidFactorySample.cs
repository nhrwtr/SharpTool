using System;
using SharpTool.Factory;

namespace Sample
{
    internal class GuidFactorySample
    {
        public static void Show(int max = 10)
        {
            for (int i = 0; i < max; i++)
            {
                Console.WriteLine($"{i}: {GuidFactory.Generate()}");
            }
        }
    }
}
