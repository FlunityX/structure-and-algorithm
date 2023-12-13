using System;

namespace tính_tổng_dãy_số
{
    internal class Program
    {
        // cho day so t(n) = n^2 + (n-1)^2  
        // S(n) = t(1) + t(2) + t(n) + ...
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập số n: ");
            int n = int.Parse(Console.ReadLine());
            double sum = tinhtong(n);
            Console.WriteLine("Tổng của dãy số là: {0}", sum);
            Console.ReadLine();
        }

        static double tinhtong(int n)
        {
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                double t = Math.Pow(i, 2) - Math.Pow(i - 1, 2);
                sum += t;
            }
            return sum;
        }
    }
}