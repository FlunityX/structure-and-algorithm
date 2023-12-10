using System;

namespace biểu_diễn_đồ_thị_bằng_ma_trận_kề
{
    internal class Program
    {
        class Graph
        {
            private int[,] mang2chieu;
            private int dinh;

            public Graph(int dinh)
            {
                this.dinh = dinh;
                mang2chieu = new int[dinh, dinh];
            }
            // bool = false vô hướng và true là có hướng
            public void addcanh(int dinh1, int dinh2, bool cohuong)
            {
                if (cohuong = false)
                {
                    mang2chieu[dinh2, dinh1] = 1;
                    mang2chieu[dinh1, dinh2] = 1;
                }
                else mang2chieu[dinh1, dinh2] = 1;
            }
            public void indothi()
            {
                for (int i = 0; i < dinh - 1; i++)
                {
                    for (int j = 0; j < dinh - 1; j++)
                    {
                        Console.Write(mang2chieu[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
        static void Main(string[] args)
        {
            int dinh = 5;
            Graph dothi = new Graph(dinh);
            dothi.addcanh(1, 2, false);
            dothi.addcanh(2, 3, true);
            dothi.indothi()
            Console.ReadLine();
        }
    }
}