using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tìm_số_lớn_nhất_trong_mảng
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap so luong n phan tu trong mang :");
            int n = int.Parse(Console.ReadLine());
            int[] mang = new int[n];
            nhapphantu(mang);
            int solonnhat =timsolonnhat(mang);
            Console.WriteLine("so lon nhat trong mang la : "+solonnhat);
            Console.ReadLine();
        }
        static void nhapphantu(int[] mang)
        {
            for (int i = 0; i < mang.Length; i++)
            {
                Console.Write("nhap phan tu thu {0} : ", i + 1);
                mang[i] = int.Parse(Console.ReadLine());
            }
        }
        static int timsolonnhat(int[] mang)
        {
            int max = mang[0];
            for (int i = 1; i < mang.Length; i++)
            {
                if (mang[i] > max)
                {
                    max = mang[i];
                }
            }
            return max;
        }
    }
}
