namespace tao_hinh_tam_giac_bang_dau_sao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap so dong chua tam giac ");
            int n = int.Parse(Console.ReadLine());
            for (int i= 1; i < n; i++)
            {
                string spaces = new string(' ', n - i);
                string star = new string('*' ,2 * i- 1);
                Console.WriteLine(spaces+star);

            }
            Console.ReadLine();
        }
    }
}