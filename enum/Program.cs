using System;

namespace EnumExample
{
    class Program
    {
        enum Thutrongtuan
        {
            ThuHai,
            ThuBa,
            ThuTu,
            ThuNam,
            ThuSau,
            ThuBay,
            ChuNhat
        }

        static void Main(string[] args)
        {
            Thutrongtuan thuHienTai = Thutrongtuan.ThuBa;
            Console.WriteLine("hom nay la " + thuHienTai.ToString());
            Thutrongtuan ngaymai = Thutrongtuan.ThuTu;
            Console.WriteLine("ngay mai la " + ngaymai.ToString());
        }
    }
}
