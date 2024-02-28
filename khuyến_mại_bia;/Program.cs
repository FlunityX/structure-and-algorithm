using System;

namespace khuyến_mại_bia_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập số chai bia ban đầu anh ấy mua: ");
            int n = int.Parse(Console.ReadLine());
            sobia(n);
            Console.ReadLine();
        }

        static void sobia(int n)
        {
            int solgthuong = n % 10;
            int tongChaiBia = n + ((n / 10) * 3);
            Console.WriteLine("Tất cả số bia là: " + tongChaiBia);
        }
    }
}
