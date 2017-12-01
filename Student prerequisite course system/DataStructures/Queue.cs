using System;
using System.Collections;
using System.Collections.Generic;

public class Queue<T> : IEnumerable<T>
{
    //private
    class Node
    {
        public T value;
        public Node next;
        public Node(T val)
        {
            value = val;
            next = null;
        }
    }
    Node head, tail;
    int count;
    //public
    public Queue()
    {
        head = null;
        tail = null;
        count = 0;
    }
    public int Count
    {
        get => count;
    }
    public void Enqueue(T value)
    {
        if (head == null)
        {
            head = new Node(value);
            tail = head;
        }
        else
        {
            tail.next = new Node(value);
            tail = tail.next;
        }
        count++;
    }
    public void Dequeue()
    {
        if (head == null)
        {
            throw new InvalidOperationException("Queue is empty");
        }
        head = head.next;
        count--;
    }
    public T Top()
    {
        if (head == null)
        {
            throw new InvalidOperationException("Queue is empty");
        }
        return head.value;
    }
    public IEnumerator<T> GetEnumerator()
    {
        Node tmp = head;
        while(tmp != null)
        {
            yield return tmp.value;
            tmp = tmp.next;
        }
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
