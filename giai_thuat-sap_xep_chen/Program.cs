namespace giai_thuat_sap_xep_chen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" nhap so lg phan tu mang ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("nhap mang chua qua sap xep ");
            nhapmang(a);
            Console.WriteLine(" nhap mang da qua sap xep ");
            giaithuatsapxepchen(a);
            inthongtin(a);
        }
        static void giaithuatsapxepchen(int[] a)
        {
            int n = a.Length;
            for (int i = 1; i < n; i++)
            {
                int key = a[i];
                int j = i - 1;

                // Di chuyển các phần tử lớn hơn key về sau
                while (j >= 0 && a[j] > key)
                {
                    a[j + 1] = a[j];
                    j = j - 1;
                }

                a[j + 1] = key;
            }
        }

        static void nhapmang(int[] a)
            {
                int n = a.Length;
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(" nhap phan tu thu {0}", i + 1);
                    a[i] = int.Parse(Console.ReadLine());
                }
            }
            static void inthongtin(int[] a)
            {
                foreach (var item in a)
                {
                    Console.WriteLine(item + " ");
                }
            }

        }
    }



