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
    }
    public Student_form()
    {
        InitializeComponent();
    }
    private void LoginButton_Click(object sender, EventArgs e)
    {
        /*Student s = new Student()
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
            MessageBox.Show("No");
            UserNameTextBox.Text = "";
            PasswordTextBox.Text = "";
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
