namespace struct_lv2
{
    internal class Program
    {
        /* Viết chương trình Quản lý kết quả thi gồm các chức năng sau:
        Nhập danh sách gồm n học viên gồm các thông tin: Mã số, họ tên, giới tính, Toán, Lý, Hóa
        In danh sách học viên đã nhập ra màn hình
        Tính điểm trung bình các môn Toán, Lý, Hóa */
        struct quanly
        {
            public int maso,diemtoan,diemly,diemhoa;
            public string hoten ,gioitinh; 
            public quanly(int maso,int diemtoan,int diemly, int diemhoa,string hoten,string gioitinh)
            {
                this.maso = maso;
                this.diemhoa = diemhoa;
                this.hoten = hoten;
                this.gioitinh = gioitinh;
                this.diemtoan=diemtoan;
                this.diemly = diemly;
            }
            public void inthongtin()
            {
                Console.WriteLine("hoc sinh tren co ma so {0} , ten la : {1} , gioi tinh :{2} , diem toan :{3} , diem ly : {4} , diem hoa :{5}",maso,hoten,gioitinh,diemtoan,diemly,diemhoa);
            }
            public float diemtrungbinh()
            {
                float diemtrungbinh = (diemtoan + diemly + diemhoa) / 3;
                return diemtrungbinh;
            } 
        }
        static void Main(string[] args)
        {
            quanly ql1 = new quanly (12,5,9,8,"nguyen van a","nam");
            ql1.inthongtin();
            Console.WriteLine("diem trung binh cua hoc sinh do la :"+  ql1.diemtrungbinh());
            Console.ReadLine();
        }
    }
}