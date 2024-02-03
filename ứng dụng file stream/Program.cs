// using System.Text;

// Lớp sinhvien
using System.Text;

class sinhvien
{
    // Các thuộc tính của sinh viên
    public string name { get; set; }
    public int age { get; set; }
    public double score { get; set; }

    // Phương thức Save để lưu thông tin sinh viên vào stream
    public void Save(Stream stream)
    {
        // Chuyển đổi tên sinh viên thành mảng byte và ghi vào stream
        var byte_name = Encoding.UTF8.GetBytes(name);
        stream.Write(byte_name, 0, byte_name.Length);

        // Ghi dấu phẩy (separator) vào stream
        byte[] separator = Encoding.UTF8.GetBytes(",");
        stream.Write(separator, 0, separator.Length);

        // Chuyển đổi tuổi sinh viên thành mảng byte và ghi vào stream
        var byte_age = BitConverter.GetBytes(age);
        stream.Write(byte_age, 0, 4);

        // Chuyển đổi điểm số thành mảng byte và ghi vào stream
        var byte_score = BitConverter.GetBytes(score);
        stream.Write(byte_score, 0, 8);

        // Ghi dòng mới (newLine) vào stream
        byte[] newLine = Encoding.UTF8.GetBytes(Environment.NewLine);
        stream.Write(newLine, 0, newLine.Length);
    }

    // Phương thức Load để đọc thông tin sinh viên từ stream
    public static sinhvien Load(Stream stream)
    {
        // Khởi tạo một đối tượng sinh viên mới
        sinhvien sv = new sinhvien();

        // Khởi tạo mảng byte buffer và danh sách dataBytes
        byte[] buffer = new byte[1024];
        List<byte> dataBytes = new List<byte>();

        int bytesRead;
        // Đọc dữ liệu từ stream vào buffer
        while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
        {
            // Duyệt qua từng byte đã đọc
            for (int i = 0; i < bytesRead; i++)
            {
                // Kiểm tra nếu byte hiện tại là ký tự xuống dòng
                if (buffer[i] == '\n')
                {
                    // Chuyển đổi dataBytes thành chuỗi và chia thành các trường bằng dấu phẩy
                    string data = Encoding.UTF8.GetString(dataBytes.ToArray());
                    string[] fields = data.Split(',');

                    // Gán các giá trị trường từ mảng fields vào các thuộc tính tương ứng của sinh viên
                    sv.name = fields[0];
                    sv.age = BitConverter.ToInt32(buffer, i + 1);
                    sv.score = BitConverter.ToDouble(buffer, i + 5);

                    // Xóa dữ liệu tạm thời dataBytes
                    dataBytes.Clear();
                }
                else
                {
                    // Thêm byte vào danh sách dataBytes
                    dataBytes.Add(buffer[i]);
                }
            }
        }

        // Trả về đối tượng sinh viên đã được tạo và điền dữ liệu
        return sv;
    }

    // Phương thức ReadData để đọc và hiển thị thông tin của sinh viên từ stream
    public static void ReadData(Stream stream)
    {
        // Đọc và hiển thị thông tin của sinh viên cho đến khi đọc hết dữ liệu trong stream
        while (stream.Position < stream.Length)
        {
            // Gọi phương thức Load để đọc dữ liệu từ stream và lưu vào đối tượng sinh viên
            sinhvien sv = sinhvien.Load(stream);
            Console.WriteLine($"Name: {sv.name}");
            Console.WriteLine($"Age: {sv.age}");
            Console.WriteLine($"Score: {sv.score}");
            Console.WriteLine();
        }
    }

    // Lớp Program chứa phương thức Main để chạy chương trình
    internal class Program
    {
        static void Main(string[] args)
        {
            // Đường dẫn tới file
            string path = "C:/Users/Administrator/source/repos/sinhvien.dat";

            // Mở hoặc tạo file theo đường dẫn đã cung cấp
            using var stream = new FileStream(path: path, FileMode.OpenOrCreate);

            // Tạo một đối tượng sinh viên mới
            sinhvien sinhvien = new sinhvien()
            {
                name = "nguyen van manh",
                age = 20,
                score = 7.51
            };

            // Lưu thông tin sinh viên vào stream
            sinhvien.Save(stream);
        }
    }
}
