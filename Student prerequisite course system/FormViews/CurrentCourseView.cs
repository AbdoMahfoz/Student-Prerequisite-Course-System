using System;
using System.Windows.Forms;
using System.Drawing;

public class CurrentCourseView : CourseView
{
    Label StateLabel;
    public CurrentCourseView(string CourseName, string CourseDescription, int offset, bool State, Panel ParentPanel) : base(CourseName, CourseDescription, offset, ParentPanel)
    {
        string StateText;
        if(State)
        {
            StateText = "Finished";
        }
        else
        {
            StateText = "In Progress";
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
    public override void Draw()
    {
        if(!IsDrawn)
        {
            base.Draw();
        }
        ParentPanel.Controls.Add(StateLabel);
    }
    public override void Clear()
    {
        base.Clear();
        ParentPanel.Controls.Remove(StateLabel);
    }
    public override void ResetLocation(int offset)
    {
        base.ResetLocation(offset);
        StateLabel.Location = new Point(50, 1 + offset);
    }
}
