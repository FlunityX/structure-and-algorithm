namespace giai_thuat_sap_xep_chon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap so luong phan tu trong mang :");
            int n = int.Parse(Console.ReadLine());
            int []  b = new int[n];
            Console.WriteLine(" nhap mang chua qua sap xep ");
            nhapmangb(b);
            giaithuatchon(b);
            Console.WriteLine(" mang da qua sap xep la :");
            PrintArray(b);
            Console.ReadLine();

        }
        static void nhapmangb(int[] b)
        {
            int n = b.Length;
            for (int i=0; i<n; i++)
            {
                Console.WriteLine("nhap phan tu thu {0} :", i );
                b[i] = int.Parse(Console.ReadLine());
            }
        }
        static void giaithuatchon(int[] b)
        {
            int n = b.Length;
           
            for(int  i=0; i < n-1; i++)
            {
                int minindex = i;
                for (int j=i+1; j<n; j++)
                {
                    if (b[j] < b[minindex])
                    {
                        minindex = j;
                        
                    }
                    // hoán đổi vị trí 
                    int temp = b[minindex];
                    b[minindex] = b[i];
                    b[i] = temp;
                }
            }
        }
        static void PrintArray(int[] b)
        {
            int n = b.Length;
            foreach (var item in b)
            {
                Console.WriteLine(item + " ");
            }
        }
    }
}