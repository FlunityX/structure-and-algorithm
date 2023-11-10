using System.Text;
namespace mang_1_chieu
{
    internal class Program
    {
        
       /* Nhập từ bàn phím mảng số nguyên gồm n phần tử.Hãy nhập, xuất các phần tử trong mảng.

      Ví dụ:

      nhập n = 5       1   5   6   7   4 

      xuất  1   5   6   7   4 */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("nhập n");
            int n = int.Parse(Console.ReadLine());
            int[] so = new int[n];
            Console.WriteLine("Nhập các phần tử trong mảng: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Phần tử {0}: ",i+1);
                so[i] = int.Parse(Console.ReadLine());
            }
            foreach (var item in so)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}