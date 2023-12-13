using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace số_đặc_biệt
{
    // số đặc biệt gồm 2 yếu tố :
    // nó là số nguyên tố 
    // tổng các chữ số là số nguyên tố 
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap n ");
            int n = int.Parse(Console.ReadLine());
            bool ndacbiet =nlasonguyento(n);
            int m = sodongian(n);
            bool mdacbiet =mlasonguyento(m);
            xacdinhsodacbiet(ndacbiet,mdacbiet);
            Console.ReadLine();

        }
        static bool nlasonguyento(int n)
        {
            if(n <2) {
                Console.WriteLine("n la so dac biet vi nó va tong cua no deu la so nguyen to");
                return true;
            }
            else
                for (int  i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
            return true;
        }
        static int sodongian(int n)
        {
            int sum = 0;
            while(n>0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }
        static bool mlasonguyento(int m)
        {
            if (m < 2)
            {
                Console.WriteLine("m la so dac biet vi nó va tong cua no deu la so nguyen to");
                return true;
            }
            else
                for (int i = 2; i <= Math.Sqrt(m); i++)
                {
                    if (m % i == 0)
                    {
                        return false;
                    }
                }
            return true;
        }
        static void xacdinhsodacbiet(bool ndacbiet ,bool mdacbiet)
        {
            if (ndacbiet == true && mdacbiet == true)
            {
                Console.WriteLine("yes");
            }
            else Console.WriteLine("no");
        }
    }
}
