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

            var collectionstr = new MyCollection<string>();
            collectionstr.Add("sdt");
            collectionstr.Add("dd");
            collectionstr.Add("dd");
            collectionstr.Add("dddd");
            collectionstr.Add("dddd");
            string j = collectionstr.Data[1];
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }

            var myenumerator = collectionstr.GetEnumerator();
            while (myenumerator.MoveNext())
            {
                Console.WriteLine(myenumerator.Current);
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

        public void Reset()
        {
            _pointer = -1;
        }
    }
}
