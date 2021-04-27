using System;
using System.Collections.Generic;

namespace ForeachnMyEnum
{
    class Program
    {
        static void Main(string[] args)
        {

            var collection = new MyCollection<int>();
            collection.Add(1); 
            collection.Add(2);
            collection.Add(3);
            collection.Add(4);
            collection.Add(5);
            int i = collection[1];

            var collection1 = new MyCollection<string>();
            collection1.Add("sdt");
            collection1.Add("dd");
            collection1.Add("dd");
            collection1.Add("dddd");
            collection1.Add("dddd");
            string j = collection1.Data[1];
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
    public class MyCollection<T>
    {
        public List<T> Data = new List<T>();
        public T this[int index] => Data[index];
        public void Add(T element)
        {
            Data.Add(element);
        }
        public MySupperEnumerator<T> GetEnumerator()
        {
            return new MySupperEnumerator<T>(this);
        }

    }
    public class MySupperEnumerator<T>
    {
        private MyCollection<T> _myCollection;
        private int _pointer = -1;

        public MySupperEnumerator(MyCollection<T> collection)
        {
            _myCollection = collection;
        }
        public T Current => _myCollection[_pointer];
        public bool MoveNext() => ++_pointer < _myCollection.Data.Count;


    }

}
