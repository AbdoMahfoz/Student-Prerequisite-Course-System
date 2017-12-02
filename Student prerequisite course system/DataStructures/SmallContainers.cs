using System;

public abstract class ITreeElement
{
    public int TreeIndex = -1;
}

public class Course : ITreeElement, IComparable
{
    public string Name, Description;
    public int CompareTo(object obj)
    {
        throw new NotImplementedException();
    }
}

public class Student
{
    public string Name, Password, AcademicYear;
    public int ID;
    public ArrayList<Pair<bool, Course>> RegisteredCourses;
    public bool IsAdmin;
    public bool Remove(Course c)
    {
        throw new NotImplementedException();
    }
    public bool Add(Course c)
    {
        throw new NotImplementedException();
    }
}

public class Admin
{
    public string Name, Password;
}

public class Pair<F, S>
{
    public F First;
    public S Second;
}