using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace đếm_mảng
{
    //Cho mảng số nguyên có phần tử A phần tử .Hãy đếm xem mảng này có bao nhiêu phần tử có giá trị bằng với số nguyên đã nhập
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap so lg phan tu ");
            int n = int.Parse(Console.ReadLine());  
            int[] a = new int[n];
            Console.WriteLine("nhap so muon tim trong mang ");
            int target = int.Parse(Console.ReadLine());
            nhapphantu(a);
            int solanxuathien = demphantu(a, target);
            Console.WriteLine("so lan xuat hien cua mang do la : " + solanxuathien);
            Console.ReadLine();
        }
       static void nhapphantu(int[]a)
        {
            for(int i = 0;i< a.Length;i++)
            {
                Console.WriteLine("nhap phan tu thu {0} " , i+1);
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static int demphantu(int[] a, int target)
        {
            int count = 0;
            for(int i=0;i< a.Length; i++)
            {
                if (a[i] == target)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
