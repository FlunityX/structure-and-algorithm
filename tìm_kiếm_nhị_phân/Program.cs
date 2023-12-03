namespace tìm_kiếm_nhị_phân
{
    /*Tìm kiếm nhị phân (Binary Search): Giải thuật này chỉ áp dụng được cho mảng đã được sắp xếp theo thứ tự tăng dần. 
     * Chia mảng thành các phần tử con và so sánh phần tử cần tìm với phần tử ở giữa. Nếu bằng nhau, kết thúc tìm kiếm. 
     * Nếu lớn hơn, loại bỏ nửa dưới của mảng. Nếu nhỏ hơn, loại bỏ nửa trên của mảng. Độ phức tạp thời gian là O(log n),
     * n là số lượng phần tử trong mảng.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int target = 7;
            int timkiem = timkiemnhiphan(n, target);
            if (timkiem > 0)
            {
                Console.WriteLine(" phan tu " + target + " o vi tri thu " + timkiem + " trong mang ");
            }
            else { Console.WriteLine(" khong tim thay phan tu do trong mang "); }
            Console.ReadLine();
        }
        public static int timkiemnhiphan (int[] n, int target)
        {
            // xác đinh đầu và cuối của mảng 
            int dau = 0;
            int cuoi = n.Length - 1;
            // nếu đầu nhỏ hơn cuối thì tìm giá trị mid 
            // điều kiện while được giải thích như sau :  nếu số cần tìm bằng mid thì xuất mid 
            // nếu giá trị của chỉ mục mid < target thì dau + 1 tiến dần đến target để target = mid và ngược lại 
            while (dau <= cuoi) {
                int mid = (dau+cuoi) / 2;
                if (n[mid] == target)
                {
                    return mid; 
                }
                else if (n[mid] < target)
                {
                    dau = mid + 1;
                }
                else
                {
                    cuoi = mid - 1;
                }
            }
            return -1;  
        }
    }
}