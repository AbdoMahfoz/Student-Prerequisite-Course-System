using System.Windows.Forms;

namespace Student_prerequisite_course_system
{
    public partial class MainForm : Form
    {
        Tree<Course> Courses;
        Student ActiveStudent;
        public MainForm()
        {
            Courses = new Tree<Course>();
            Courses.LoadFromFile(FileOperations.TreeFile.Read());
            ActiveStudent = null;
            InitializeComponent();
        }
    }
}
