using System;
using System.Windows.Forms;
using System.Drawing;

class AllCoursesView : CourseView
{
    Button RegsiterButton;
    Student ActiveStudent;
    public AllCoursesView(string CourseName, string CourseDescription, int offset, bool IsAvail, Panel ParentPanel, Student stud) : base(CourseName, CourseDescription, offset, ParentPanel)
    {
        ActiveStudent = stud;
        RegsiterButton = new Button()
        {
            Text = "Register",
            Location = new Point(435, 1 + offset),
            Enabled = IsAvail
        };
        RegsiterButton.Click += RegsiterButton_Click;
        Draw();
    }
    private void RegsiterButton_Click(object sender, EventArgs e)
    {
        Course c = FileOperations.CoursesFile.GetCourse(Name);
        ActiveStudent.RegisteredCourses.Append(new Pair<bool, Course>()
        {
            First = false,
            Second = c
        });
        FileOperations.Subjects_UsersFile.UpdateSubject(c, ActiveStudent);
        RegsiterButton.Enabled = false;
    }
    public override void Draw()
    {
        if (!IsDrawn)
        {
            base.Draw();
        }
        ParentPanel.Controls.Add(RegsiterButton);
    }
    public override void Clear()
    {
        base.Clear();
        ParentPanel.Controls.Remove(RegsiterButton);
    }
    public override void ResetLocation(int offset)
    {
        base.ResetLocation(offset);
        RegsiterButton.Location = new Point(50, 1 + offset);
    }
}
