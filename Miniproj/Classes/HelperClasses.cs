using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;

namespace Miniproj
{
    public static class ThreadSafeRandom
    {
        [ThreadStatic]
        private static Random Local;

        public static Random ThisThreadsRandom
        {
            get { return Local ?? (Local = new Random(unchecked(Environment.TickCount * 31 + Thread.CurrentThread.ManagedThreadId))); }
        }
    }

    public static class HelperClasses
    {
        // Alla skiljetecken som räknas i SeparatorTest
        public const string Separators = ",.:;!?-";

        public static T GetRandom<T>(this IEnumerable<T> source)
        {
            return source.ElementAt(ThreadSafeRandom.ThisThreadsRandom.Next(source.Count()));
        }
        
        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = ThreadSafeRandom.ThisThreadsRandom.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}