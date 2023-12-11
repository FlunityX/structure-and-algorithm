using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vẽ_hình_chữ_nhật_dấu_sao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap so hang so cot hinh chu nhat  ");
            int n = int.Parse(Console.ReadLine());
            string [,] mang = new string [n, n];
            trinhbaymatran(mang);
            inhinhchunhat(mang);
            Console.ReadLine();
        }
        static void trinhbaymatran(string [,]mang)
        {
            for(int i =0;i< mang.GetLength(0);i++)
            {
                for (int j = 0; j < mang.GetLength(1); j++)
                {
                    mang[i, j] =  "*" ;
                }
            }
        }
        static void inhinhchunhat(string[,] mang)
        {
            Console.BackgroundColor=ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < mang.GetLength(0); i++)
            {
                for (int j = 0; j < mang.GetLength(1); j++)
                {
                    Console.Write(mang[i,j] );
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }
    }
}
