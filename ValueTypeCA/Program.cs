using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypeCA
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ebalo> listofEbalos = new List<Ebalo>();
            ParseListofebalos(listofEbalos);
            LinkedList<string> listofstr = new LinkedList<string>();
            ParseListofstr(listofstr);

            Ebalo eblo = new Ebalo("ebalo", 5);
            Ebalo eblo2 = new Ebalo("ebalo", 5);
            if (eblo2.GetHashCode() == eblo.GetHashCode())
            {
                bool same = eblo.Equals(eblo2);
            }
            Type type = eblo.GetType();

            char[] value = "second".ToCharArray();
            String str3 = new String("second".ToCharArray());
            String str4 = "second";
            int i = str3.GetHashCode();
            int i2 = str4.GetHashCode();
            //UpdateString(ref );
            UpdateObject(eblo);
            string str = "ebalo";
            object obj1 = str;
            char[] strarr = str.ToCharArray();
            //UpdateString(ref str);
            UpdateString(ref obj1);
            UpdateString(strarr);
            UpdateStr(str3);
            Console.WriteLine(str3);
            //Console.WriteLine(obj1);
            //Console.WriteLine(strarr);
            //Console.WriteLine(eblo.S);
            //Console.WriteLine(eblo.I);
            Console.ReadKey();
        }

        private static void ParseListofstr(LinkedList<string> listofstr)
        {
            Ebalo eblo1 = new Ebalo("ebalo", 5);
            Ebalo eblo2 = new Ebalo("ebalo", 15);
            Ebalo eblo3 = new Ebalo("ebalo", 15);
            listofstr.AddFirst("ebalo");
            listofstr.AddLast("ebalo1");
            listofstr.AddLast("ebalo2");
        }

        private static void ParseListofebalos(List<Ebalo> listofEbalos)
        {
            Ebalo eblo1 = new Ebalo("ebalo", 5);
            Ebalo eblo2 = new Ebalo("ebalo", 15);
            Ebalo eblo3 = new Ebalo("ebalo", 15);
            listofEbalos.Add(eblo1);
            listofEbalos.Add(eblo2);
            listofEbalos.Add(eblo3);
        }

        private static void UpdateObject<T>(T eblo)
        {
            Ebalo eb = eblo as Ebalo;
            eb.S = "zakroi ebalo";
            eb.I = 25;
        }
        private static void UpdateObject(Ebalo eblo)
        {
            Ebalo eblo2 = eblo;
            //Ebalo eblo2  = new Ebalo("naxui idi", 888);

            eblo2.S = "str+";
            eblo2.I = 22;
        }
        private static void UpdateString(ref string str)
        {
            string s = str + " " + "zakroi";
            str = s;
        }

        private static void UpdateStr(String str)
        {
            string s = str + " " + "zakroi";
            str = s;
        }

        private static void UpdateString(ref object str)
        {
            string s = str + " " + "zakroi";

            str = s;
        }

        private static void UpdateString(char[] str)
        {
            char[] s =
            {
                'z', 'a'
            };

            str = s;
        }
    }
}
