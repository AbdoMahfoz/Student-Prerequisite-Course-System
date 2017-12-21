using System.Windows.Forms;

namespace Student_prerequisite_course_system
{
    public partial class AdminForm : Form
    {
        Student ActiveStudent;
        public AdminForm()
        {
            Courses = new Tree<Course>();
            Courses.LoadFromFile(FileOperations.TreeFile.Read());
            ActiveStudent = null;
            InitializeComponent();
        }
    }
}
