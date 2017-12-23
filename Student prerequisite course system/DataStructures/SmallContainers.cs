using System;

public abstract class ITreeElement
{
    public int TreeIndex = -1;
}

public class Course : ITreeElement
{
    public string Name, Description;
}

public class Student
{
    public string Name, Password, AcademicYear;
    public int ID;
    public ArrayList<Pair<bool, Course>> RegisteredCourses;
    public Course[] GetTaken()
    {
        ArrayList<Course> Taken = new ArrayList<Course>();
        foreach (Pair<bool, Course> P in RegisteredCourses)
        {
            if (P.First)
            {
                Taken.Append(P.Second);
            }
        }
        return Taken.ToArray();
    }
    public Course[] GetRegisterd()
    {
        ArrayList<Course> Taken = new ArrayList<Course>();
        foreach (Pair<bool, Course> P in RegisteredCourses)
        {
            Taken.Append(P.Second);
        }
        return Taken.ToArray();
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