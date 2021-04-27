using System;
using System.Collections.Generic;

namespace YieldTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            var sequance1 = DivideSequaence(0);
            Console.WriteLine("!!!");
            foreach (var item in sequance1)
            {
                Console.WriteLine(item);
            }
        }

        public static IEnumerable<int> DivideSequaence(int divider)
        {
            if (divider == 0) throw new ArgumentException();
            return IntDivideSeq(divider);
        }
        private static IEnumerable<int> IntDivideSeq(int divider)
        {
            for (int i = 10; i <= 50; i += 10)
            {
                yield return i / divider;
            }
        }
    }
}
