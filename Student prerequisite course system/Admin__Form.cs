using System.Windows.Forms;

namespace Student_prerequisite_course_system
{
    public partial class AdminForm : Form
    {
        Tree<Course> Courses;
        Student ActiveStudent;
        public AdminForm()
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

        private void radioButton2_CheckedChanged(object sender, System.EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button11_Click(object sender, System.EventArgs e)
        {

        }

        private void button4_Click_1(object sender, System.EventArgs e)
        {
            //view sTUDENTS nav panel last form
        }

        private void button3_Click_1(object sender, System.EventArgs e)
        {

        }

        private void button7_Click(object sender, System.EventArgs e)
        {

        }

        private void studentDetails_Click(object sender, System.EventArgs e)
        {
            //view button in navigation panel in add new course form
            
        }

        private void ViewStudents_Click(object sender, System.EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click_1(object sender, System.EventArgs e)
        {

        }
    }
}
