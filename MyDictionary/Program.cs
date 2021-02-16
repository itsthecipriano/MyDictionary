using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Members<int, string> myDictionary = new Members<int, string>();
            myDictionary.Add(1969, "Myles");
            myDictionary.Add(1965, "Saul");
            myDictionary.Add(1946, "Freddie");
            myDictionary.Add(1983, "Lzzy");

            myDictionary.Key(1995);
            myDictionary.Key(1966);
            myDictionary.Key(1955);
            myDictionary.Key(1988);

            Console.ReadLine();
        }
    }
}
