using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace danh_sach_liên_kết__dành__riêng_.NET_Framework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // tạo các thuộc tính cho linkedlist
            LinkedList<int> list = new LinkedList<int>();
            LinkedListNode<int> node1 = new LinkedListNode<int>(2);
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);     
            // các phần tử linked List
            foreach (var item in list)
            {
                Console.WriteLine(" GIA TRI DUYET DANG BTH "+item );
            }
            // xuất giá trị của node 
            Console.WriteLine("gia tri node la :"+ node1.Value);
            // Duyệt dạng xâu giá trị)
            LinkedListNode<int> node2 ;
            for (node2 = list.First; node2 != null; node2 = node2.Next)
            {
                Console.WriteLine(" GIA TRI QUA DUYET DANG XAU "+ node2.Value);
            }
            Console.ReadLine();
        }
    }
}