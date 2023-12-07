namespace ConsoleApp18
{
    internal class Program
    {
        struct thongtinsinhvien
        {
            public string tensinhvien;
            public string tenmonthi;
            public double chuyencan;
            public double giuaki;
            public double cuoiki;
            public thongtinsinhvien(string tensinhvien,string tenmonthi , double chuyencan , double giuaki , double cuoiki)
            {
                this.tensinhvien = tensinhvien;
                this.tenmonthi = tenmonthi;
                this.chuyencan = chuyencan;
                this.giuaki = giuaki;
                this.cuoiki=cuoiki;
            }
        }
        static void Main(string[] args)
        {
            List<thongtinsinhvien> ttsv = new List<thongtinsinhvien>();
            nhapthongtin( ttsv);
            xuatthongtin(ttsv);
            Console.ReadLine();


        }
        static void nhapthongtin(List<thongtinsinhvien> ttsv)
        {
            thongtinsinhvien sv = new thongtinsinhvien();
            Console.WriteLine("nhap so lg sinh vien ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(" nhap ten sinh vien ");
                sv.tensinhvien = Console.ReadLine();
                Console.WriteLine("nhap mon thi ");
                sv.tenmonthi = Console.ReadLine();
                Console.WriteLine(" nhap diem chuyen can ");
                sv.chuyencan = double.Parse(Console.ReadLine());
                Console.WriteLine(" nhap diem giua ki");
                sv.giuaki = double.Parse(Console.ReadLine());
                Console.WriteLine(" nhap diem cuoi ki ");
                sv.cuoiki = double.Parse(Console.ReadLine());
                
                double diemtrungbinh = tinhdiemtrungbinh(sv.chuyencan, sv.giuaki, sv.cuoiki);
                bool danhgia = false;
                if (diemtrungbinh >= 4)
                {
                    danhgia = true;
                }
                ttsv.Add(sv);
                
            }
        }
        static void xuatthongtin(List<thongtinsinhvien> ttsv)
        {
            Console.WriteLine("Thong tin sinh vien:");
            for (int i = 0; i < ttsv.Count; i++)
            {
                thongtinsinhvien sv = ttsv[i];
                double diemtrungbinh = tinhdiemtrungbinh(sv.chuyencan, sv.giuaki, sv.cuoiki);
                string danhgia = diemtrungbinh >= 4 ? "dau" : "rot";

                Console.WriteLine("Ten sinh vien: {0}", sv.tensinhvien);
                Console.WriteLine("Mon thi: {0}", sv.tenmonthi);
                Console.WriteLine("Diem chuyen can: {0}", sv.chuyencan);
                Console.WriteLine("Diem giua ki: {0}", sv.giuaki);
                Console.WriteLine("Diem cuoi ki: {0}", sv.cuoiki);
                Console.WriteLine("Danh gia: {0}", danhgia);
                Console.WriteLine();
            }
        }


        static double tinhdiemtrungbinh(double chuyencan, double giuaki, double cuoiki) => (chuyencan * 0.1 +giuaki * 0.3 + cuoiki * 0.6 );
    }
}