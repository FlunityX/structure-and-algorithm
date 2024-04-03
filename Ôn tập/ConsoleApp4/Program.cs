namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap n phan tu (n < 30) :");
            int n = int.Parse(Console.ReadLine());
            int[] mang = new int[n];
            nhapphantu(mang);
            // 1. duyet mang tu cuoi len dau 
            duyetphantu(mang);
            // 2. sắp xếp giá trị nhỏ nhất đến lớp nhất 
            bubblesort(mang);
            // 3.đảo mảng
            Reversearray(mang);
            Console.ReadLine();
        }
        static void nhapphantu(int[] mang)
        {
            for (int i = 0; i < mang.Length; i++)
            {
                Console.Write($"nhap phan tu thu {i + 1}: ");
                mang[i] = int.Parse(Console.ReadLine());
            }
        }
        static void duyetphantu(int[] mang)
        {
            Console.Write("mang da dc sap xep nguoc la :");
            for (int i = mang.Length - 1; i >= 0; i--)
            {
                Console.Write(mang[i] + " ");
            }
            Console.WriteLine();
        }
        static void bubblesort(int[] mang)
        {
            for (int i = 0; i < mang.Length; i++)
            {
                for (int j = 0; j < mang.Length - i - 1; j++)
                {
                    if (mang[j] > mang[j + 1])
                    {
                        int temp = mang[j];
                        mang[j] = mang[j + 1];
                        mang[j + 1] = temp;
                    }
                }
            }
            Console.Write("mang da duoc sap xep la :");
            foreach(var item in mang) 
            {
                Console.Write(item+"  ");
            }
            Console.WriteLine();
        }
        static void Reversearray(int[] mang)
        {
            Array.Reverse(mang);
            Console.Write("mang da duoc dao la :");
            foreach(var i in mang)
            {
                Console.Write(i + " ");
            }
        }
    }
}
