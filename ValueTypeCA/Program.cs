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
            List<Tabalo> listofTabalos = new List<Tabalo>();
            ParseListofTabalos(listofTabalos);
            LinkedList<string> listofstr = new LinkedList<string>();
            ParseListofstr(listofstr);

            Tabalo tablo = new Tabalo("Tabalo", 5);
            Tabalo tablo2 = new Tabalo("Tabalo", 5);
            if (tablo2.GetHashCode() == tablo.GetHashCode())
            {
                bool same = tablo.Equals(tablo2);
            }
            Type type = tablo.GetType();

            char[] value = "second".ToCharArray();
            String str3 = new String("second".ToCharArray());
            String str4 = "second";
            int i = str3.GetHashCode();
            int i2 = str4.GetHashCode();
            //UpdateString(ref );
            UpdateObject(tablo);
            string str = "Tabalo";
            object obj1 = str;
            char[] strarr = str.ToCharArray();
            //UpdateString(ref str);
            UpdateString(ref obj1);
            UpdateString(strarr);
            UpdateStr(str3);
            Console.WriteLine(str3);
            //Console.WriteLine(obj1);
            //Console.WriteLine(strarr);
            //Console.WriteLine(tablo.S);
            //Console.WriteLine(tablo.I);
            Console.ReadKey();
        }

        private static void ParseListofstr(LinkedList<string> listofstr)
        {
            Tabalo tablo1 = new Tabalo("Tabalo", 5);
            Tabalo tablo2 = new Tabalo("Tabalo", 15);
            Tabalo tablo3 = new Tabalo("Tabalo", 15);
            listofstr.AddFirst("Tabalo");
            listofstr.AddLast("Tabalo1");
            listofstr.AddLast("Tabalo2");
        }

        private static void ParseListofTabalos(List<Tabalo> listofTabalos)
        {
            Tabalo tablo1 = new Tabalo("Tabalo", 5);
            Tabalo tablo2 = new Tabalo("Tabalo", 15);
            Tabalo tablo3 = new Tabalo("Tabalo", 15);
            listofTabalos.Add(tablo1);
            listofTabalos.Add(tablo2);
            listofTabalos.Add(tablo3);
        }

        private static void UpdateObject<T>(T tablo)
        {
            Tabalo eb = tablo as Tabalo;
            eb.S = "zakroi Tabalo";
            eb.I = 25;
        }
        private static void UpdateObject(Tabalo tablo)
        {
            Tabalo tablo2 = tablo;
            //Tabalo tablo2  = new Tabalo("naxui idi", 888);

            tablo2.S = "str+";
            tablo2.I = 22;
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
