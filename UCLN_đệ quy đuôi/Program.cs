using System;

namespace UCLN_de_quy_duoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ucln = UCLN(8, 4);
            Console.WriteLine("Uoc chung lon nhat la: " + ucln);
            Console.ReadLine();
        }

        static int UCLN(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            else
            {
                return UCLN(b, a % b);
            }
            // 8,4 thì b khác 0 => 4,0 => 4 
        }
    }
}