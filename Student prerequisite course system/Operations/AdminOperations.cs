
static public class AdminOperations
{
    static public Student GetStudent(int StudentID)
    {
        Student s = FileOperations.UsersFile.GetUser(StudentID);
        s.RegisteredCourses = FileOperations.Users_SubjectsFile.GetSubjects(s);
        return s;
    }
    static public ArrayList<Student> GetAllStudentsInCourse(Course c)
    {
        return FileOperations.Subjects_UsersFile.GetStudents(c);
    }
}
