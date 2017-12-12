using System;
using System.Windows.Forms;

public partial class Student_form : Form
{
    Panel _currentActivePanel;
    Panel CurrentActivePanel
    {
        get
        {
            return _currentActivePanel;
        }
        set
        {
            _currentActivePanel = value;
            HomeCurrent.Enabled = true;
            HomeRegister.Enabled = true;
            HomeView.Enabled = true;
            if(value == ViewCourses)
            {
                HomeView.Enabled = false;
            }
            else if(value == RegisterPanel)
            {
                HomeRegister.Enabled = false;
            }
            else
            {
                HomeCurrent.Enabled = false;
            }
        }
<<<<<<< HEAD

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
            
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            //previous button in register form
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void Previous_Click(object sender, EventArgs e)
        {
            //Edit button in fifth form
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void vScrollBar4_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void LOGIN_Click(object sender, EventArgs e)
        { //login button
           Text
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AvailableCbtn_Click(object sender, EventArgs e)
        {
            //panel3 available courses button 
        }

        private void AllCbtn_Click(object sender, EventArgs e)
        {
            //panel3 all courses button
        }

        private void DetailscurrentCourses_Click(object sender, EventArgs e)
        {
            //panel2 details of current courses button

        }

        private void Register_Click(object sender, EventArgs e)
        {
            //4th form "register" button
        }

        private void VCPrevious_Click(object sender, EventArgs e)
        {
            //previous button of third form (all and available courses)
        }

        private void VCNext_Click(object sender, EventArgs e)
        {
            //next button of third form (all and available courses)
        }

        private void RegisterNext_Click(object sender, EventArgs e)
=======
    }
    public Student_form()
    {
        InitializeComponent();
    }
    private void LoginButton_Click(object sender, EventArgs e)
    {
        /*Student s = new Student()
>>>>>>> c4373d2a9c4ca7dfcbf008b9d0f45b94f71b6781
        {
            Name = UserNameTextBox.Text,
            Password = PasswordTextBox.Text
        };*/
        if(/*UserOperations.LogIn(s)*/ UserNameTextBox.Text == "Admin" && PasswordTextBox.Text == "Admin")
        {
            ViewCourses.Visible = true;
            NavigationPanel.Visible = true;
            LoginPanel.Visible = false;
            CurrentActivePanel = ViewCourses;
        }
        else
        {
<<<<<<< HEAD
            textBox1.Focus();
=======
            MessageBox.Show("No");
            UserNameTextBox.Text = "";
            PasswordTextBox.Text = "";
>>>>>>> c4373d2a9c4ca7dfcbf008b9d0f45b94f71b6781
        }
    }
    private void HomeCurrent_Click(object sender, EventArgs e)
    {
        CurrentDetails.Visible = true;
        CurrentActivePanel.Visible = false;
        CurrentActivePanel = CurrentDetails;
    }
    private void HomeRegister_Click(object sender, EventArgs e)
    {
        RegisterPanel.Visible = true;
        CurrentActivePanel.Visible = false;
        CurrentActivePanel = RegisterPanel;
    }
    private void HomeView_Click(object sender, EventArgs e)
    {
        ViewCourses.Visible = true;
        CurrentActivePanel.Visible = false;
        CurrentActivePanel = ViewCourses;
    }
}
