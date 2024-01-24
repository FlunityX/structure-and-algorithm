using System;
using System.Collections.Generic;

class MyList<T>
{
    private List<T> items;

    public MyList()
    {
        items = new List<T>();
    }

    public void AddItem(T item)
    {
        items.Add(item);
    }

    public void PrintItems()
    {
        foreach (T item in items)
        {
            Console.WriteLine(item);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyList<int> intList = new MyList<int>();
        intList.AddItem(1);
        intList.AddItem(2);
        intList.AddItem(3);
        intList.PrintItems();

        MyList<string> stringList = new MyList<string>();
        stringList.AddItem("Hello");
        stringList.AddItem("World");
        stringList.PrintItems();
        Console.ReadLine();
    }
}