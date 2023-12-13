using System;

namespace DonGianSo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập số cần đơn giản: ");
            int n = int.Parse(Console.ReadLine());
            int simpleSum = CalculateSimpleSum(n);
            Console.WriteLine("Số đơn giản của {0} là: {1}", n, simpleSum);
        }
        static int CalculateSimpleSum(int n)
        {
            // đặt 1 biến sum = 0
            int sum = 0;

            while (n > 0)
            {
                // nếu  n > 0 sum là số dư của số đó  
                sum += n % 10;
                // n tiếp để đệ uy là số chia nguyên cho 10 
                n /= 10;
            }
            return sum;
        }
        // ví dụ 123 -> 12 dư 3 -> 12 đệ uy tiếp sum =3 -> 1 dư 2 -> dư 1 -> 6 
    }
}
