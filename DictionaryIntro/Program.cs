using System;

namespace DictionaryIntro // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "Hello");
            Console.WriteLine(dictionary[1]);

            MyDictionary<int,string> myDictionary = new MyDictionary<int,string>();
            myDictionary.Add(1,"Hello");
            Console.WriteLine(myDictionary.Keys[0]);
            Console.WriteLine(myDictionary.Values[0]);
            
        }
    }

    class MyDictionary<T,U>
    {
        T[] _keyArray;
        U[] _valueArray;
        T[] _tempKeyArray;
        U[] _tempValueArray;
        public MyDictionary()
        {
            _keyArray = new T[0];
            _valueArray = new U[0]; 
        }
        public void Add(T key, U value)
        {
            _tempKeyArray = _keyArray;
            _tempValueArray = _valueArray;
            _keyArray = new T[_keyArray.Length + 1];
            _valueArray = new U[_valueArray.Length + 1];
            
            for (int i = 0; i < _tempKeyArray.Length; i++)
            {
                _keyArray[i] = _tempKeyArray[i];
                _valueArray[i] = _tempValueArray[i];
            }
            _keyArray[_keyArray.Length - 1] = key;
            _valueArray[_keyArray.Length - 1] = value;
        }

        public T[] Keys
        {
            get { return _keyArray; }
        }

        public U[] Values
        {
            get { return _valueArray; }
        }

    }
}