using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 2, 3, 5, 4, 1 };

        MergeSort(arr);

        Console.WriteLine("Sorted array:");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }

        Console.ReadLine();
    }

    static void MergeSort(int[] arr)
    {
        //Trước khi gọi hàm MergeSort, chúng ta kiểm tra xem mảng có độ dài nhỏ hơn hoặc bằng 1 hay không.
        //Nếu đúng, tức là mảng đã được sắp xếp hoặc rỗng, chúng ta kết thúc hàm bằng lệnh return.
        if (arr.Length <= 1)
            return;
        //Nếu mảng có độ dài lớn hơn 1, chúng ta tính chỉ số giữa mid của mảng và tạo hai mảng con left và right
        //để chứa các phần tử của mảng gốc.Mảng left sẽ chứa các phần tử từ vị trí 0 đến mid-1, và mảng right sẽ chứa
        //các phần tử từ vị trí mid đến cuối mảng.
        int mid = arr.Length / 2;
        int[] left = new int[mid];
        int[] right = new int[arr.Length - mid];

        Array.Copy(arr, 0, left, 0, mid);
        Array.Copy(arr, mid, right, 0, arr.Length - mid);
        //Sau khi chia mảng thành hai mảng con, chúng ta gọi đệ quy hàm MergeSort trên mảng left và right
        //để tiếp tục sắp xếp các mảng con này.
        MergeSort(left);
        MergeSort(right);
        Merge(arr, left, right);
    }

    static void Merge(int[] arr, int[] left, int[] right)
    {
        //Biến i đại diện cho chỉ mục trong mảng con left.
        //Biến j đại diện cho chỉ mục trong mảng con right.
        //Biến k đại diện cho chỉ mục trong mảng ban đầu arr.
        int i = 0, j = 0, k = 0;

        while (i < left.Length && j < right.Length)
        {
            //Khi thực hiện quá trình trộn, chúng ta so sánh các phần tử tại các chỉ mục i và j trong left và right.
            //Nếu phần tử tại left[i] nhỏ hơn hoặc bằng phần tử tại right[j], chúng ta đặt phần tử left[i] vào arr[k],
            //sau đó tăng i và k lên 1
            //Ngược lại, nếu phần tử tại right[j] nhỏ hơn, chúng ta đặt phần tử right[j] vào arr[k], sau đó tăng j và k lên 1.
            if (left[i] <= right[j])
            {
                arr[k] = left[i];
                i++;
            }
            else
            {
                arr[k] = right[j];
                j++;
            }
            k++;
        }
        //Nếu điều kiện i < left.Length được đáp ứng, tức là vẫn còn phần tử chưa được xử lý trong left, chúng ta thực hiện các bước sau:
        //Gán giá trị của left[i] vào phần tử đang xét trong mảng ban đầu arr, tức là arr[k] = left[i].
        //Tăng chỉ mục i và k lên 1 để di chuyển đến phần tử tiếp theo trong left và arr.
        //Quá trình này tiếp tục cho đến khi chúng ta đã sao chép tất cả các phần tử trong mảng con left vào mảng ban đầu arr.
        while (i < left.Length)
        {
            arr[k] = left[i];
            i++;
            k++;
        }
        //Kiểm tra xem có bất kỳ phần tử nào còn lại trong mảng con right không. Nếu điều kiện j < right.Length được đáp ứng, chúng ta thực hiện các bước sau:
        //Gán giá trị của right[j] vào phần tử đang xét trong mảng ban đầu arr, tức là arr[k] = right[j].
        //Tăng chỉ mục j và k lên 1 để di chuyển đến phần tử tiếp theo trong right và arr.
        while (j < right.Length)
        {
            arr[k] = right[j];
            j++;
            k++;
        }
    }
}