using System.Windows.Forms;

namespace Student_prerequisite_course_system
{
    public partial class MainForm : Form
    {
        Tree<Course> Courses;
        Student ActiveStudent;
        public MainForm()
        {
            InitializeComponent();
        }
    }
}
