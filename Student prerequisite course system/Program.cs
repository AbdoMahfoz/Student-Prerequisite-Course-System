using System;
using System.Windows.Forms;

namespace Student_prerequisite_course_system
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Student_form());
            FileOperations.Write();
        }
    }
}
