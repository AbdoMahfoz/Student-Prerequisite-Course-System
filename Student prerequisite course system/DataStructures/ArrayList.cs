﻿using System;
using System.Collections;
using System.Collections.Generic;

public class ArrayList<T> : IEnumerable<T>
{
    //private
    T[] arr;
    int count;
    int capacity;
    void CheckIndex(int index)
    {
        if (index >= count || index < 0)
        {
            throw new IndexOutOfRangeException();
        }
    }
    void CheckSizeCapacity()
    {
        if (count == capacity)
        {
            Capacity = capacity * 2;
        }
    }
    //public
    public ArrayList()
    {
        count = 0;
        capacity = 2;
        arr = new T[2];
    }
    public ArrayList(int IntialCount)
    {
        capacity = IntialCount;
        Count = IntialCount;
        arr = new T[IntialCount];
    }
    public int Count
    {
        get => count;
        set
        {
            if(capacity < value)
            {
                Capacity = value * 2;
            }
            count = value;
        }
    }
    public int Capacity
    {
        get => capacity;
        set
        {
            T[] tmp = new T[value];
            Array.ConstrainedCopy(arr, 0, tmp, 0, Math.Min(count, value));
            arr = tmp;
            capacity = value;
        }
    }
    public void Append(T value)
    {
        CheckSizeCapacity();
        arr[count] = value;
        count++;
    }
    public void PopBack()
    {
        if (count > 0) count--;
    }
    public void InsertAt(int index, T value)
    {
        CheckIndex(index);
        CheckSizeCapacity();
        for(int i = count; i > index; i++)
        {
            arr[i] = arr[i - 1];
        }
        arr[index] = value;
        count++;
    }
    public void DeleteAt(int index)
    {
        CheckIndex(index);
        for (int i = index; i < count - 1; i++)
        {
            arr[i] = arr[i + 1];
        }
        count--;
    }
    public void Clear()
    {
        arr = new T[2];
        capacity = 2;
        count = 0;
    }
    public T[] ToArray()
    {
        if(count == 0)
        {
            return new T[0];
        }
        T[] tmp = new T[count];
        Array.ConstrainedCopy(arr, 0, tmp, 0, count);
        return tmp;
    }
    public IEnumerator<T> GetEnumerator()
    {
        for(int i = 0; i < count; i++)
        {
            yield return arr[i];
        }
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
    public T this[int index]
    {
        get
        {
            CheckIndex(index);
            return arr[index];
        }
        set
        {
            CheckIndex(index);
            arr[index] = value;
        }
    }
}
