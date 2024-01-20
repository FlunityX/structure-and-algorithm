using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> td1 = new Dictionary<int, string>();
            td1.Add(1, "toan");
            td1.Add(2, "van");
            td1.Add(3, "anh");
            Console.WriteLine("so gia tri la :" + td1.Count);
            for (int i = 0; i < td1.Count; i++)
            {
                Console.WriteLine(td1.ElementAt(i).Key +"..."+td1.ElementAt(i).Value);
            }
            var result = td1.OrderByDescending(x => x.Key);
            foreach(KeyValuePair<int, string> kvp in result)
            {
                Console.WriteLine(kvp.Key + ": " + kvp.Value);
            }
            Console.ReadLine();
        }
    }
}
