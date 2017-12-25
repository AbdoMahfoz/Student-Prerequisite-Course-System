
static public class UserOperations
{
    static Tree<Course> courses;
    static public Tree<Course> Courses
    {
        get
        {
            if (courses == null)
            {
                courses = new Tree<Course>();
                courses.LoadFromFile(FileOperations.TreeFile.Read());
            }
            return courses;
        }
    }
    static public Student LogIn(string UserName, string Password)
    {
        int ID = FileOperations.UsersFile.CheckUser(UserName, Password);
        if (ID != -1)
        {
            Student s = FileOperations.UsersFile.GetUser(ID);
            return s;
        }
        return null;
    }
    static public Course[] GetAvailableCourses(Student s)
    {
        ArrayList<Course> res = new ArrayList<Course>();
        Course[] AvailList = Courses.GetAvailableElements(s.GetTaken());
        foreach (Course cs in AvailList)
        {
            bool IsReg = false;
            foreach (Course c in s.GetRegisterd())
            {
                if (c == cs)
                {
                    IsReg = true;
                    break;
                }
            }
            if(!IsReg)
            {
                res.Append(cs);
            }
        }
        return res.ToArray();
    }
}
