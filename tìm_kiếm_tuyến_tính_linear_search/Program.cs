

namespace tìm_kiếm_tuyến_tính_linear_search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" nhap so luong phan tu trong mang :");
            int n = int.Parse(Console.ReadLine());
            int[] mang = new int[n];
            nhapgiatrimang(mang);
            Console.WriteLine("nhap phan tu can tim :");
            int target = int.Parse(Console.ReadLine());
            int timkiem = timkiemtuyentinh(mang, target);
            if (timkiem > 0)
            {
                Console.WriteLine("phan tu can tim o vi tri thu :" + timkiem + " trong mang ");
            }
            else Console.WriteLine("khong tim thay phan tu can tim trong mang tren ");
            Console.ReadLine();
        }
        public static void nhapgiatrimang(int[] mang)
        {
            for (int i = 0; i < mang.Length; i++)
            {
                Console.WriteLine("nhap phan tu thu {0} ", i + 1);
                mang[i] = int.Parse(Console.ReadLine());
            }
        }
    // tìm kiếm nếu thấy thì target đứng vị trí i ; không thì trả về 1 
        public static int timkiemtuyentinh(int[] mang , int target)
        {
            for (int i = 0;i<mang.Length;i++)
            {
                if (mang[i] == target)
                {
                    return  i;
                }
            }
            return  -1;
        }
    }
}