using System;

static public class AdminOperations
{
    static public class StudentFunctions
    {
        static public Student[] AllStudents
        {
            get
            {
                return FileOperations.UsersFile.GetAllStudents();
            }
        }
        static public void AddStudent(Student s)
        {
            FileOperations.UsersFile.AddStudent(s);
        }
        static public bool DeleteStudent(Student s)
        {
            return FileOperations.UsersFile.DeleteStudent(s);
        }
    }
    static public class CourseFunctions
    {
        static public Tree<Course> courses;
        static public Tree<Course> Courses
        {
            get
            {
                if (courses == null)
                {
                    LoadCourse();
                }
                return courses;
            }
        }
        static public void LoadCourse()
        {
            if (courses != null) return;
            courses = new Tree<Course>();
            courses.LoadFromFile(FileOperations.TreeFile.Read());
        }
        static public void DeleteCourse(string CourseName)
        {
            Course c = FileOperations.CoursesFile.GetCourse(CourseName);
            Courses.DeleteElement(c);
            FileOperations.CoursesFile.DeleteCourse(c);
        }
        static public bool AddCourse(Course c)
        {
            if (Courses == null)
            {
                LoadCourse();
            }
            foreach (Course s in Courses)
            {
                if (c == s)
                {
                    return false;
                }
            }
            Courses.AddElement(c);
            return true;
        }
        static public bool ConnectCourses(string DependantName, string DependeeName)
        {
            Course Dependant = FileOperations.CoursesFile.GetCourse(DependantName);
            Course Dependee = FileOperations.CoursesFile.GetCourse(DependeeName);
            if (Dependant == null || Dependee == null)
            {
                return false;
            }
            Courses.Connect(Dependant, Dependee);
            return true;
        }
        static public void DisconnectCourses(string DependantName, string DependeeName)
        {
            Courses.Disconnect(FileOperations.CoursesFile.GetCourse(DependantName), FileOperations.CoursesFile.GetCourse(DependeeName));
        }
        static public Student[] GetStudentsEnrolledInCourse(Course c)
        {
            ArrayList<Student> res = new ArrayList<Student>();
            foreach (Student s in FileOperations.Subjects_UsersFile.GetStudents(c))
            {
                if (!Array.Exists(s.GetTaken(), (Course cour) => { return cour == c; }))
                {
                    res.Append(s);
                }
            }
            return res.ToArray();
        }
        static public Course[] GetAllConnectedCourses(string CourseName)
        {
            if (Courses == null)
            {
                LoadCourse();
            }
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
