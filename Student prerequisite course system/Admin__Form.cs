using System.Windows.Forms;

public partial class AdminForm : Form
{
    //Fields
    Panel activePanel;
    Button ActiveButton;
    //Properties
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
    //Constructor
    public AdminForm()
    {
        InitializeComponent();
    }
    //Login
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
    //All Courses
    private void CourseOverviewPanel_VisibleChanged(object sender, System.EventArgs e)
    {
        if (CourseOverviewPanel.Visible)
        {
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
        bool IsNewRow = false;
        if (e.RowIndex == AdminOperations.CourseFunctions.Courses.Count)
        {
            IsNewRow = true;
        }
        foreach (Course c in AdminOperations.CourseFunctions.Courses)
        {
            if ((IsNewRow || AdminOperations.CourseFunctions.Courses[e.RowIndex] != c) && c.Name == AllCoursesGrid.Rows[e.RowIndex].Cells[0].Value as string)
            {
                MessageBox.Show("No");
                if (IsNewRow)
                {
                    AllCoursesGrid.Rows.RemoveAt(AllCoursesGrid.Rows.Count - 2);
                }
                else
                {
                    AllCoursesGrid.Rows[e.RowIndex].Cells[0].Value = AdminOperations.CourseFunctions.Courses[e.RowIndex].Name;
                }
                return;
            }
        }
        if((AllCoursesGrid.Rows[e.RowIndex].Cells[0].Value as string).Contains(" "))
        {
            MessageBox.Show("Course name cannot contain white spaces");
            if (IsNewRow)
            {
                AllCoursesGrid.Rows.RemoveAt(AllCoursesGrid.Rows.Count - 2);
            }
            else
            {
                AllCoursesGrid.Rows[e.RowIndex].Cells[0].Value = AdminOperations.CourseFunctions.Courses[e.RowIndex].Name;
            }
        }
        if (IsNewRow)
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
    private void AllCoursesGrid_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
    {
        AdminOperations.CourseFunctions.DeleteCourse(e.Row.Cells[0].Value as string);
    }
    //All Students
    private void StudentOverviewPanel_VisibleChanged(object sender, System.EventArgs e)
    {
        AllStudentsGrid.Rows.Clear();
        if (AdminOperations.StudentFunctions.AllStudents == null)
        {
            return;
        }
        foreach (Student s in AdminOperations.StudentFunctions.AllStudents)
        {
            AllStudentsGrid.Rows.Add(s.ID.ToString(), s.Name, s.Password, s.AcademicYear);
        }
    }
    private void AllStudentsGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex == -1) return;
        bool IsNewRow = false;
        if (AdminOperations.StudentFunctions.AllStudents == null || e.RowIndex == AdminOperations.StudentFunctions.AllStudents.Length)
        {
            IsNewRow = true;
        }
        if (!int.TryParse(AllStudentsGrid.Rows[e.RowIndex].Cells[0].Value as string, out int ID))
        {
            MessageBox.Show("ID has to be an integer number");
            if (!IsNewRow)
            {
                AllStudentsGrid.Rows[e.RowIndex].Cells[0].Value = AdminOperations.StudentFunctions.AllStudents[e.RowIndex].ID.ToString();
            }
            else
            {
                AllStudentsGrid.Rows.RemoveAt(AllStudentsGrid.Rows.Count - 2);
            }
            return;
        }
        foreach (Student s in AdminOperations.StudentFunctions.AllStudents)
        {
            if ((IsNewRow || AdminOperations.StudentFunctions.AllStudents[e.RowIndex] != s) && s.ID == ID)
            {
                MessageBox.Show("Same ID already exists");
                if (IsNewRow)
                {
                    AllStudentsGrid.Rows.RemoveAt(AllStudentsGrid.Rows.Count - 2);
                }
                else
                {
                    AllStudentsGrid.Rows[e.RowIndex].Cells[0].Value = AdminOperations.StudentFunctions.AllStudents[e.RowIndex].ID.ToString();
                }
                return;
            }
        }
        if (IsNewRow)
        {
            AdminOperations.StudentFunctions.AddStudent(new Student()
            {
                ID = ID,
                Name = AllStudentsGrid.Rows[e.RowIndex].Cells[1].Value as string,
                Password = AllStudentsGrid.Rows[e.RowIndex].Cells[2].Value as string,
                AcademicYear = AllStudentsGrid.Rows[e.RowIndex].Cells[3].Value as string,
                RegisteredCourses = new ArrayList<Pair<bool, Course>>()
            });
        }
        else
        {
            AdminOperations.StudentFunctions.AllStudents[e.RowIndex].ID = ID;
            AdminOperations.StudentFunctions.AllStudents[e.RowIndex].Name = AllStudentsGrid.Rows[e.RowIndex].Cells[1].Value as string;
            AdminOperations.StudentFunctions.AllStudents[e.RowIndex].Password = AllStudentsGrid.Rows[e.RowIndex].Cells[2].Value as string;
            AdminOperations.StudentFunctions.AllStudents[e.RowIndex].AcademicYear = AllStudentsGrid.Rows[e.RowIndex].Cells[3].Value as string;
        }
    }
    private void AllStudentsGrid_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
    {
        AdminOperations.StudentFunctions.DeleteStudent(AdminOperations.StudentFunctions.AllStudents[e.Row.Index]);
    }
    //Course Prerequisites
    private void CoursesPrerequisites_VisibleChanged(object sender, System.EventArgs e)
    {
        CPQDataGrid.Rows.Clear();
        InputCPQ.Text = "";
        CPQAddButton.Enabled = false;
        CPQActiveCourseLabel.Text = "null";
    }
    private void CPQGoButton_Click(object sender, System.EventArgs e)
    {
        CPQDataGrid.Rows.Clear();
        Course[] childs = AdminOperations.CourseFunctions.GetAllConnectedCourses(InputCPQ.Text);
        if (childs == null)
        {
            MessageBox.Show("Course non existant");
            CPQActiveCourseLabel.Text = "null";
            CPQAddInputTextBox.Text = "";
            CPQAddButton.Enabled = false;
            return;
        }
        CPQAddButton.Enabled = true;
        CPQActiveCourseLabel.Text = InputCPQ.Text;
        InputCPQ.Text = "";
        foreach (Course c in childs)
        {
            CPQDataGrid.Rows.Add(c.Name);
        }
    }
    private void CPQAddButton_Click(object sender, System.EventArgs e)
    {
        if (!AdminOperations.CourseFunctions.ConnectCourses(CPQActiveCourseLabel.Text, CPQAddInputTextBox.Text))
        {
            MessageBox.Show("Course is non existant");
        }
        else
        {
            CPQDataGrid.Rows.Add(CPQAddInputTextBox.Text);
        }
        CPQAddInputTextBox.Text = "";
    }
    private void CPQDataGrid_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
    {
        AdminOperations.CourseFunctions.DisconnectCourses(CPQActiveCourseLabel.Text, e.Row.Cells[0].Value as string);
    }
    //Courses in Student
    Student ActiveStudent;
    private void CoursesInStudentGoButton_Click(object sender, System.EventArgs e)
    {
        CoursesInStudentGrid.Rows.Clear();
        foreach(Student s in AdminOperations.StudentFunctions.AllStudents)
        {
            if(s.ID == InputCoursesInStudent.Value)
            {
                ActiveStudent = s;
                foreach(Pair<bool, Course> p in s.RegisteredCourses)
                {
                    CoursesInStudentGrid.Rows.Add(p.Second.Name, p.First);
                }
                return;
            }
        }
        MessageBox.Show("Student ID nonexistant");
        InputCoursesInStudent.Value = 0;
    }
    private void CoursesInStudent_VisibleChanged(object sender, System.EventArgs e)
    {
        if(CoursesInStudentGrid.Visible)
        {
            CoursesInStudentGrid.Rows.Clear();
        }
    }
    private void CoursesInStudentGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex == -1) return;
        foreach(Pair<bool, Course> P in ActiveStudent.RegisteredCourses)
        {
            if(P.Second.Name == CoursesInStudentGrid.Rows[e.RowIndex].Cells[0].Value as string)
            {
                P.First = (bool)CoursesInStudentGrid.Rows[e.RowIndex].Cells[1].Value;
            }
        }
    }
    //Students in Course
    private void StudentsInCourseGoButton_Click(object sender, System.EventArgs e)
    {
        StudentsInCourseGrid.Rows.Clear();
        foreach (Course c in AdminOperations.CourseFunctions.Courses)
        {
            if (c.Name == InputStudentsInCourse.Text)
            {
                foreach(Student s in AdminOperations.CourseFunctions.GetStudentsEnrolledInCourse(c))
                {
                    StudentsInCourseGrid.Rows.Add(s.ID.ToString(), s.Name);
                }
                return;
            }
        }
        MessageBox.Show("Course Non Existant");
        InputStudentsInCourse.Text = "";
    }
    private void StudentsInCourse_VisibleChanged(object sender, System.EventArgs e)
    {
        InputStudentsInCourse.Text = "";
        StudentsInCourseGrid.Rows.Clear();
    }
}
