namespace de_quy_fi_bo_na_cci
{
    internal class Program
    {
        /*Bài tập 4: Viết chương trình đệ quy tìm n số Fibonacci đầu tiên trong C#. Số nguyên dương n được nhập từ bàn phím. 
         * Biết: Quy luật của dãy số Fibonacci: số tiếp theo bằng tổng của 2 số trước, 2 số đầu tiên của dãy số là 0, 1. */
        static void Main(string[] args)
        {
            Console.WriteLine("nhap n");
            int n=int.Parse(Console.ReadLine());
            int ketqua =  fibo(n);
            Console.WriteLine("ket qua :" + ketqua);
            Console.ReadLine();
        }
        static int fibo(int n)
        {
            if (n<3)
                return 1;
            return fibo(n - 1) + fibo(n - 2);
            
        } 
    }
}