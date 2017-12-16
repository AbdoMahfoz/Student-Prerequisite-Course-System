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

        private void label2_Click(object sender, System.EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void label1_Click(object sender, System.EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
