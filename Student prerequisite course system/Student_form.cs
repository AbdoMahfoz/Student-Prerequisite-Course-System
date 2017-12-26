using System;
using System.Windows.Forms;

public partial class Student_form : Form
{
    //Fields
    Panel _currentActivePanel;
    Student ActiveStudent;
    ArrayList<CourseView> DrawnCourses = new ArrayList<CourseView>();
    //Properties
    Panel CurrentActivePanel
    {
        get
        {
            return _currentActivePanel;
        }
        set
        {
            if (_currentActivePanel != null)
            {
                _currentActivePanel.Visible = false;
            }
            value.Visible = true;
            _currentActivePanel = value;
            HomeCurrent.Enabled = true;
            HomeView.Enabled = true;
            HomeSpecificCourse.Enabled = true;
            HomeEditProfile.Enabled = true;
            if (value == ViewCourses)
            {
                HomeView.Enabled = false;
            }
            else if (value == SpecificCourse)
            {
                HomeSpecificCourse.Enabled = false;
            }
            else if (value == CurrentDetails)
            {
                HomeCurrent.Enabled = false;
            }
            else if (value == EditProfile)
            {
                HomeEditProfile.Enabled = false;
            }
        }
    }
    //Helpers
    private void DrawCourses(Course[] courses)
    {
        int offset = 0;
        foreach (Course c in courses)
        {
            bool IsAvail = false;
            Course[] AvailList = UserOperations.GetAvailableCourses(ActiveStudent);
            foreach (Course cs in AvailList)
            {
                if (c == cs)
                {
                    IsAvail = true;
                    break;
                }
            }
            DrawnCourses.Append(new AllCoursesView(c.Name, c.Description, offset, IsAvail, DynamicCourcesPanel, ActiveStudent));
            offset += 100;
        }
    }
    private void DeleteCourses()
    {
        foreach (CourseView c in DrawnCourses)
        {
            c.Clear();
        }
        DrawnCourses.Clear();
    }
    public void RefreshCurrent(string DeletedCourse)
    {
        int offset = 0;
        for (int i = 0; i < DrawnCourses.Count; i++)
        {
            if (DrawnCourses[i].Name == DeletedCourse)
            {
                DrawnCourses[i].Clear();
                DrawnCourses.DeleteAt(i);
                i--;
            }
            else
            {
                DrawnCourses[i].ResetLocation(offset);
                offset += 100;
            }
        }
    }
    //Constructor
    public Student_form()
    {
        InitializeComponent();
    }
    //Login
    private void LoginButton_Click(object sender, EventArgs e)
    {
        if(!int.TryParse(UserNameTextBox.Text, out int ID))
        {
            MessageBox.Show("ID has to be an integer");
            UserNameTextBox.Text = "";
            return;
        }
        Student s = UserOperations.LogIn(ID, PasswordTextBox.Text);
        if (s != null)
        {
            ActiveStudent = s;
            CurrentActivePanel = ViewCourses;
            ViewCourses.Visible = true;
            NavigationPanel.Visible = true;
            LoginPanel.Visible = false;
        }
        else
        {
            MessageBox.Show("Invalid ID or password");
            UserNameTextBox.Text = "";
            PasswordTextBox.Text = "";
        }
    }
    //HomeButton
    private void HomeClick(object sender, EventArgs e)
    {
        Button btn = sender as Button;
        if (btn == HomeCurrent)
        {
            CurrentActivePanel = CurrentDetails;
        }
        else if (btn == HomeView)
        {
            CurrentActivePanel = ViewCourses;
        }
        else if (btn == HomeSpecificCourse)
        {
            CurrentActivePanel = SpecificCourse;
        }
        else if (btn == HomeEditProfile)
        {
            CurrentActivePanel = EditProfile;
        }
    }
    //All Courses
    private void ViewCourses_VisibleChanged(object sender, EventArgs e)
    {
        if (ViewCourses.Visible)
        {
            AvailCourseCheckbox.Checked = false;
            DrawCourses(UserOperations.Courses.ToArray());
        }
        else
        {
            DeleteCourses();
            AvailCourseCheckbox.Checked = false;
        }
    }
    private void AvailCourseCheckbox_CheckedChanged(object sender, EventArgs e)
    {
        if (ViewCourses.Visible)
        {
            if (AvailCourseCheckbox.Checked)
            {
                Course[] Avail = UserOperations.GetAvailableCourses(ActiveStudent);
                DeleteCourses();
                DrawCourses(Avail);
            }
            else
            {
                DeleteCourses();
                DrawCourses(UserOperations.Courses.ToArray());
            }
        }
    }
    //Specific Course
    private void SpecificCourse_VisibleChanged(object sender, EventArgs e)
    {
        LisboxofPrerequisites.Items.Clear();
        CourseNameText.Text = "";
        DescriptionText.Text = "";
    }
    private void GoSpecificCourse_Click(object sender, EventArgs e)
    {
        LisboxofPrerequisites.Items.Clear();
        foreach (Course c in UserOperations.Courses)
        {
            if (c.Name == CourseNameText.Text)
            {
                DescriptionText.Text = c.Description;
                Course[] Registered = ActiveStudent.GetRegisterd();
                foreach (Course cs in UserOperations.Courses.GetDependantElements(c, Registered))
                {
                    LisboxofPrerequisites.Items.Add(cs.Name);
                }
                return;
            }
        }
        MessageBox.Show("No");
        CourseNameText.Text = "";
        DescriptionText.Text = "";
    }
    //Current Courses
    private void CurrentDetails_VisibleChanged(object sender, EventArgs e)
    {
        if (CurrentDetails.Visible)
        {
            int offset = 0;
            DrawnCourses.Clear();
            foreach (Pair<bool, Course> P in ActiveStudent.RegisteredCourses)
            {
                DrawnCourses.Append(new CurrentCourseView(P.Second.Name, P.Second.Description, offset, P.First, CurrentDetails, this, ActiveStudent));
                offset += 100;
            }
        }
        else
        {
            DeleteCourses();
        }
    }
    //Edit Profile
    private void EditProfile_VisibleChanged(object sender, EventArgs e)
    {
        UsernameText.Text = ActiveStudent.Name;
        PasswordText.Text = ActiveStudent.Password;
    }
    private void GoEditProfile_Click(object sender, EventArgs e)
    {
        ActiveStudent.Name = UsernameText.Text;
        ActiveStudent.Password = PasswordText.Text;
    }
}
