
public abstract class ITreeElement
{
    public int TreeIndex = -1;
}

public class Course : ITreeElement
{
    public string Name, Description;
}

public struct Student
{
    public string Name, Password, AcademicYear;
    public int ID;
    public Course[] RegisteredCourses;
    public bool IsAdmin;
}

public struct Admin
{
    public string Name, Password;
}

public class Pair<F, S>
{
    public F First;
    public S Second;
}