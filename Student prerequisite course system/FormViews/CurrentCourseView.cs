using System;
using System.Windows.Forms;
using System.Drawing;

public class CurrentCourseView : CourseView
{
    Label StateLabel;
    Button UnRegister;
    Student ActiveStudent;
    Student_form ParentForm;
    public CurrentCourseView(string CourseName, string CourseDescription, int offset, bool State, Panel ParentPanel, Student_form form, Student student) : base(CourseName, CourseDescription, offset, ParentPanel)
    {
        ActiveStudent = student;
        ParentForm = form;
        string StateText;
        if (State)
        {
            StateText = "Finished";
        }
        else
        {
            StateText = "In Progress";
            UnRegister = new Button()
            {
                Text = "Un Register",
                Location = new Point(340, 1 + offset)
            };
            UnRegister.Click += UnRegister_Click;
        }
        StateLabel = new Label()
        {
            Text = StateText,
            Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold),
            Location = new Point(420, 1 + offset),
            Size = new Size(500, 25)
        };
        Draw();
    }
    private void UnRegister_Click(object sender, EventArgs e)
    {
        for (int i = 0; i < ActiveStudent.RegisteredCourses.Count; i++)
        {
            if (ActiveStudent.RegisteredCourses[i].Second.Name == Name)
            {
                FileOperations.Subjects_UsersFile.DeleteStudentFromCourse(FileOperations.CoursesFile.GetCourse(Name), ActiveStudent);
                ActiveStudent.RegisteredCourses.DeleteAt(i);
                ParentForm.RefreshCurrent(Name);
                break;
            }
        }
    }
    public override void Draw()
    {
        if (!IsDrawn)
        {
            base.Draw();
        }
        ParentPanel.Controls.Add(StateLabel);
        if (UnRegister != null)
        {
            ParentPanel.Controls.Add(UnRegister);
        }
    }
    public override void Clear()
    {
        base.Clear();
        ParentPanel.Controls.Remove(StateLabel);
        if (UnRegister != null)
        {
            ParentPanel.Controls.Remove(UnRegister);
        }
    }
    public override void ResetLocation(int offset)
    {
        base.ResetLocation(offset);
        StateLabel.Location = new Point(420, 1 + offset);
        if (UnRegister != null)
        {
            UnRegister.Location = new Point(340, 1 + offset);
        }
    }
}
