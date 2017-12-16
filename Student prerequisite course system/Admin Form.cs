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
            //password textbox
        }

        private void label1_Click(object sender, System.EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, System.EventArgs e)
        {
            //current courses button 'home'
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            //view courses button 'home'
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            //Available courses button in view courses panel
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            //all courses button in view courses panel
        }

        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {
            //username textbox
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            //login button
        }
    }
}
