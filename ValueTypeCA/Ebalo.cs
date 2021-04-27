using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypeCA
{
    public class Ebalo
    {
        public string S { get; set; }
        public int I { get; set; }
        public Ebalo(string str, int i)
        {
            S = str;
            I = i;
        }
        public override int GetHashCode()
        {
            int prime = 31;
            int result = 1;
            result = prime * result + ((S == null) ? 0 : S.GetHashCode());
            result = prime * result + (I.GetHashCode());
            //result = prime * result + Arrays.hashCode(lastName);
            return result;
        }

        public override bool Equals(Object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else {
                Ebalo e = (Ebalo)obj;
                return (S == e.S) && (I == e.I);
            }
        }
    }
}
