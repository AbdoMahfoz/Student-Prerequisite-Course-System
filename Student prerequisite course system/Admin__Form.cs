using System.Windows.Forms;

namespace Student_prerequisite_course_system
{
    public partial class AdminForm : Form
    {
        Panel activePanel;
        Button ActiveButton;
        Panel ActivePanel
        {
            get
            {
                return activePanel;
            }
            set
            {
                value.Visible = true;
                if (ActiveButton != null)
                {
                    ActiveButton.Enabled = true;
                }
                if (activePanel != null)
                {
                    activePanel.Visible = false;
                }
                activePanel = value;
                if (value == CourseOverviewPanel)
                {
                    HomeAllCoursesButton.Enabled = false;
                    ActiveButton = HomeAllCoursesButton;
                }
                else if (value == StudentOverviewPanel)
                {
                    HomeAllStudentsButton.Enabled = false;
                    ActiveButton = HomeAllStudentsButton;
                }
                else if (value == StudentsInCourse)
                {
                    HomeStudentsOfCourseButton.Enabled = false;
                    ActiveButton = HomeStudentsOfCourseButton;
                }
                else if (value == CoursesInStudent)
                {
                    HomeCoursesOfStudentButton.Enabled = false;
                    ActiveButton = HomeCoursesOfStudentButton;
                }
                else
                {
                    HomeCPQButton.Enabled = false;
                    ActiveButton = HomeCPQButton;
                }
            }
        }
        public AdminForm()
        {
            InitializeComponent();
        }
        private void LoginButton_Click(object sender, System.EventArgs e)
        {
            if (UserNameTextBox.Text == "Admin" && PasswordTextBox.Text == "Admin")
            {
                LogIn.Visible = false;
                Home.Visible = true;
            }
        }
        private void HomeButtonClick(object sender, System.EventArgs e)
        {
            Button button = sender as Button;
            if (button == HomeAllCoursesButton)
            {
                ActivePanel = CourseOverviewPanel;
            }
            else if (button == HomeAllStudentsButton)
            {
                ActivePanel = StudentOverviewPanel;
            }
            else if (button == HomeStudentsOfCourseButton)
            {
                ActivePanel = StudentsInCourse;
            }
            else if (button == HomeCPQButton)
            {
                ActivePanel = CoursesPrerequisites;
            }
            else
            {
                ActivePanel = CoursesInStudent;
            }
        }
        private void CourseOverviewPanel_VisibleChanged(object sender, System.EventArgs e)
        {
            if (CourseOverviewPanel.Visible)
            {
                AdminOperations.CourseFunctions.LoadCourse();
                AllCoursesGrid.Rows.Clear();
                Course[] Courses = AdminOperations.CourseFunctions.GetAllCourses();
                if (Courses == null)
                {
                    return;
                }
                foreach (Course c in Courses)
                {
                    AllCoursesGrid.Rows.Add(c.Name, c.Description);
                }
            }
        }
        private void AllCoursesGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            else if (e.RowIndex == AdminOperations.CourseFunctions.Courses.Count)
            {
                AdminOperations.CourseFunctions.AddCourse(new Course()
                {
                    Name = AllCoursesGrid.Rows[e.RowIndex].Cells[0].Value as string,
                    Description = AllCoursesGrid.Rows[e.RowIndex].Cells[1].Value as string
                });
            }
            else
            {
                AdminOperations.CourseFunctions.Courses[e.RowIndex].Name = AllCoursesGrid.Rows[e.RowIndex].Cells[0].Value as string;
                AdminOperations.CourseFunctions.Courses[e.RowIndex].Description = AllCoursesGrid.Rows[e.RowIndex].Cells[1].Value as string;
            }
        }
        private void CoursesPrerequisites_VisibleChanged(object sender, System.EventArgs e)
        {
            CPQDataGrid.Rows.Clear();
            InputCPQ.Text = "";
        }
        private void CPQGoButton_Click(object sender, System.EventArgs e)
        {
            foreach(Course c in AdminOperations.CourseFunctions.GetAllConnectedCourses(InputCPQ.Text))
            {
                CPQDataGrid.Rows.Add(c.Name);
            }
        }
        private void CPQDataGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void AllCoursesGrid_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            AdminOperations.CourseFunctions.DeleteCourse(e.Row.Cells[0].Value as string);
        }
    }
}
