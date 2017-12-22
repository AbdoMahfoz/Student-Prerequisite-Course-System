using System;
using System.Collections;
using System.Collections.Generic;

public class Tree<T> : IEnumerable<T> where T : ITreeElement
{
    //private
    ArrayList<T> Elements;
    ArrayList<ArrayList<int>> AdjacencyList;
    int count;
    void CheckIndex(params int[] indecies)
    {
        foreach (int n in indecies)
        {
            if (n < 0 || n >= AdjacencyList.Count)
            {
                throw new IndexOutOfRangeException();
            }
        }
    }
    //public
    public Tree()
    {
        AdjacencyList = new ArrayList<ArrayList<int>>();
        Elements = new ArrayList<T>();
        count = 0;
    }
    public int Count
    {
        get => count;
    }
    public void AddElement(T value)
    {
        value.TreeIndex = count;
        Elements.Append(value);
        AdjacencyList.Count++;
        count++;
        if(typeof(T) == typeof(Course))
        {
            FileOperations.CoursesFile.AddCourse(value as Course);
        }
    }
    public void Connect(T dependant, T dependee)
    {
        CheckIndex(dependant.TreeIndex, dependee.TreeIndex);
        if (AdjacencyList[dependant.TreeIndex] == null)
        {
            AdjacencyList[dependant.TreeIndex] = new ArrayList<int>();
        }
        AdjacencyList[dependant.TreeIndex].Append(dependee.TreeIndex);
    }
    public void DeleteElement(T value)
    {
        if(value.TreeIndex == -1)
        {
            return;
        }
        for(int i = 0; i < AdjacencyList.Count; i++)
        {
            if(i == value.TreeIndex)
            {
                AdjacencyList.DeleteAt(i);
                i--;
            }
            else
            {
                bool UpdateIndex = false;
                for(int j = 0; j < AdjacencyList[i].Count; j++)
                {
                    if(j == value.TreeIndex)
                    {
                        AdjacencyList[i].DeleteAt(j);
                        j--;
                        UpdateIndex = true;
                    }
                    else if(UpdateIndex)
                    {
                        AdjacencyList[i][j]--;
                    }
                }
            }
        }
        bool Flag = false;
        for(int i = 0; i < Elements.Count; i++)
        {
            if(Elements[i] == value)
            {
                Flag = true;
            }
            else if(Flag)
            {
                Elements[i].TreeIndex--;
            }
        }
        Elements.DeleteAt(value.TreeIndex);
        count--;
    }
    public T[] GetAllConnectedElements(T Target)
    {
        foreach(T c in Elements)
        {
            if(c == Target)
            {
                ArrayList<T> res = new ArrayList<T>();
                foreach(int i in AdjacencyList[c.TreeIndex].ToArray())
                {
                    res.Append(Elements[i]);
                }
                return res.ToArray();
            }
        }
        return null;
    }
    public T[] GetDependantElements(T Target, T[] AlreadyTaken)
    {
        ArrayList<T> res = new ArrayList<T>();
        Queue<T> q = new Queue<T>();
        q.Enqueue(Target);
        while (q.Count > 0)
        {
            T tmp = q.Top();
            q.Dequeue();
            if (AdjacencyList[tmp.TreeIndex] == null) continue;
            foreach (int n in AdjacencyList[tmp.TreeIndex])
            {
                T tmpTarget = Elements[n];
                if (!Array.Exists(AlreadyTaken, new Predicate<T>((T a) => { return a == tmpTarget; })))
                {
                    q.Enqueue(tmpTarget);
                    res.Append(tmpTarget);
                }
            }
        }
        return res.ToArray();
    }
    public T[] GetAvailableElements(T[] AlreadyTaken)
    {
        ArrayList<T> Answers = new ArrayList<T>();
        for(int i = 0; i < AdjacencyList.Count; i++)
        {
            bool Available = true;
            bool Taken = false;
            foreach (T e in AlreadyTaken)
            {
                if (Elements[i] == e)
                {
                    Taken = true;
                    break;
                }
            }
            if (Taken) continue;
            for (int j = 0; j < AdjacencyList[i].Count; j++)
            {
                T element = Elements[AdjacencyList[i][j]];
                Taken = false;
                foreach(T e in AlreadyTaken)
                {
                    if(element == e)
                    {
                        Taken = true;
                        break;
                    }
                }
                if(!Taken)
                {
                    Available = false;
                    break;
                }
            }
            if(Available)
            {
                Answers.Append(Elements[i]);
            }
        }
        return Answers.ToArray();
    }
    public string[] UnloadToFile()
    {
        if (typeof(T) == typeof(Course))
        {
            ArrayList<string> res = new ArrayList<string>();
            System.Text.StringBuilder tmp = new System.Text.StringBuilder();
            for (int i = 0; i < count; i++)
            {
                Course c = Elements[i] as Course;
                tmp.Append(c.Name + " ");
                if (AdjacencyList[i] != null)
                {
                    for (int j = 0; j < AdjacencyList[i].Count; j++)
                    {
                        tmp.Append(AdjacencyList[i][j] + " ");
                    }
                }
                tmp.Remove(tmp.Length - 1, 1);
                res.Append(tmp.ToString());
                tmp.Clear();
            }
            return res.ToArray();
        }
        else
        {
            throw new NotImplementedException("UnloadToFile only works with Course type");
        }
    }
    public void LoadFromFile(string[] filedata)
    {
        if(filedata == null)
        {
            return;
        }
        if (typeof(T) == typeof(Course))
        {
            AdjacencyList.Count = filedata.Length;
            count = filedata.Length;
            for (int i = 0; i < filedata.Length; i++)
            {
                string[] fields = filedata[i].Split(' ', '\0');
                if (fields[0] == "")
                {
                    count--;
                    continue;
                }
                AdjacencyList[i] = new ArrayList<int>();
                Course c = FileOperations.CoursesFile.GetCourse(fields[0]);
                c.TreeIndex = i;
                Elements.Append(c as T);
                for (int j = 1; j < fields.Length; j++)
                {
                    AdjacencyList[i].Append(int.Parse(fields[j]));
                }
            }
        }
        else
        {
            throw new NotImplementedException("LoadFromFile only works with Course type");
        }
    }
    public IEnumerator<T> GetEnumerator()
    {
        return ((IEnumerable<T>)Elements).GetEnumerator();
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IEnumerable<T>)Elements).GetEnumerator();
    }
    public T this[int index]
    {
        get
        {
            if(index >= count || index < 0)
            {
                throw new IndexOutOfRangeException();
            }
            return Elements[index];
        }
        set
        {
            if (index >= count || index < 0)
            {
                throw new IndexOutOfRangeException();
            }
            Elements[index] = value;
        }
    }
    public T[] ToArray()
    {
        return Elements.ToArray();
    }
    ~Tree()
    {
        FileOperations.TreeFile.Write(UnloadToFile());
    }
}