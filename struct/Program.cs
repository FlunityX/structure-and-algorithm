using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace struct1
{
    internal class Program
    {
        /* KIỂU CẤU TRÚC
        Viết chương trình khai báo cấu trúc phân số và cài đặt các hàm thực hiện các phép tính: Cộng, Trừ, Nhân, Chia, Rút gọn 2 phân số*/
        struct phanso
        {
            public int tuso;
            public int mauso;
            public phanso(int tuso, int mauso)
            {
                this.tuso = tuso; this.mauso = mauso;
            }
            public void nhap()
            {
                Console.WriteLine("nhap tu so ");
                tuso = int.Parse(Console.ReadLine());
                Console.WriteLine("nhap mau so ");
                mauso = int.Parse(Console.ReadLine());
            }
            /*Phương thức Cong được định nghĩa trong cấu trúc phanso. Nó lấy một tham số kiểu phanso có tên là other. Phương thức này tính tổng của* hai phân số: 
             this (phân số đang gọi phương thức) và other. Kết quả được trả về dưới dạng một phân số đã được rút gọn.
            Ở đây, chúng ta tạo một đối tượng phanso mới với tử số là newTuso và mẫu số là newMauso. Sau đó, chúng ta gọi hàm RutGon với
            đối tượng ps và nhận lại kết quả trong biến rutgonPs. Kết quả sẽ là phân số đã được rút gọn.
            Các phương thức Tru, Nhan và Chia có cấu trúc tương tự, nhưng thực hiện các phép trừ, nhân và chia tương ứng giữa hai phân số. */
            public phanso Cong(phanso other)
            {
                int newTuso = this.tuso * other.mauso + other.tuso * this.mauso;
                int newMauso = this.mauso * other.mauso;
                return RutGon(new phanso(newTuso, newMauso));
            }

            public phanso Tru(phanso other)
            {
                int newTuso = this.tuso * other.mauso - other.tuso * this.mauso;
                int newMauso = this.mauso * other.mauso;
                return RutGon(new phanso(newTuso, newMauso));
            }

            public phanso Nhan(phanso other)
            {
                int newTuso = this.tuso * other.tuso;
                int newMauso = this.mauso * other.mauso;
                return RutGon(new phanso(newTuso, newMauso));
            }

            public phanso Chia(phanso other)
            {
                int newTuso = this.tuso * other.mauso;
                int newMauso = this.mauso * other.tuso;
                return RutGon(new phanso(newTuso, newMauso));
            }

            public phanso RutGon(phanso ps)
            {
                int ucln = UCLN(ps.tuso, ps.mauso);
                ps.tuso /= ucln;
                ps.mauso /= ucln;
                return ps;
            }

            public int UCLN(int a, int b)
            {
                if (b == 0)
                    return a;
                return UCLN(b, a % b);
            }
        }/*Giả sử chúng ta có một phân số ps với tử số (ps.tuso) là 12 và mẫu số (ps.mauso) là 18. Chúng ta muốn rút gọn phân số này.

       Bước 1: Gọi hàm UCLN(ps.tuso, ps.mauso):
       Gọi UCLN(12, 18).
       Bởi vì b khác 0, ta gọi đệ quy UCLN(18, 12 % 18).
       Tính 12 % 18 là 12.
       Gọi UCLN(18, 12).
       Bởi vì b khác 0, ta gọi đệ quy UCLN(12, 18 % 12).
       Tính 18 % 12 là 6.
       Gọi UCLN(12, 6).
       Bởi vì b khác 0, ta gọi đệ quy UCLN(6, 12 % 6).
       Tính 12 % 6 là 0.
       Bởi vì b bằng 0, ta trả về a là 6.
       Bước 2: Gán giá trị ucln bằng 6.
       Bước 3: Rút gọn phân số ps:
       Chia tử số (ps.tuso) của ps cho ucln: 12 / 6 = 2.
       Chia mẫu số (ps.mauso) của ps cho ucln: 18 / 6 = 3.
       Kết quả là phân số ps được rút gọn thành 2/3.
       Bước 4: Trả về phân số đã rút gọn 2/3.  */

    
    static void Main(string[] args)
        {
           phanso phanso1 = new phanso();
            phanso1.nhap();
           phanso phanso2 = new phanso(5,6);
            phanso tong = phanso1.Cong(phanso2);
            phanso2.nhap();
            Console.WriteLine("tong 2 phan so la : {0} / {1} " ,tong.tuso,tong.mauso);

            phanso hieu = phanso1.Tru(phanso2);
            Console.WriteLine("hieu 2 phan so la : {0} / {1} ", hieu.tuso, hieu.mauso);

            phanso tich = phanso1.Nhan(phanso2);
            Console.WriteLine("tich 2 phan so la : {0} / {1} ", tich.tuso, tich.mauso);

            phanso thuong = phanso1.Chia(phanso2);
            Console.WriteLine("thuong 2 phan so la : {0} / {1}:", thuong.tuso, thuong.mauso);
            Console.ReadLine();   
        }

    }
      
    }
