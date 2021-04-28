using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class Chore : IDolzhable
    {
        public Chore()
        {

        }

        public bool ISDolzhEndorseYou(object person)
        {
            throw new NotImplementedException();
        }
    }
    public struct Dolzh : IDolzhable
    {
        public string Poo;

        public bool ISDolzhEndorseYou(object person)
        {
            throw new NotImplementedException();
        }
    }
        
}
