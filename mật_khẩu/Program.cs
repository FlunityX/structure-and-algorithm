namespace mật_khẩu
{
    internal class Program
    {
        /* Nam thường xuyên tham gia thi lập trình trên mạng.
         * Vì đạt được thành tích cao nên Nam được gửi tặng một phần mềm diệt virus. 
         * Nhà sản xuất phần mềm cung cấp cho Nam một mã số là một số nguyên dương N có không quá 255 chữ số.
         * Để cài đặt được phần mềm, Nam phải nhập vào mật khẩu của phần mềm. 
         * Mật khẩu là một số nguyên dương M được tạo ra bằng cách tính tổng giá trị các chữ số của N.*/
        static void Main(string[] args)
        {
            Console.WriteLine("nhap so mat khau : ");
            int n = int.Parse(Console.ReadLine());
            int simpleSum = CalculateSimpleSum(n);
            Console.WriteLine("mk của {0} là: {1}", n, simpleSum);
        }
        static int CalculateSimpleSum(int n)
        {
            // đặt 1 biến sum = 0
            int sum = 0;

            while (n > 0)
            {
                // nếu  n > 0 sum là số dư của số đó  
                sum += n % 10;
                // n tiếp để đệ uy là số chia nguyên cho 10 
                n /= 10;
            }
            return sum;
        }
    }
}
