using System.Diagnostics;
using System.Reflection.Metadata;

namespace giai_thuat_sap_xep_noi_bot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" nhap so luong phan tu trong mang :");
            int n = int.Parse(Console.ReadLine());
            int[] mang = new int[n];
            Console.WriteLine(" mang truoc khi sap xep noi bot la :");
            nhapmang(mang);
            giaithuatsapxepnoibot(mang);
            Console.WriteLine(" mang sau khi sap xep noi bot la : ");
            inthongtinmang(mang);
            Console.ReadLine();
        }
        static void nhapmang(int[] mang)
        {
            for(int i = 0; i < mang.Length; i++)
            {
                Console.WriteLine("nhap phan tu thu {0} :",i+1);
                mang[i] = int.Parse(Console.ReadLine());
            }
            
        }
        static void inthongtinmang(int[] mang)
        {
            int n= mang.Length;
            for (int i =0; i < n; i++)
            {
                Console.WriteLine(mang[i]+" ");
               
            }
        }
        static void giaithuatsapxepnoibot(int[]mang)
        {
            int n = mang.Length;
            // i = " mảng còn nguyên " , j là mảng cần sắp xếp phía sau lấy phần tử đầu rồi nên đk j là : n-i-1 
            for (int i =0; i<n-1; i++)
            {
                for(int j= 0; j < n-i-1; j++)
                {
                    // Đổi chỗ phần tử nhỏ nhất với phần tử đầu tiên của mảng chưa được sắp xếp
                    if (mang[j] > mang[j + 1]) {
                        int temp = mang[j];
                        mang[j] = mang[j + 1];
                        mang[j + 1] = temp;
                            }
                }
            }

        }
    }
}