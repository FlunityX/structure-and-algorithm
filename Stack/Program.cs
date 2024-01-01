using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // stack là ngăn xếp vào đầu ra cuối , vào cuối ra đầu 
            // sử dụng thư viện using System.Collections
            //Stack st = new Stack();
            // sử dụng thư viện using System.Collections.Generic;

            Stack<int > ints = new Stack<int>();
            // thêm phần tử dùng push
            ints.Push(1);
            ints.Push(2);
            ints.Push(3);
            // trả về đối tương cuối và ko xoá nó dùng peek.
            // trả về đối tương cuối và xoá dùng pop
            // số phần tử dùng Count 
            if (ints.Count > 0)
            {
                //int value = ints.Peek();
                //Console.WriteLine(value);
                ints.Pop();
            }
            
            // duyệt phần tử 
            foreach(int i in ints) {
                Console.WriteLine(i);
                
            }
            Console.ReadLine();

        }
    }
}
