using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> myDictionary = new MyDictionary<string>();
            myDictionary.Add("Gence");
            myDictionary.Add("Gence");
            myDictionary.Add("Gence");
            myDictionary.Add("Gence");
            Console.WriteLine(myDictionary.Count);
        }

        class MyDictionary<T>
        {
            T[] array;
            T[] temparray;

            public MyDictionary()
            {
                array = new T[0];
            }

            public void Add(T item)
            {
                temparray = array;
                array = new T[array.Length + 1];
                for (int i = 0; i < temparray.Length; i++)
                {
                    array = temparray;
                }
                array[array.Length - 1] = item;
            }
            public int Count
            {
                get { return array.Length; }

            }
        }
        
    }
}
