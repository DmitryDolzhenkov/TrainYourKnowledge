using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class ArrayCollection<T>
    {
        public T[] Array { get; set; }
        //public U value;

        public ArrayCollection()
        {
            Array = new T[0];
        }
        public void AddValue(T value)
        {
            T[] a = new T[Array.Length+1];
            for (int i = 0; i < Array.Length; i++)
            {
                a[i] = Array[i];
            }
            a[a.Length - 1] = value;
            Array = a;
        }
        public int GetLength()
        {
            return Array.Length;
        }
        public T GetValueByIndex(int i)
        {    
            return Array[i]; 
        }

        public bool Contains(T value)
        {
            bool contains = false;
            for (int i = 0; i < GetLength(); i++)
            {
                if (value.Equals(GetValueByIndex(i))) return true;
            }
            return contains;
        }
        public void Remove(T value)
        {
            if (Contains(value))
            {
                T[] a = new T[Array.Length - 1];
                int j = 0;
                for (int i = 0; i < Array.Length; i++)
                {
                    if (!value.Equals(GetValueByIndex(i)))
                    {
                        a[j] = Array[i];
                        j++;
                    } 
                }
                Array = a;
            }
        }
    }
}
