using System;
using System.Collections;

internal class Program
{
    // where quy định kiểu tham chiếu của T , nếu T : class thì là tham chiếu ,  T: thì là tham trị 
    // T: new()Ràng buộc where T : new() yêu cầu kiểu T phải có một constructor không tham số công khai (public parameterless constructor).
    internal class MyList<T> where T : class
    {
        private Stack myStack;

        public MyList()
        {
            myStack = new Stack();
        }

        public void Push(T item)
        {
            myStack.Push(item);
        }

        public T Pop()
        {
            return myStack.Pop() as T;
        }
    }

    public static void Main()
    {
        MyList<string> myList = new MyList<string>();
        myList.Push("Hello");
        myList.Push("World");

        string item1 = myList.Pop(); // Lấy phần tử từ ngăn xếp
        string item2 = myList.Pop(); // Lấy phần tử từ ngăn xếp

        Console.WriteLine(item1); // Output: World
        Console.WriteLine(item2); // Output: Hello
    }
}