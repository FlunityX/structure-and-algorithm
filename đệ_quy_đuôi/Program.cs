namespace đệ_quy_đuôi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tongcuadayso = tongcuacacso(6, 0);
            Console.WriteLine("tong cua day so la :" + tongcuadayso);
            Console.ReadLine();
        }

        static int tongcuacacso(int n, int acc)
        {
            if (n <= 0)
            {
                return acc;
            }
            //Là một dạng đặc biệt của đệ quy.
            //Khi một hàm gọi chính nó ở dạng cuối cùng của nó, tức là không có thêm bất kỳ xử lý nào sau khi gọi đệ quy.
    // giúp trình biên dịch tối ưu hóa bằng cách loại bỏ các frame của hàm đệ quy khỏi ngăn xếp(stack), giảm bớt sự tiêu tốn bộ nhớ.
            return n + tongcuacacso(n - 1, acc +n );
            //  6 thì return 6+(5,6)
            //  5 thì return 6+5+(4,11)
            //  4 thì return 6+5+4+(3,15)
            //...
            // 0  xuất ra acc = 6+5+4+3+2+1+ tongcuacacso (0,21) =42

        }
    }
}
