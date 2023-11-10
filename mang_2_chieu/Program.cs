using System.Dynamic;
using System.Reflection.Metadata;

namespace mang_2_chieu
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("nhap n :");
            int n =int.Parse(Console.ReadLine());
            int[,] mang2chieu = new int[n, n];
            for (int i = 0; i < mang2chieu.GetLength(0); i++)
            {
                for (int j = 0; j < mang2chieu.GetLength(0); j++)
                {
                    Console.WriteLine("phan tu thu [{0},{1}]", i,j);
                    mang2chieu[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < mang2chieu.GetLength(0); i++)
            {
                for (int j = 0; j < mang2chieu.GetLength(1); j++)
                {
                    Console.WriteLine("Phan tu tai [{0},{1}]: {2}", i, j, mang2chieu[i, j]);
                }
            }
            Console.ReadLine();
        }
    }
}