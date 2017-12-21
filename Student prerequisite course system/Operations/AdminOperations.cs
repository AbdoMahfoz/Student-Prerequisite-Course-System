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
        static Tree<Course> Courses;
        static void LoadCourse()
        {
            Courses = new Tree<Course>();
            Courses.LoadFromFile(FileOperations.TreeFile.Read());
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
        static public Student[] GetStudentsEnrolledInCourse(Course c)
        {
            return FileOperations.Subjects_UsersFile.GetStudents(c);
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
