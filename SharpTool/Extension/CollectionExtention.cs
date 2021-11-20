using System;
using System.Collections.Generic;
using System.Linq;

namespace SharpTool.Extension
{
    public static class CollectionExtention
    {

        public static bool Any<T>(this IEnumerable<T> self, T target)
            where T : IComparable
        {
            foreach (var str in self)
            {
                if (str.CompareTo(target) == 0)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool All<T>(this IEnumerable<T> self, T target)
            where T : IComparable
        {
            foreach (var str in self)
            {
                if (str.CompareTo(target) != 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool ParallelAll<T>(this IEnumerable<T> self, T target)
            where T : IComparable
        {
            return self.AsParallel().All(x => x.CompareTo(target) == 0);
        }
    }
}
