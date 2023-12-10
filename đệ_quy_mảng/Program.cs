using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace đệ_quy_mảng
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NHAP SO LUONG PHAN TU ");
            int n = int.Parse(Console.ReadLine());
            int[] mang = new int[n];
            nhapthongtinmang(mang);
            
            Console.WriteLine("cac phan tu trong mang ");
            xuatthongtinmang(mang);
            int ketqua = dequymang(mang, 0);
            Console.WriteLine(" tong cua cac phan tu " + ketqua);
            Console.ReadLine();
        }
        static void nhapthongtinmang(int[] mang) 
        {
            int a = mang.Length ;
            for(int i = 0 ; i < a ; i++)
            {
                Console.WriteLine("nhap phan tu thu {0}:" , i + 1);
                mang[i] = int.Parse(Console.ReadLine());
            }
        }
        static void xuatthongtinmang(int[] mang)
        {
            foreach (var item in mang)
            {
                Console.WriteLine(item+" ");
            }
        }
        static int dequymang(int[] mang,int demphantu)
        {
            // demphantu đang bằng 0 , 
            // đk đầu đúng nên mang[0] +dequymang(mang, 1)
            // nếu demphantu >= độ dài thì mặc định bằng 0 
            if (demphantu >= mang.Length)
            {
                return 0;
            }
            return mang[demphantu]+dequymang(mang, demphantu+1);
        }

    }
}
