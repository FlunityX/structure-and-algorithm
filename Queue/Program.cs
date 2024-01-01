using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // vào trước ra trước , vào sau ra sau 
            // ko Dùng Generic mà chỉ dùng using System.Collections
            // Queue e = new Queue();
            // dùng using System.Collections.Generic;
            Queue<int> Queue_1 = new Queue<int>(new int[] {1,2,3,4,5});
            //enQueue thêm phần tử vào cuối hàng đợi 
            Queue_1.Enqueue(6);
            Queue_1.Dequeue();
            // deQueue xoá phần tử ở đầu hàng đợi 
            // peek trả về giá trị ở đầu hàng đợi 
            // int value = Queue_1.Peek();
            //Console.WriteLine(" phần tử cuối hàng đợi là :"+ value);
            // duyệt hàng đợi 
            foreach (int i in Queue_1)
            {
                Console.Write(i+",");
            }
            Console.ReadLine();


        }
    }
}
