using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_prerequisite_course_system
{
    public partial class logindesign : Form
    {
        public logindesign()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            string username;
            string password;
            username = TB_username.Text;
            password = TB_password.Text;
            if (Student.Login(username, password))
            {
                Globals._Login = true;

                // Close login form
                this.Dispose(false);

            }
            else
            {
                MessageBox.Show("Login Failed");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void logindesign_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox2_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form currdetails = new Form();
            currdetails.Text = "Details Of Current Courses";
            currdetails.StartPosition = FormStartPosition.CenterScreen;
            currdetails.BackColor = Color.Aquamarine;
            currdetails.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
