namespace tìm_kiếm_bước_nhảy
{
    internal class Program
    {
        static void Main(string[] args)
        {
        int[] mang = new int[14] {0,2,4,6,8,10,12,13,14,15,16,17,18,19};
        
        int target = 6;
        int timkiem = timkiembuocnhay(mang, target);
            if (timkiem > 0)
            {
                Console.WriteLine("phan tu do nam o vi tri :" + timkiem + " trong mang ");
            }
            else Console.WriteLine(" khong tim thay vi tri cua phan tu do ");
            Console.ReadLine();
        }
        public static int timkiembuocnhay(int[] mang,int target) {
            int n = mang.Length;
            int step = (int)Math.Floor(Math.Sqrt(n));
            int prev = 0;
            // mang chay tu step min neu nho hon so can tim thi nhay bang can n 
            /*Điều kiện arr[Math.Min(step, n) - 1] < target kiểm tra xem giá trị phần tử tại vị trí Math.Min(step, n) - 1 
             * có nhỏ hơn giá trị target hay không. Nếu còn nhỏ hơn, vòng lặp sẽ tiếp tục.
             Trong vòng lặp, biến prev được gán giá trị của step để lưu lại vị trí trước đó. 
            Sau đó, step sẽ tăng lên Math.Floor(Math.Sqrt(n)) đơn vị để di chuyển đến khoảng tiếp theo.
            Nếu prev vượt quá hoặc bằng kích thước của mảng n, tức là đã quá giới hạn của mảng, 
            chương trình sẽ trả về -1 để chỉ không tìm thấy phần tử cần tìm.*/
            while (mang[Math.Min(step, n) - 1] < target)
            {
                prev = step;
                step += (int)Math.Floor(Math.Sqrt(n));
                if (prev >= n)
                    return -1;
            }
            /*Điều kiện arr[prev] < target kiểm tra xem giá trị phần tử tại vị trí prev có nhỏ hơn giá trị target hay không.
             * Nếu còn nhỏ hơn, vòng lặp sẽ tiếp tục.
             Trong vòng lặp, biến prev tăng lên 1 đơn vị sau mỗi lần lặp để di chuyển đến phần tử tiếp theo trong khoảng.
             Nếu prev đạt tới giới hạn trên của khoảng, tức là prev đã bằng Math.Min(step, n), 
            chương trình sẽ trả về -1 để chỉ không tìm thấy phần tử cần tìm.*/
            while (mang[prev] < target)
            {
                prev++;
                if (prev == Math.Min(step, n))
                    return -1;
            }
            if (mang[prev] == target)
                return prev;
            else
                return -1;
        }
    }
    }
