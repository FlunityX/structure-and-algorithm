using System.Collections;

namespace Arraylist
{
    internal class Program
    {
        // là 1 mảng động trong c#
        static void Main(string[] args)
        {
          ArrayList my = new ArrayList();
            my.Add(1);
            my.Add(2);
            my.Add(3);
            my.Add("hello");
            my[3] = 4;
            foreach (int i in my)
            {
                Console.WriteLine("key :{0} " ,i);
            }
         Console.WriteLine("so luong phan tu la :{0}" ,my.Count);
           Console.ReadLine();
        }
    }
}
