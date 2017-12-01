using System;

public class Tree<T> where T : ITreeElement
{
    //private
    ArrayList<T> Elements;
    ArrayList<ArrayList<int>> AdjacencyList;
    int count;
    int capacity;
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
        capacity = 0;
    }
    public int Count
    {
        get => count;
    }
    public void AddCourse(T value)
    {
        value.TreeIndex = count;
        Elements.Append(value);
        AdjacencyList.Count++;
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
    public T[] GetDependantCourses(T Target, T[] AlreadyTaken)
    {
        ArrayList<T> res = new ArrayList<T>();
        ArrayList<T> queue = new ArrayList<T>();
        queue.Append(Target);
        while (queue.Count > 0)
        {
            T tmp = queue[Count - 1];
            queue.PopBack();
            for (int i = 0; AdjacencyList[tmp.TreeIndex] != null && i < AdjacencyList[tmp.TreeIndex].Count; i++)
            {
                T tmpTarget = Elements[AdjacencyList[tmp.TreeIndex][i]];
                if (!Array.Exists(AlreadyTaken, new Predicate<T>((T a) => { return a == tmpTarget; })))
                {
                    queue.Append(tmpTarget);
                    res.Append(tmpTarget);
                }
            }
        }
        return res.ToArray();
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
                if (AdjacencyList[i] == null) continue;
                for (int j = 0; j < AdjacencyList[i].Count; j++)
                {
                    tmp.Append(AdjacencyList[i][j] + " ");
                }
                tmp.Remove(tmp.Length - 1, 1);
                res.Append(tmp.ToString());
                tmp.Clear();
            }
            return res.ToArray();
        }
        else
        {
            return null;
        }
    }
    public void LoadFromFile(string[] filedata)
    {
        if (typeof(T) == typeof(Course))
        {
            AdjacencyList.Count = filedata.Length;
            for (int i = 0; i < filedata.Length; i++)
            {
                AdjacencyList[i] = new ArrayList<int>();
                string[] fields = filedata[i].Split(' ', '\0');
                if (fields.Length <= 1) continue;
                Course c = FileOperations.CoursesFile.GetCourse(fields[0]);
                c.TreeIndex = i;
                Elements.Append(c as T);
                for (int j = 1; j < fields.Length; j++)
                {
                    AdjacencyList[i].Append(int.Parse(fields[j]));
                }
            }
        }
    }
}

