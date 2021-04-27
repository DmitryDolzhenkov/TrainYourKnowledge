using System;

namespace InternalDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int, int> op;
            op = Add;
            Operation(60, 5, op);
            op = Substract;
            Operation(60, 5, op);
        }
        static void Operation(int x1, int x2, Action<int, int> op)
        {
            if (x1 > x2)
            {
                op(x1, x2);
            }
        }
        static void Add (int x, int y)
        {
            Console.WriteLine("Сумма чисел: " + (x + y));
        }
        static void Substract(int x, int y)
        {
            Console.WriteLine("Сумма чисел: " + (x - y));
        }
    }
}
