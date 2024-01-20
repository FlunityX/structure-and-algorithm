using System;
using System.Collections;
namespace hashtable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable hash = new Hashtable();
            hash.Add(1, "e");
            hash.Add(2, "d");
            hash.Add(3, "g");
            Console.WriteLine("so phan t cua hash la "+hash.Count);
            foreach(DictionaryEntry a in  hash)
            {
                Console.WriteLine("key {0} , value {1}" ,a.Key,a.Value);
            }
            Console.ReadLine();
        }
    }
}
