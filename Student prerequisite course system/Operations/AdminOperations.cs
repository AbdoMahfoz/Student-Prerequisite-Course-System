using System;

static public class AdminOperations
{
    static public class StudentFunctions
    {
        static public Student[] GetAllStudents()
        {
            throw new NotImplementedException();
        }
        static public bool AddStudent(Student s)
        {
            if(FileOperations.UsersFile.CheckUser(s))
            {
                return false;
            }
            FileOperations.UsersFile.WriteUser(s);
            return true;
        }
        static public bool UpdateStudent(Student s)
        {
            throw new NotImplementedException();
        }
    }
    static public class CourseFunctions
    {
        static public Tree<Course> Courses;
        static public void LoadCourse()
        {
            if (Courses != null) return;
            Courses = new Tree<Course>();
            Courses.LoadFromFile(FileOperations.TreeFile.Read());
        }
        static public void DeleteCourse(string CourseName)
        {
            Course c = FileOperations.CoursesFile.GetCourse(CourseName);
            Courses.DeleteElement(c);
            FileOperations.CoursesFile.DeleteCourse(c);
        }
        static public bool AddCourse(Course c)
        {
            if(Courses == null)
            {
                LoadCourse();
            }
            foreach(Course s in Courses)
            {
                if(c == s)
                {
                    return false;
                }
            }
            Courses.AddElement(c);
            return true;
        }
        static public Student[] GetStudentsEnrolledInCourse(string CourseName)
        {
            Course c = FileOperations.CoursesFile.GetCourse(CourseName);
            return FileOperations.Subjects_UsersFile.GetStudents(c);
        }
        static public Course[] GetAllConnectedCourses(string CourseName)
        {
            Course c = FileOperations.CoursesFile.GetCourse(CourseName);
            return Courses.GetAllConnectedElements(c);
        }
        static public void SetPrerequisite(Course dependant, Course dependee)
        {
            if (Courses == null)
            {
                LoadCourse();
            }
            Courses.Connect(dependant, dependee);
        }
        static public Course[] GetAllCourses()
        {
            if (Courses == null)
            {
                LoadCourse();
            }
            return Courses.ToArray();
        }
    }
}
