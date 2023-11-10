using System.Text;

namespace mang_1_chieu_level_2
{
    internal class Program
    {
        /*Bài tập mảng 1 chiều:
     1.xác định độ phức tạp thuật toán 
     2.Khởi tạo một mảng 1 chiều gồm 10 phần tử kiểu số nguyên và nhập giá trị cho các phần tử từ bàn phím.
     3.Hiển thị mảng vừa nhập ra màn hình.
     4.Tính tổng các phần tử trong mảng và hiển thị kết quả.
     5.Sao chép nội dung của mảng này vào một mảng khác.
     6.Nhập vào một giá trị số nguyên từ bàn phím, tìm kiếm giá trị này trong mảng và hiển thị vị trí nếu tìm thấy, hoặc thông báo không tìm thấy nếu không có trong mảng.
     7.đảo ngược thứ tự các phần tử trong mảng.
     8.Hiển thị mảng sau khi đã đảo ngược.
     9.Truy xuất và hiển thị giá trị của phần tử ở vị trí thứ 5 trong mảng.*/
        static void Main(string[] args)
        {
            
            // độ phức tạp là hằng số tức lặp 10 lần  big 0 = C;
            Console.OutputEncoding = Encoding.UTF8;
            int[] so =new int[10];
            for(int i =0; i < 10; i++)
                {
                Console.Write("phần tử thứ {0} : ", i + 1);
                so[i] =int.Parse(Console.ReadLine());
            }
            
            Console.Write("mảng đã nhập đó là :");
            foreach (var a in so)
            {
                Console.Write("\t " + a);
            }

            int tong = 0;
            Console.WriteLine("tổng các phần tử là :");
            {
                for (int i = 0; i < 10; i++)
                {
                    
                    tong = tong + so[i];
                    
                }
                Console.WriteLine(tong);
                
            }
            int[] mangA = new int[so.Length]; ;
            Array.Copy(so, mangA, so.Length);
            Console.Write("mảng đã copy đó là :");
            foreach (var a in mangA)
            {
                Console.Write("\t " + a);
            }
            Console.WriteLine("nhập số cần tìm :");
            int c = int.Parse(Console.ReadLine());
            Array.Sort(so);
            int vitricantim =Array.BinarySearch(so, c);
            if (vitricantim < 0 )
            {
                Console.WriteLine("ko có số cần tìm ");
            }
            else
            {
                Console.WriteLine(" số cần tìm ở vị trí số :" + vitricantim);
            }
           
            Array.Reverse(so);
            Console.Write("mảng đã đảo ngược đó là :");
            foreach (var a in so)
            {
                Console.Write("\t " + a);
            }
            int pt5 = so[4];
            Console.WriteLine("giá trị thứ 5 là " + pt5);
            Console.ReadLine();
        }
    }
}