namespace Student_prerequisite_course_system
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Home = new System.Windows.Forms.Panel();
            this.HomeCourseBox = new System.Windows.Forms.GroupBox();
            this.HomeCPQButton = new System.Windows.Forms.Button();
            this.HomeStudentsOfCourseButton = new System.Windows.Forms.Button();
            this.HomeAllCoursesButton = new System.Windows.Forms.Button();
            this.HomeStudentBox = new System.Windows.Forms.GroupBox();
            this.HomeCoursesOfStudentButton = new System.Windows.Forms.Button();
            this.HomeAllStudentsButton = new System.Windows.Forms.Button();
            this.CourseOverviewPanel = new System.Windows.Forms.Panel();
            this.AllCoursesGrid = new System.Windows.Forms.DataGridView();
            this.CO_NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CO_DescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DummyAllCoursesLabel = new System.Windows.Forms.Label();
            this.DummyAllStudentsLabel = new System.Windows.Forms.Label();
            this.StudentOverviewPanel = new System.Windows.Forms.Panel();
            this.AllStudentsGrid = new System.Windows.Forms.DataGridView();
            this.SO_IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SO_NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentsInCourse = new System.Windows.Forms.Panel();
            this.StudentsInCourseGrid = new System.Windows.Forms.DataGridView();
            this.SIC_IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SIC_NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoursesInStudent = new System.Windows.Forms.Panel();
            this.CoursesInStudentGrid = new System.Windows.Forms.DataGridView();
            this.CIS_NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIS_DescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentInCoursesGoButton = new System.Windows.Forms.Button();
            this.InputCoursesInStudent = new System.Windows.Forms.TextBox();
            this.DummyCoursesInStudentLabel = new System.Windows.Forms.Label();
            this.CoursesPrerequisites = new System.Windows.Forms.Panel();
            this.CPQDataGrid = new System.Windows.Forms.DataGridView();
            this.CPQ_NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InputCPQ = new System.Windows.Forms.TextBox();
            this.CPQGoButton = new System.Windows.Forms.Button();
            this.CPQDummyLabel = new System.Windows.Forms.Label();
            this.Home.SuspendLayout();
            this.HomeCourseBox.SuspendLayout();
            this.HomeStudentBox.SuspendLayout();
            this.CourseOverviewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllCoursesGrid)).BeginInit();
            this.StudentOverviewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllStudentsGrid)).BeginInit();
            this.StudentsInCourse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsInCourseGrid)).BeginInit();
            this.CoursesInStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CoursesInStudentGrid)).BeginInit();
            this.CoursesPrerequisites.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CPQDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Home
            // 
            this.Home.Controls.Add(this.HomeStudentBox);
            this.Home.Controls.Add(this.HomeCourseBox);
            this.Home.Location = new System.Drawing.Point(445, 0);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(132, 214);
            this.Home.TabIndex = 8;
            // 
            // HomeCourseBox
            // 
            this.HomeCourseBox.Controls.Add(this.HomeCPQButton);
            this.HomeCourseBox.Controls.Add(this.HomeStudentsOfCourseButton);
            this.HomeCourseBox.Controls.Add(this.HomeAllCoursesButton);
            this.HomeCourseBox.Location = new System.Drawing.Point(6, 98);
            this.HomeCourseBox.Name = "HomeCourseBox";
            this.HomeCourseBox.Size = new System.Drawing.Size(120, 113);
            this.HomeCourseBox.TabIndex = 0;
            this.HomeCourseBox.TabStop = false;
            this.HomeCourseBox.Text = "Courses";
            // 
            // HomeCPQButton
            // 
            this.HomeCPQButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeCPQButton.Location = new System.Drawing.Point(1, 77);
            this.HomeCPQButton.Name = "HomeCPQButton";
            this.HomeCPQButton.Size = new System.Drawing.Size(120, 23);
            this.HomeCPQButton.TabIndex = 2;
            this.HomeCPQButton.Text = "Set Prerequisites";
            this.HomeCPQButton.UseVisualStyleBackColor = true;
            // 
            // HomeStudentsOfCourseButton
            // 
            this.HomeStudentsOfCourseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeStudentsOfCourseButton.Location = new System.Drawing.Point(0, 48);
            this.HomeStudentsOfCourseButton.Name = "HomeStudentsOfCourseButton";
            this.HomeStudentsOfCourseButton.Size = new System.Drawing.Size(120, 23);
            this.HomeStudentsOfCourseButton.TabIndex = 1;
            this.HomeStudentsOfCourseButton.Text = "Students Of Course";
            this.HomeStudentsOfCourseButton.UseVisualStyleBackColor = true;
            this.HomeStudentsOfCourseButton.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // HomeAllCoursesButton
            // 
            this.HomeAllCoursesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeAllCoursesButton.Location = new System.Drawing.Point(1, 19);
            this.HomeAllCoursesButton.Name = "HomeAllCoursesButton";
            this.HomeAllCoursesButton.Size = new System.Drawing.Size(119, 23);
            this.HomeAllCoursesButton.TabIndex = 0;
            this.HomeAllCoursesButton.Text = "All Courses";
            this.HomeAllCoursesButton.UseVisualStyleBackColor = true;
            // 
            // HomeStudentBox
            // 
            this.HomeStudentBox.Controls.Add(this.HomeCoursesOfStudentButton);
            this.HomeStudentBox.Controls.Add(this.HomeAllStudentsButton);
            this.HomeStudentBox.Location = new System.Drawing.Point(6, 6);
            this.HomeStudentBox.Name = "HomeStudentBox";
            this.HomeStudentBox.Size = new System.Drawing.Size(120, 84);
            this.HomeStudentBox.TabIndex = 10;
            this.HomeStudentBox.TabStop = false;
            this.HomeStudentBox.Text = "Student";
            // 
            // HomeCoursesOfStudentButton
            // 
            this.HomeCoursesOfStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeCoursesOfStudentButton.Location = new System.Drawing.Point(-1, 48);
            this.HomeCoursesOfStudentButton.Name = "HomeCoursesOfStudentButton";
            this.HomeCoursesOfStudentButton.Size = new System.Drawing.Size(120, 23);
            this.HomeCoursesOfStudentButton.TabIndex = 1;
            this.HomeCoursesOfStudentButton.Text = "Courses Of Student";
            this.HomeCoursesOfStudentButton.UseVisualStyleBackColor = true;
            // 
            // HomeAllStudentsButton
            // 
            this.HomeAllStudentsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeAllStudentsButton.Location = new System.Drawing.Point(-1, 19);
            this.HomeAllStudentsButton.Name = "HomeAllStudentsButton";
            this.HomeAllStudentsButton.Size = new System.Drawing.Size(120, 23);
            this.HomeAllStudentsButton.TabIndex = 0;
            this.HomeAllStudentsButton.Text = "All Students";
            this.HomeAllStudentsButton.UseVisualStyleBackColor = true;
            // 
            // CourseOverviewPanel
            // 
            this.CourseOverviewPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CourseOverviewPanel.Controls.Add(this.AllCoursesGrid);
            this.CourseOverviewPanel.Controls.Add(this.DummyAllCoursesLabel);
            this.CourseOverviewPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseOverviewPanel.Location = new System.Drawing.Point(0, 0);
            this.CourseOverviewPanel.Name = "CourseOverviewPanel";
            this.CourseOverviewPanel.Size = new System.Drawing.Size(446, 214);
            this.CourseOverviewPanel.TabIndex = 10;
            this.CourseOverviewPanel.Visible = false;
            // 
            // AllCoursesGrid
            // 
            this.AllCoursesGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.AllCoursesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllCoursesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CO_NameColumn,
            this.CO_DescriptionColumn});
            this.AllCoursesGrid.Location = new System.Drawing.Point(1, 28);
            this.AllCoursesGrid.Name = "AllCoursesGrid";
            this.AllCoursesGrid.Size = new System.Drawing.Size(442, 183);
            this.AllCoursesGrid.TabIndex = 10;
            this.AllCoursesGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CO_NameColumn
            // 
            this.CO_NameColumn.HeaderText = "Course Name";
            this.CO_NameColumn.Name = "CO_NameColumn";
            // 
            // CO_DescriptionColumn
            // 
            this.CO_DescriptionColumn.HeaderText = "Course Description";
            this.CO_DescriptionColumn.Name = "CO_DescriptionColumn";
            this.CO_DescriptionColumn.Width = 299;
            // 
            // DummyAllCoursesLabel
            // 
            this.DummyAllCoursesLabel.AutoSize = true;
            this.DummyAllCoursesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DummyAllCoursesLabel.Location = new System.Drawing.Point(163, 9);
            this.DummyAllCoursesLabel.Name = "DummyAllCoursesLabel";
            this.DummyAllCoursesLabel.Size = new System.Drawing.Size(87, 16);
            this.DummyAllCoursesLabel.TabIndex = 9;
            this.DummyAllCoursesLabel.Text = "All Courses";
            // 
            // DummyAllStudentsLabel
            // 
            this.DummyAllStudentsLabel.AutoSize = true;
            this.DummyAllStudentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DummyAllStudentsLabel.Location = new System.Drawing.Point(176, 9);
            this.DummyAllStudentsLabel.Name = "DummyAllStudentsLabel";
            this.DummyAllStudentsLabel.Size = new System.Drawing.Size(90, 16);
            this.DummyAllStudentsLabel.TabIndex = 8;
            this.DummyAllStudentsLabel.Text = "All Students";
            // 
            // StudentOverviewPanel
            // 
            this.StudentOverviewPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StudentOverviewPanel.Controls.Add(this.AllStudentsGrid);
            this.StudentOverviewPanel.Controls.Add(this.DummyAllStudentsLabel);
            this.StudentOverviewPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentOverviewPanel.Location = new System.Drawing.Point(-2, 0);
            this.StudentOverviewPanel.Name = "StudentOverviewPanel";
            this.StudentOverviewPanel.Size = new System.Drawing.Size(450, 214);
            this.StudentOverviewPanel.TabIndex = 7;
            this.StudentOverviewPanel.Visible = false;
            this.StudentOverviewPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // AllStudentsGrid
            // 
            this.AllStudentsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllStudentsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SO_IDColumn,
            this.SO_NameColumn});
            this.AllStudentsGrid.Location = new System.Drawing.Point(3, 35);
            this.AllStudentsGrid.Name = "AllStudentsGrid";
            this.AllStudentsGrid.Size = new System.Drawing.Size(442, 176);
            this.AllStudentsGrid.TabIndex = 9;
            // 
            // SO_IDColumn
            // 
            this.SO_IDColumn.HeaderText = "ID";
            this.SO_IDColumn.Name = "SO_IDColumn";
            this.SO_IDColumn.Width = 50;
            // 
            // SO_NameColumn
            // 
            this.SO_NameColumn.HeaderText = "Student Name";
            this.SO_NameColumn.Name = "SO_NameColumn";
            this.SO_NameColumn.Width = 348;
            // 
            // StudentsInCourse
            // 
            this.StudentsInCourse.Controls.Add(this.StudentsInCourseGrid);
            this.StudentsInCourse.Location = new System.Drawing.Point(0, 0);
            this.StudentsInCourse.Name = "StudentsInCourse";
            this.StudentsInCourse.Size = new System.Drawing.Size(448, 214);
            this.StudentsInCourse.TabIndex = 11;
            this.StudentsInCourse.Visible = false;
            // 
            // StudentsInCourseGrid
            // 
            this.StudentsInCourseGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsInCourseGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SIC_IDColumn,
            this.SIC_NameColumn});
            this.StudentsInCourseGrid.Location = new System.Drawing.Point(3, 31);
            this.StudentsInCourseGrid.Name = "StudentsInCourseGrid";
            this.StudentsInCourseGrid.ReadOnly = true;
            this.StudentsInCourseGrid.Size = new System.Drawing.Size(442, 180);
            this.StudentsInCourseGrid.TabIndex = 3;
            // 
            // SIC_IDColumn
            // 
            this.SIC_IDColumn.HeaderText = "Student ID";
            this.SIC_IDColumn.Name = "SIC_IDColumn";
            this.SIC_IDColumn.ReadOnly = true;
            this.SIC_IDColumn.Width = 50;
            // 
            // SIC_NameColumn
            // 
            this.SIC_NameColumn.HeaderText = "Student Name";
            this.SIC_NameColumn.Name = "SIC_NameColumn";
            this.SIC_NameColumn.ReadOnly = true;
            this.SIC_NameColumn.Width = 348;
            // 
            // CoursesInStudent
            // 
            this.CoursesInStudent.Controls.Add(this.CoursesInStudentGrid);
            this.CoursesInStudent.Controls.Add(this.StudentInCoursesGoButton);
            this.CoursesInStudent.Controls.Add(this.InputCoursesInStudent);
            this.CoursesInStudent.Controls.Add(this.DummyCoursesInStudentLabel);
            this.CoursesInStudent.Location = new System.Drawing.Point(0, 0);
            this.CoursesInStudent.Name = "CoursesInStudent";
            this.CoursesInStudent.Size = new System.Drawing.Size(448, 214);
            this.CoursesInStudent.TabIndex = 0;
            this.CoursesInStudent.Visible = false;
            // 
            // CoursesInStudentGrid
            // 
            this.CoursesInStudentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CoursesInStudentGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIS_NameColumn,
            this.CIS_DescriptionColumn});
            this.CoursesInStudentGrid.Location = new System.Drawing.Point(1, 28);
            this.CoursesInStudentGrid.Name = "CoursesInStudentGrid";
            this.CoursesInStudentGrid.ReadOnly = true;
            this.CoursesInStudentGrid.Size = new System.Drawing.Size(447, 186);
            this.CoursesInStudentGrid.TabIndex = 3;
            // 
            // CIS_NameColumn
            // 
            this.CIS_NameColumn.HeaderText = "Course Name";
            this.CIS_NameColumn.Name = "CIS_NameColumn";
            this.CIS_NameColumn.ReadOnly = true;
            // 
            // CIS_DescriptionColumn
            // 
            this.CIS_DescriptionColumn.HeaderText = "Course Description";
            this.CIS_DescriptionColumn.Name = "CIS_DescriptionColumn";
            this.CIS_DescriptionColumn.ReadOnly = true;
            this.CIS_DescriptionColumn.Width = 304;
            // 
            // StudentInCoursesGoButton
            // 
            this.StudentInCoursesGoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentInCoursesGoButton.Location = new System.Drawing.Point(300, 3);
            this.StudentInCoursesGoButton.Name = "StudentInCoursesGoButton";
            this.StudentInCoursesGoButton.Size = new System.Drawing.Size(75, 23);
            this.StudentInCoursesGoButton.TabIndex = 2;
            this.StudentInCoursesGoButton.Text = "Go";
            this.StudentInCoursesGoButton.UseVisualStyleBackColor = true;
            // 
            // InputCoursesInStudent
            // 
            this.InputCoursesInStudent.Location = new System.Drawing.Point(194, 5);
            this.InputCoursesInStudent.Name = "InputCoursesInStudent";
            this.InputCoursesInStudent.Size = new System.Drawing.Size(100, 20);
            this.InputCoursesInStudent.TabIndex = 1;
            // 
            // DummyCoursesInStudentLabel
            // 
            this.DummyCoursesInStudentLabel.AutoSize = true;
            this.DummyCoursesInStudentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DummyCoursesInStudentLabel.Location = new System.Drawing.Point(83, 5);
            this.DummyCoursesInStudentLabel.Name = "DummyCoursesInStudentLabel";
            this.DummyCoursesInStudentLabel.Size = new System.Drawing.Size(105, 16);
            this.DummyCoursesInStudentLabel.TabIndex = 0;
            this.DummyCoursesInStudentLabel.Text = "Student Name";
            // 
            // CoursesPrerequisites
            // 
            this.CoursesPrerequisites.Controls.Add(this.CPQDataGrid);
            this.CoursesPrerequisites.Controls.Add(this.InputCPQ);
            this.CoursesPrerequisites.Controls.Add(this.CPQGoButton);
            this.CoursesPrerequisites.Controls.Add(this.CPQDummyLabel);
            this.CoursesPrerequisites.Location = new System.Drawing.Point(0, 0);
            this.CoursesPrerequisites.Name = "CoursesPrerequisites";
            this.CoursesPrerequisites.Size = new System.Drawing.Size(448, 214);
            this.CoursesPrerequisites.TabIndex = 12;
            this.CoursesPrerequisites.Visible = false;
            // 
            // CPQDataGrid
            // 
            this.CPQDataGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.CPQDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CPQDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CPQ_NameColumn});
            this.CPQDataGrid.Location = new System.Drawing.Point(251, 3);
            this.CPQDataGrid.Name = "CPQDataGrid";
            this.CPQDataGrid.Size = new System.Drawing.Size(194, 208);
            this.CPQDataGrid.TabIndex = 3;
            // 
            // CPQ_NameColumn
            // 
            this.CPQ_NameColumn.HeaderText = "Course Name";
            this.CPQ_NameColumn.Name = "CPQ_NameColumn";
            this.CPQ_NameColumn.Width = 150;
            // 
            // InputCPQ
            // 
            this.InputCPQ.Location = new System.Drawing.Point(29, 73);
            this.InputCPQ.Name = "InputCPQ";
            this.InputCPQ.Size = new System.Drawing.Size(185, 20);
            this.InputCPQ.TabIndex = 2;
            // 
            // CPQGoButton
            // 
            this.CPQGoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPQGoButton.Location = new System.Drawing.Point(82, 117);
            this.CPQGoButton.Name = "CPQGoButton";
            this.CPQGoButton.Size = new System.Drawing.Size(75, 23);
            this.CPQGoButton.TabIndex = 1;
            this.CPQGoButton.Text = "Go";
            this.CPQGoButton.UseVisualStyleBackColor = true;
            // 
            // CPQDummyLabel
            // 
            this.CPQDummyLabel.AutoSize = true;
            this.CPQDummyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPQDummyLabel.Location = new System.Drawing.Point(26, 31);
            this.CPQDummyLabel.Name = "CPQDummyLabel";
            this.CPQDummyLabel.Size = new System.Drawing.Size(106, 16);
            this.CPQDummyLabel.TabIndex = 0;
            this.CPQDummyLabel.Text = "Course Name:";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(577, 214);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.StudentsInCourse);
            this.Controls.Add(this.StudentOverviewPanel);
            this.Controls.Add(this.CoursesPrerequisites);
            this.Controls.Add(this.CourseOverviewPanel);
            this.Controls.Add(this.CoursesInStudent);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "AdminForm";
            this.Text = "Admin Control";
            this.Home.ResumeLayout(false);
            this.HomeCourseBox.ResumeLayout(false);
            this.HomeStudentBox.ResumeLayout(false);
            this.CourseOverviewPanel.ResumeLayout(false);
            this.CourseOverviewPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllCoursesGrid)).EndInit();
            this.StudentOverviewPanel.ResumeLayout(false);
            this.StudentOverviewPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllStudentsGrid)).EndInit();
            this.StudentsInCourse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StudentsInCourseGrid)).EndInit();
            this.CoursesInStudent.ResumeLayout(false);
            this.CoursesInStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CoursesInStudentGrid)).EndInit();
            this.CoursesPrerequisites.ResumeLayout(false);
            this.CoursesPrerequisites.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CPQDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Home;
        private System.Windows.Forms.Panel CourseOverviewPanel;
        private System.Windows.Forms.DataGridView AllCoursesGrid;
        private System.Windows.Forms.Label DummyAllCoursesLabel;
        private System.Windows.Forms.Label DummyAllStudentsLabel;
        private System.Windows.Forms.Panel StudentOverviewPanel;
        private System.Windows.Forms.DataGridView AllStudentsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn SO_IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SO_NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CO_NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CO_DescriptionColumn;
        private System.Windows.Forms.Panel StudentsInCourse;
        private System.Windows.Forms.Panel CoursesInStudent;
        private System.Windows.Forms.GroupBox HomeCourseBox;
        private System.Windows.Forms.GroupBox HomeStudentBox;
        private System.Windows.Forms.Button HomeCoursesOfStudentButton;
        private System.Windows.Forms.Button HomeAllStudentsButton;
        private System.Windows.Forms.Button HomeStudentsOfCourseButton;
        private System.Windows.Forms.Button HomeAllCoursesButton;
        private System.Windows.Forms.DataGridView CoursesInStudentGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIS_NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIS_DescriptionColumn;
        private System.Windows.Forms.Button StudentInCoursesGoButton;
        private System.Windows.Forms.TextBox InputCoursesInStudent;
        private System.Windows.Forms.Label DummyCoursesInStudentLabel;
        private System.Windows.Forms.DataGridView StudentsInCourseGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn SIC_IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SIC_NameColumn;
        private System.Windows.Forms.Panel CoursesPrerequisites;
        private System.Windows.Forms.DataGridView CPQDataGrid;
        private System.Windows.Forms.TextBox InputCPQ;
        private System.Windows.Forms.Button CPQGoButton;
        private System.Windows.Forms.Label CPQDummyLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPQ_NameColumn;
        private System.Windows.Forms.Button HomeCPQButton;
    }
}

