using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesEventsLyambda
{
    class Program
    {
        delegate void Message();
        delegate void GetMessage();

        delegate int Operation(int x, int y);

        delegate T GenericOperation<T, Z, K>(Z x, K y);


        static void Main(string[] args)
        {
            GenericOperation<int, double, double > goper = Calc;
            GenericOperation<int, int, int> goper1 = Multiply;

            GenericOperation<int, int, int> del = new GenericOperation<int, int, int>(Multiply);
            int? i = del?.Invoke(5, 5);
            if (DateTime.Now.Hour < 12)
            {
                Show_Message(GoodMorning);
            }
            else
            {
                Show_Message(GoodEvening);
            }
            //Message mes = Hello;
            //mes?.Invoke();
            //Operation op = Add;
            //int? result = op?.Invoke(3, 4);
            //Console.WriteLine(result);
            //op -= Add;
            //int? result2 =  op?.Invoke(5, 8);

            Console.ReadKey();
        }
        private static void Show_Message(GetMessage _del)
        {
            _del?.Invoke();
        }
        private static void Hello() { Console.WriteLine("Hello"); }

        private static int Add(int x, int y)
        {
            return x + y;
        }
        private static int Multiply(int x, int y)
        {
            return x * y;
        }
        private static int Calc(double x, double y)
        {
            return Convert.ToInt32(x * y);
        }
        private static void GoodMorning()
        {
            Console.WriteLine("Good Morning");
        }
        private static void GoodEvening()
        {
            Console.WriteLine("Good Evening");
        }
        class Math
        {
            public int Sum(int x, int y) { return x + y; }
        }
    }
}
