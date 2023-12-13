using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bảng_cửu_chương
{
    internal class Program
    {
        // n*a với a bất kì
        // n,i mình tự nhập
        static void Main(string[] args)
        {
            Console.WriteLine("nhap n :");
            int n =int.Parse(Console.ReadLine());
            Console.WriteLine("nhap a :");
            int a =int.Parse(Console.ReadLine());
            int[,] mang = new int[n, a];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    // i <n , j<a nên công thức dưới đây :
                    // 1*1 =1 :-> ...
                    mang[i, j] = (i + 1) * (j + 1);
                }
            }
            Console.WriteLine("bang cuu chuong n cot a hang :  ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    Console.Write("{0} * {1} = {2}  ",i+1,j+1, mang[i,j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
