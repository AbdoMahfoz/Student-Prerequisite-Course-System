using System;

static public class UserOperations
{
    static public bool LogIn(Student s)
    {
        if (FileOperations.UsersFile.CheckUser(s))
        {
            s.RegisteredCourses = FileOperations.Users_SubjectsFile.GetSubjects(s);
            return true;
        }
        return false;
    }
    static public Course[] GetAvailableCourses(Student s, Tree<Course> t)
    {
        ArrayList<Course> tmp = new ArrayList<Course>();
        foreach (Pair<bool, Course> e in s.RegisteredCourses)
        {
            if (e.First)
            {
                tmp.Append(e.Second);
            }
        }
        return t.GetAvailableElements(tmp.ToArray());
    }
}
