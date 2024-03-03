

namespace mang1chieutonghop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap n phan tu trong mang :");
            int n = int.Parse(Console.ReadLine());
            int[] mang = new int[n];
            nhapmang(mang);
            tongcacso(mang);
            solgsochan(mang);
            int songuyenmax = nguyenduongmax(mang);
            Console.WriteLine($"phan tu nguyen duong lon nhat la {songuyenmax}");
            Console.ReadLine();
        }

        static void nhapmang(int[] mang)
        {
            for (int i = 0; i < mang.Length; i++)
            {
                Console.WriteLine($"nhap phan tu thu {i + 1} :");
                mang[i] = int.Parse(Console.ReadLine());
            }
        }

        static void tongcacso(int[] mang)
        {
            int sum = 0;
            for (int i = 0; i < mang.Length; i++)
            {
                sum += mang[i];
            }
            Console.WriteLine($"tong cac so la : {sum}");
        }

        static void solgsochan(int[] mang)
        {
            int sochan = 0;
            for (int i = 0; i < mang.Length; i++)
            {
                if (mang[i] % 2 == 0)
                {
                    sochan++;
                }
            }
            Console.WriteLine($"tong so chan trong mang la {sochan}");
        }

        static int nguyenduongmax(int[] mang)
        {
            int max = 0;
            for (int i = 0; i < mang.Length; i++)
            {
                if (mang[i] > 0 && mang[i] > max)
                {
                    max = mang[i];
                }
            }
            return max;
        }
    }
}
