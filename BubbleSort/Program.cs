using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 3, 0, 2, 5, -1, 4, 1 };
            Console.WriteLine("Original array :");
            foreach (int aa in a)
                Console.Write(aa + " ");
            BubblerSortMethod(a);

            Console.WriteLine("Sorted array :");
            foreach (int aa in a)
                Console.Write(aa + " ");

            Object obj = new Object();
        }

        private static void BubblerSortMethod(int[] a)
        {
            int t;
            for (int i = 0; i < a.Length-1; i++)
            {
                for (int j = 0; j < a.Length - 1 ; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        t = a[j + 1];
                        a[j + 1] = a[j];
                        a[j] = t;
                    }
                }
            }
        }
    }
}
