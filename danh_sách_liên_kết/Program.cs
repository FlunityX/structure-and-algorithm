using System;
using System.Collections.Generic;
public class Node
{
    private int value;
    private Node next;

    public int Value { get => value; set => this.value = value; }
    public Node Next { get => next; set => next = value; }
    public Node() {
        value = 0;
        next = null;
    }
    public Node(int value, Node next)
    {
        Value = value;
        Next = next;
    }
}
public class LinkedList
{
    private Node head;

    public void Add(int value)
    {
        Node newNode = new Node();
        newNode.Value = value;
        if (head == null)
        {
            head = newNode;
        }
        else
        {
            Node currentNode = head;
            while (currentNode.Next != null)
            {
                currentNode = currentNode.Next;
            }
            currentNode.Next = newNode;
        }
    }

    public void Print()
    {
        Node currentNode = head;
        while (currentNode != null)
        {
            Console.WriteLine(currentNode.Value);
            currentNode = currentNode.Next;
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        LinkedList linkedList = new LinkedList();
        linkedList.Add(1);
        linkedList.Add(2);
        linkedList.Add(3);
        linkedList.Print();
        
    }
}