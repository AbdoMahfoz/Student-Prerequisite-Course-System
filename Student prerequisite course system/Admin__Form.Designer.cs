
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.Home = new System.Windows.Forms.Panel();
            this.HomeStudentBox = new System.Windows.Forms.GroupBox();
            this.HomeCoursesOfStudentButton = new System.Windows.Forms.Button();
            this.HomeAllStudentsButton = new System.Windows.Forms.Button();
            this.HomeCourseBox = new System.Windows.Forms.GroupBox();
            this.HomeCPQButton = new System.Windows.Forms.Button();
            this.HomeStudentsOfCourseButton = new System.Windows.Forms.Button();
            this.HomeAllCoursesButton = new System.Windows.Forms.Button();
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
            this.SO_PasswordColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SO_YearColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentsInCourse = new System.Windows.Forms.Panel();
            this.StudentsInCourseGoButton = new System.Windows.Forms.Button();
            this.InputStudentsInCourse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StudentsInCourseGrid = new System.Windows.Forms.DataGridView();
            this.SIC_IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SIC_NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoursesPrerequisites = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.CPQActiveBox = new System.Windows.Forms.GroupBox();
            this.CPQActiveCourseLabel = new System.Windows.Forms.Label();
            this.CPQDummyActiveCourseLabel = new System.Windows.Forms.Label();
            this.CPQDummyLabel = new System.Windows.Forms.Label();
            this.InputCPQ = new System.Windows.Forms.TextBox();
            this.CPQGoButton = new System.Windows.Forms.Button();
            this.CPQGroupBox = new System.Windows.Forms.GroupBox();
            this.DummyCourseNameInBoxLabel = new System.Windows.Forms.Label();
            this.CPQAddButton = new System.Windows.Forms.Button();
            this.CPQAddInputTextBox = new System.Windows.Forms.TextBox();
            this.CPQDataGrid = new System.Windows.Forms.DataGridView();
            this.CPQ_NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoursesInStudent = new System.Windows.Forms.Panel();
            this.InputCoursesInStudent = new System.Windows.Forms.NumericUpDown();
            this.CoursesInStudentGrid = new System.Windows.Forms.DataGridView();
            this.CIS_NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SIC_StatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoursesInStudentGoButton = new System.Windows.Forms.Button();
            this.DummyCoursesInStudentLabel = new System.Windows.Forms.Label();
            this.LogIn = new System.Windows.Forms.Panel();
            this.LoginButton = new System.Windows.Forms.Button();
            this.PasswordPlaceHolder = new System.Windows.Forms.Panel();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.DumyyPasswordPicture = new System.Windows.Forms.Panel();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UserNamePlaceHolder = new System.Windows.Forms.Panel();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.DumyyUserPicture = new System.Windows.Forms.Panel();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.BigUserPicture = new System.Windows.Forms.Panel();
            this.Home.SuspendLayout();
            this.HomeStudentBox.SuspendLayout();
            this.HomeCourseBox.SuspendLayout();
            this.CourseOverviewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllCoursesGrid)).BeginInit();
            this.StudentOverviewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllStudentsGrid)).BeginInit();
            this.StudentsInCourse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsInCourseGrid)).BeginInit();
            this.CoursesPrerequisites.SuspendLayout();
            this.CPQActiveBox.SuspendLayout();
            this.CPQGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CPQDataGrid)).BeginInit();
            this.CoursesInStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputCoursesInStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoursesInStudentGrid)).BeginInit();
            this.LogIn.SuspendLayout();
            this.PasswordPlaceHolder.SuspendLayout();
            this.UserNamePlaceHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // Home
            // 
            this.Home.Controls.Add(this.HomeStudentBox);
            this.Home.Controls.Add(this.HomeCourseBox);
            this.Home.Location = new System.Drawing.Point(449, 0);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(127, 214);
            this.Home.TabIndex = 8;
            this.Home.Visible = false;
            // 
            // HomeStudentBox
            // 
            this.HomeStudentBox.Controls.Add(this.HomeCoursesOfStudentButton);
            this.HomeStudentBox.Controls.Add(this.HomeAllStudentsButton);
            this.HomeStudentBox.Location = new System.Drawing.Point(5, 9);
            this.HomeStudentBox.Name = "HomeStudentBox";
            this.HomeStudentBox.Size = new System.Drawing.Size(120, 84);
            this.HomeStudentBox.TabIndex = 10;
            this.HomeStudentBox.TabStop = false;
            this.HomeStudentBox.Text = "Student";
            // 
            // HomeCoursesOfStudentButton
            // 
            this.HomeCoursesOfStudentButton.BackColor = System.Drawing.Color.Transparent;
            this.HomeCoursesOfStudentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeCoursesOfStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeCoursesOfStudentButton.Location = new System.Drawing.Point(-1, 48);
            this.HomeCoursesOfStudentButton.Name = "HomeCoursesOfStudentButton";
            this.HomeCoursesOfStudentButton.Size = new System.Drawing.Size(120, 23);
            this.HomeCoursesOfStudentButton.TabIndex = 1;
            this.HomeCoursesOfStudentButton.Text = "Courses Of Student";
            this.HomeCoursesOfStudentButton.UseVisualStyleBackColor = false;
            this.HomeCoursesOfStudentButton.Click += new System.EventHandler(this.HomeButtonClick);
            // 
            // HomeAllStudentsButton
            // 
            this.HomeAllStudentsButton.BackColor = System.Drawing.Color.Transparent;
            this.HomeAllStudentsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeAllStudentsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeAllStudentsButton.Location = new System.Drawing.Point(-1, 19);
            this.HomeAllStudentsButton.Name = "HomeAllStudentsButton";
            this.HomeAllStudentsButton.Size = new System.Drawing.Size(120, 23);
            this.HomeAllStudentsButton.TabIndex = 0;
            this.HomeAllStudentsButton.Text = "All Students";
            this.HomeAllStudentsButton.UseVisualStyleBackColor = false;
            this.HomeAllStudentsButton.Click += new System.EventHandler(this.HomeButtonClick);
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
            this.HomeCPQButton.BackColor = System.Drawing.Color.Transparent;
            this.HomeCPQButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeCPQButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeCPQButton.Location = new System.Drawing.Point(1, 77);
            this.HomeCPQButton.Name = "HomeCPQButton";
            this.HomeCPQButton.Size = new System.Drawing.Size(120, 23);
            this.HomeCPQButton.TabIndex = 2;
            this.HomeCPQButton.Text = "Set Prerequisites";
            this.HomeCPQButton.UseVisualStyleBackColor = false;
            this.HomeCPQButton.Click += new System.EventHandler(this.HomeButtonClick);
            // 
            // HomeStudentsOfCourseButton
            // 
            this.HomeStudentsOfCourseButton.BackColor = System.Drawing.Color.Transparent;
            this.HomeStudentsOfCourseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeStudentsOfCourseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeStudentsOfCourseButton.Location = new System.Drawing.Point(0, 48);
            this.HomeStudentsOfCourseButton.Name = "HomeStudentsOfCourseButton";
            this.HomeStudentsOfCourseButton.Size = new System.Drawing.Size(120, 23);
            this.HomeStudentsOfCourseButton.TabIndex = 1;
            this.HomeStudentsOfCourseButton.Text = "Students Of Course";
            this.HomeStudentsOfCourseButton.UseVisualStyleBackColor = false;
            this.HomeStudentsOfCourseButton.Click += new System.EventHandler(this.HomeButtonClick);
            // 
            // HomeAllCoursesButton
            // 
            this.HomeAllCoursesButton.BackColor = System.Drawing.Color.Transparent;
            this.HomeAllCoursesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeAllCoursesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeAllCoursesButton.Location = new System.Drawing.Point(1, 19);
            this.HomeAllCoursesButton.Name = "HomeAllCoursesButton";
            this.HomeAllCoursesButton.Size = new System.Drawing.Size(119, 23);
            this.HomeAllCoursesButton.TabIndex = 0;
            this.HomeAllCoursesButton.Text = "All Courses";
            this.HomeAllCoursesButton.UseVisualStyleBackColor = false;
            this.HomeAllCoursesButton.Click += new System.EventHandler(this.HomeButtonClick);
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
            this.CourseOverviewPanel.VisibleChanged += new System.EventHandler(this.CourseOverviewPanel_VisibleChanged);
            // 
            // AllCoursesGrid
            // 
            this.AllCoursesGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AllCoursesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllCoursesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CO_NameColumn,
            this.CO_DescriptionColumn});
            this.AllCoursesGrid.Location = new System.Drawing.Point(1, 28);
            this.AllCoursesGrid.Name = "AllCoursesGrid";
            this.AllCoursesGrid.Size = new System.Drawing.Size(442, 183);
            this.AllCoursesGrid.TabIndex = 10;
            this.AllCoursesGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.AllCoursesGrid_CellValueChanged);
            this.AllCoursesGrid.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.AllCoursesGrid_UserDeletingRow);
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
            this.StudentOverviewPanel.VisibleChanged += new System.EventHandler(this.StudentOverviewPanel_VisibleChanged);
            // 
            // AllStudentsGrid
            // 
            this.AllStudentsGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AllStudentsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllStudentsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SO_IDColumn,
            this.SO_NameColumn,
            this.SO_PasswordColumn,
            this.SO_YearColumn});
            this.AllStudentsGrid.Location = new System.Drawing.Point(3, 35);
            this.AllStudentsGrid.Name = "AllStudentsGrid";
            this.AllStudentsGrid.Size = new System.Drawing.Size(442, 176);
            this.AllStudentsGrid.TabIndex = 9;
            this.AllStudentsGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.AllStudentsGrid_CellValueChanged);
            this.AllStudentsGrid.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.AllStudentsGrid_UserDeletingRow);
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
            this.SO_NameColumn.Width = 148;
            // 
            // SO_PasswordColumn
            // 
            this.SO_PasswordColumn.HeaderText = "Password";
            this.SO_PasswordColumn.Name = "SO_PasswordColumn";
            // 
            // SO_YearColumn
            // 
            this.SO_YearColumn.HeaderText = "Acadmic Year";
            this.SO_YearColumn.Name = "SO_YearColumn";
            // 
            // StudentsInCourse
            // 
            this.StudentsInCourse.Controls.Add(this.StudentsInCourseGoButton);
            this.StudentsInCourse.Controls.Add(this.InputStudentsInCourse);
            this.StudentsInCourse.Controls.Add(this.label1);
            this.StudentsInCourse.Controls.Add(this.StudentsInCourseGrid);
            this.StudentsInCourse.Location = new System.Drawing.Point(0, 0);
            this.StudentsInCourse.Name = "StudentsInCourse";
            this.StudentsInCourse.Size = new System.Drawing.Size(448, 214);
            this.StudentsInCourse.TabIndex = 11;
            this.StudentsInCourse.Visible = false;
            this.StudentsInCourse.VisibleChanged += new System.EventHandler(this.StudentsInCourse_VisibleChanged);
            // 
            // StudentsInCourseGoButton
            // 
            this.StudentsInCourseGoButton.BackColor = System.Drawing.Color.Transparent;
            this.StudentsInCourseGoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StudentsInCourseGoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentsInCourseGoButton.Location = new System.Drawing.Point(282, 7);
            this.StudentsInCourseGoButton.Name = "StudentsInCourseGoButton";
            this.StudentsInCourseGoButton.Size = new System.Drawing.Size(52, 23);
            this.StudentsInCourseGoButton.TabIndex = 6;
            this.StudentsInCourseGoButton.Text = "Go";
            this.StudentsInCourseGoButton.UseVisualStyleBackColor = false;
            this.StudentsInCourseGoButton.Click += new System.EventHandler(this.StudentsInCourseGoButton_Click);
            // 
            // InputStudentsInCourse
            // 
            this.InputStudentsInCourse.Location = new System.Drawing.Point(164, 7);
            this.InputStudentsInCourse.Name = "InputStudentsInCourse";
            this.InputStudentsInCourse.Size = new System.Drawing.Size(100, 20);
            this.InputStudentsInCourse.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Course Name";
            // 
            // StudentsInCourseGrid
            // 
            this.StudentsInCourseGrid.AllowUserToAddRows = false;
            this.StudentsInCourseGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
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
            // CoursesPrerequisites
            // 
            this.CoursesPrerequisites.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CoursesPrerequisites.Controls.Add(this.label2);
            this.CoursesPrerequisites.Controls.Add(this.CPQActiveBox);
            this.CoursesPrerequisites.Controls.Add(this.CPQGroupBox);
            this.CoursesPrerequisites.Controls.Add(this.CPQDataGrid);
            this.CoursesPrerequisites.Location = new System.Drawing.Point(0, 0);
            this.CoursesPrerequisites.Name = "CoursesPrerequisites";
            this.CoursesPrerequisites.Size = new System.Drawing.Size(448, 214);
            this.CoursesPrerequisites.TabIndex = 12;
            this.CoursesPrerequisites.Visible = false;
            this.CoursesPrerequisites.VisibleChanged += new System.EventHandler(this.CoursesPrerequisites_VisibleChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(225, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Courses Connected To Active Course";
            // 
            // CPQActiveBox
            // 
            this.CPQActiveBox.Controls.Add(this.CPQActiveCourseLabel);
            this.CPQActiveBox.Controls.Add(this.CPQDummyActiveCourseLabel);
            this.CPQActiveBox.Controls.Add(this.CPQDummyLabel);
            this.CPQActiveBox.Controls.Add(this.InputCPQ);
            this.CPQActiveBox.Controls.Add(this.CPQGoButton);
            this.CPQActiveBox.Location = new System.Drawing.Point(8, 6);
            this.CPQActiveBox.Name = "CPQActiveBox";
            this.CPQActiveBox.Size = new System.Drawing.Size(216, 90);
            this.CPQActiveBox.TabIndex = 7;
            this.CPQActiveBox.TabStop = false;
            this.CPQActiveBox.Text = "State";
            // 
            // CPQActiveCourseLabel
            // 
            this.CPQActiveCourseLabel.AutoSize = true;
            this.CPQActiveCourseLabel.Location = new System.Drawing.Point(89, 17);
            this.CPQActiveCourseLabel.Name = "CPQActiveCourseLabel";
            this.CPQActiveCourseLabel.Size = new System.Drawing.Size(23, 13);
            this.CPQActiveCourseLabel.TabIndex = 4;
            this.CPQActiveCourseLabel.Text = "null";
            // 
            // CPQDummyActiveCourseLabel
            // 
            this.CPQDummyActiveCourseLabel.AutoSize = true;
            this.CPQDummyActiveCourseLabel.Location = new System.Drawing.Point(4, 16);
            this.CPQDummyActiveCourseLabel.Name = "CPQDummyActiveCourseLabel";
            this.CPQDummyActiveCourseLabel.Size = new System.Drawing.Size(79, 13);
            this.CPQDummyActiveCourseLabel.TabIndex = 5;
            this.CPQDummyActiveCourseLabel.Text = "Active Course :";
            // 
            // CPQDummyLabel
            // 
            this.CPQDummyLabel.AutoSize = true;
            this.CPQDummyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPQDummyLabel.Location = new System.Drawing.Point(1, 39);
            this.CPQDummyLabel.Name = "CPQDummyLabel";
            this.CPQDummyLabel.Size = new System.Drawing.Size(106, 16);
            this.CPQDummyLabel.TabIndex = 0;
            this.CPQDummyLabel.Text = "Course Name:";
            // 
            // InputCPQ
            // 
            this.InputCPQ.Location = new System.Drawing.Point(4, 64);
            this.InputCPQ.Name = "InputCPQ";
            this.InputCPQ.Size = new System.Drawing.Size(113, 20);
            this.InputCPQ.TabIndex = 2;
            // 
            // CPQGoButton
            // 
            this.CPQGoButton.BackColor = System.Drawing.Color.Transparent;
            this.CPQGoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CPQGoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPQGoButton.Location = new System.Drawing.Point(126, 61);
            this.CPQGoButton.Name = "CPQGoButton";
            this.CPQGoButton.Size = new System.Drawing.Size(84, 23);
            this.CPQGoButton.TabIndex = 1;
            this.CPQGoButton.Text = "Set Active Course";
            this.CPQGoButton.UseVisualStyleBackColor = false;
            this.CPQGoButton.Click += new System.EventHandler(this.CPQGoButton_Click);
            // 
            // CPQGroupBox
            // 
            this.CPQGroupBox.Controls.Add(this.DummyCourseNameInBoxLabel);
            this.CPQGroupBox.Controls.Add(this.CPQAddButton);
            this.CPQGroupBox.Controls.Add(this.CPQAddInputTextBox);
            this.CPQGroupBox.Location = new System.Drawing.Point(8, 117);
            this.CPQGroupBox.Name = "CPQGroupBox";
            this.CPQGroupBox.Size = new System.Drawing.Size(216, 81);
            this.CPQGroupBox.TabIndex = 6;
            this.CPQGroupBox.TabStop = false;
            this.CPQGroupBox.Text = "Add Course";
            // 
            // DummyCourseNameInBoxLabel
            // 
            this.DummyCourseNameInBoxLabel.AutoSize = true;
            this.DummyCourseNameInBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DummyCourseNameInBoxLabel.Location = new System.Drawing.Point(2, 23);
            this.DummyCourseNameInBoxLabel.Name = "DummyCourseNameInBoxLabel";
            this.DummyCourseNameInBoxLabel.Size = new System.Drawing.Size(110, 16);
            this.DummyCourseNameInBoxLabel.TabIndex = 2;
            this.DummyCourseNameInBoxLabel.Text = "Course Name :";
            // 
            // CPQAddButton
            // 
            this.CPQAddButton.BackColor = System.Drawing.Color.Transparent;
            this.CPQAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CPQAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPQAddButton.Location = new System.Drawing.Point(126, 44);
            this.CPQAddButton.Name = "CPQAddButton";
            this.CPQAddButton.Size = new System.Drawing.Size(84, 23);
            this.CPQAddButton.TabIndex = 1;
            this.CPQAddButton.Text = "Add";
            this.CPQAddButton.UseVisualStyleBackColor = false;
            this.CPQAddButton.Click += new System.EventHandler(this.CPQAddButton_Click);
            // 
            // CPQAddInputTextBox
            // 
            this.CPQAddInputTextBox.Location = new System.Drawing.Point(4, 47);
            this.CPQAddInputTextBox.Name = "CPQAddInputTextBox";
            this.CPQAddInputTextBox.Size = new System.Drawing.Size(113, 20);
            this.CPQAddInputTextBox.TabIndex = 0;
            // 
            // CPQDataGrid
            // 
            this.CPQDataGrid.AllowUserToAddRows = false;
            this.CPQDataGrid.AllowUserToResizeRows = false;
            this.CPQDataGrid.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.CPQDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CPQDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CPQ_NameColumn});
            this.CPQDataGrid.Location = new System.Drawing.Point(228, 42);
            this.CPQDataGrid.Name = "CPQDataGrid";
            this.CPQDataGrid.ReadOnly = true;
            this.CPQDataGrid.Size = new System.Drawing.Size(216, 156);
            this.CPQDataGrid.TabIndex = 3;
            this.CPQDataGrid.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.CPQDataGrid_UserDeletingRow);
            // 
            // CPQ_NameColumn
            // 
            this.CPQ_NameColumn.HeaderText = "Course Name";
            this.CPQ_NameColumn.Name = "CPQ_NameColumn";
            this.CPQ_NameColumn.ReadOnly = true;
            this.CPQ_NameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CPQ_NameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CPQ_NameColumn.Width = 150;
            // 
            // CoursesInStudent
            // 
            this.CoursesInStudent.Controls.Add(this.InputCoursesInStudent);
            this.CoursesInStudent.Controls.Add(this.CoursesInStudentGrid);
            this.CoursesInStudent.Controls.Add(this.CoursesInStudentGoButton);
            this.CoursesInStudent.Controls.Add(this.DummyCoursesInStudentLabel);
            this.CoursesInStudent.Location = new System.Drawing.Point(0, 0);
            this.CoursesInStudent.Name = "CoursesInStudent";
            this.CoursesInStudent.Size = new System.Drawing.Size(448, 214);
            this.CoursesInStudent.TabIndex = 0;
            this.CoursesInStudent.Visible = false;
            this.CoursesInStudent.VisibleChanged += new System.EventHandler(this.CoursesInStudent_VisibleChanged);
            // 
            // InputCoursesInStudent
            // 
            this.InputCoursesInStudent.Location = new System.Drawing.Point(177, 5);
            this.InputCoursesInStudent.Name = "InputCoursesInStudent";
            this.InputCoursesInStudent.Size = new System.Drawing.Size(120, 20);
            this.InputCoursesInStudent.TabIndex = 4;
            // 
            // CoursesInStudentGrid
            // 
            this.CoursesInStudentGrid.AllowUserToAddRows = false;
            this.CoursesInStudentGrid.AllowUserToDeleteRows = false;
            this.CoursesInStudentGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CoursesInStudentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CoursesInStudentGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIS_NameColumn,
            this.SIC_StatusColumn});
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
            this.CIS_NameColumn.Width = 202;
            // 
            // SIC_StatusColumn
            // 
            this.SIC_StatusColumn.HeaderText = "Status";
            this.SIC_StatusColumn.Name = "SIC_StatusColumn";
            this.SIC_StatusColumn.ReadOnly = true;
            this.SIC_StatusColumn.Width = 202;
            // 
            // CoursesInStudentGoButton
            // 
            this.CoursesInStudentGoButton.BackColor = System.Drawing.Color.Transparent;
            this.CoursesInStudentGoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CoursesInStudentGoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoursesInStudentGoButton.Location = new System.Drawing.Point(303, 2);
            this.CoursesInStudentGoButton.Name = "CoursesInStudentGoButton";
            this.CoursesInStudentGoButton.Size = new System.Drawing.Size(49, 23);
            this.CoursesInStudentGoButton.TabIndex = 2;
            this.CoursesInStudentGoButton.Text = "Go";
            this.CoursesInStudentGoButton.UseVisualStyleBackColor = false;
            this.CoursesInStudentGoButton.Click += new System.EventHandler(this.CoursesInStudentGoButton_Click);
            // 
            // DummyCoursesInStudentLabel
            // 
            this.DummyCoursesInStudentLabel.AutoSize = true;
            this.DummyCoursesInStudentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DummyCoursesInStudentLabel.Location = new System.Drawing.Point(92, 5);
            this.DummyCoursesInStudentLabel.Name = "DummyCoursesInStudentLabel";
            this.DummyCoursesInStudentLabel.Size = new System.Drawing.Size(79, 16);
            this.DummyCoursesInStudentLabel.TabIndex = 0;
            this.DummyCoursesInStudentLabel.Text = "Student ID";
            // 
            // LogIn
            // 
            this.LogIn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LogIn.Controls.Add(this.LoginButton);
            this.LogIn.Controls.Add(this.PasswordPlaceHolder);
            this.LogIn.Controls.Add(this.PasswordLabel);
            this.LogIn.Controls.Add(this.UserNamePlaceHolder);
            this.LogIn.Controls.Add(this.UserNameLabel);
            this.LogIn.Controls.Add(this.BigUserPicture);
            this.LogIn.Location = new System.Drawing.Point(0, 0);
            this.LogIn.Name = "LogIn";
            this.LogIn.Size = new System.Drawing.Size(576, 214);
            this.LogIn.TabIndex = 4;
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.Transparent;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LoginButton.Location = new System.Drawing.Point(390, 175);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(43, 23);
            this.LoginButton.TabIndex = 8;
            this.LoginButton.Text = "OK";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // PasswordPlaceHolder
            // 
            this.PasswordPlaceHolder.Controls.Add(this.PasswordTextBox);
            this.PasswordPlaceHolder.Controls.Add(this.DumyyPasswordPicture);
            this.PasswordPlaceHolder.Location = new System.Drawing.Point(301, 118);
            this.PasswordPlaceHolder.Name = "PasswordPlaceHolder";
            this.PasswordPlaceHolder.Size = new System.Drawing.Size(231, 40);
            this.PasswordPlaceHolder.TabIndex = 7;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(55, 3);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(173, 20);
            this.PasswordTextBox.TabIndex = 1;
            // 
            // DumyyPasswordPicture
            // 
            this.DumyyPasswordPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DumyyPasswordPicture.BackgroundImage")));
            this.DumyyPasswordPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DumyyPasswordPicture.Location = new System.Drawing.Point(0, 0);
            this.DumyyPasswordPicture.Name = "DumyyPasswordPicture";
            this.DumyyPasswordPicture.Size = new System.Drawing.Size(49, 40);
            this.DumyyPasswordPicture.TabIndex = 0;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.PasswordLabel.Location = new System.Drawing.Point(298, 99);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(76, 16);
            this.PasswordLabel.TabIndex = 6;
            this.PasswordLabel.Text = "Password";
            // 
            // UserNamePlaceHolder
            // 
            this.UserNamePlaceHolder.Controls.Add(this.UserNameTextBox);
            this.UserNamePlaceHolder.Controls.Add(this.DumyyUserPicture);
            this.UserNamePlaceHolder.Location = new System.Drawing.Point(300, 37);
            this.UserNamePlaceHolder.Name = "UserNamePlaceHolder";
            this.UserNamePlaceHolder.Size = new System.Drawing.Size(232, 40);
            this.UserNamePlaceHolder.TabIndex = 5;
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(55, 4);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(174, 20);
            this.UserNameTextBox.TabIndex = 1;
            // 
            // DumyyUserPicture
            // 
            this.DumyyUserPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DumyyUserPicture.BackgroundImage")));
            this.DumyyUserPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DumyyUserPicture.Location = new System.Drawing.Point(1, 2);
            this.DumyyUserPicture.Name = "DumyyUserPicture";
            this.DumyyUserPicture.Size = new System.Drawing.Size(48, 37);
            this.DumyyUserPicture.TabIndex = 0;
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.UserNameLabel.Location = new System.Drawing.Point(300, 16);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(79, 16);
            this.UserNameLabel.TabIndex = 4;
            this.UserNameLabel.Text = "Username";
            // 
            // BigUserPicture
            // 
            this.BigUserPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BigUserPicture.BackgroundImage")));
            this.BigUserPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BigUserPicture.Location = new System.Drawing.Point(2, 2);
            this.BigUserPicture.Name = "BigUserPicture";
            this.BigUserPicture.Size = new System.Drawing.Size(240, 209);
            this.BigUserPicture.TabIndex = 1;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(577, 214);
            this.Controls.Add(this.CourseOverviewPanel);
            this.Controls.Add(this.CoursesPrerequisites);
            this.Controls.Add(this.StudentsInCourse);
            this.Controls.Add(this.CoursesInStudent);
            this.Controls.Add(this.StudentOverviewPanel);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.LogIn);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "AdminForm";
            this.Text = "Admin Control";
            this.Home.ResumeLayout(false);
            this.HomeStudentBox.ResumeLayout(false);
            this.HomeCourseBox.ResumeLayout(false);
            this.CourseOverviewPanel.ResumeLayout(false);
            this.CourseOverviewPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllCoursesGrid)).EndInit();
            this.StudentOverviewPanel.ResumeLayout(false);
            this.StudentOverviewPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllStudentsGrid)).EndInit();
            this.StudentsInCourse.ResumeLayout(false);
            this.StudentsInCourse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsInCourseGrid)).EndInit();
            this.CoursesPrerequisites.ResumeLayout(false);
            this.CoursesPrerequisites.PerformLayout();
            this.CPQActiveBox.ResumeLayout(false);
            this.CPQActiveBox.PerformLayout();
            this.CPQGroupBox.ResumeLayout(false);
            this.CPQGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CPQDataGrid)).EndInit();
            this.CoursesInStudent.ResumeLayout(false);
            this.CoursesInStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InputCoursesInStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoursesInStudentGrid)).EndInit();
            this.LogIn.ResumeLayout(false);
            this.LogIn.PerformLayout();
            this.PasswordPlaceHolder.ResumeLayout(false);
            this.PasswordPlaceHolder.PerformLayout();
            this.UserNamePlaceHolder.ResumeLayout(false);
            this.UserNamePlaceHolder.PerformLayout();
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
    private System.Windows.Forms.Button CoursesInStudentGoButton;
    private System.Windows.Forms.Label DummyCoursesInStudentLabel;
    private System.Windows.Forms.DataGridView StudentsInCourseGrid;
    private System.Windows.Forms.DataGridViewTextBoxColumn SIC_IDColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn SIC_NameColumn;
    private System.Windows.Forms.Panel CoursesPrerequisites;
    private System.Windows.Forms.DataGridView CPQDataGrid;
    private System.Windows.Forms.TextBox InputCPQ;
    private System.Windows.Forms.Button CPQGoButton;
    private System.Windows.Forms.Label CPQDummyLabel;
    private System.Windows.Forms.Button HomeCPQButton;
    private System.Windows.Forms.Button StudentsInCourseGoButton;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Panel LogIn;
    private System.Windows.Forms.Panel BigUserPicture;
    private System.Windows.Forms.Label UserNameLabel;
    private System.Windows.Forms.Panel UserNamePlaceHolder;
    private System.Windows.Forms.TextBox UserNameTextBox;
    private System.Windows.Forms.Panel DumyyUserPicture;
    private System.Windows.Forms.Label PasswordLabel;
    private System.Windows.Forms.Panel PasswordPlaceHolder;
    private System.Windows.Forms.TextBox PasswordTextBox;
    private System.Windows.Forms.Panel DumyyPasswordPicture;
    private System.Windows.Forms.Button LoginButton;
    private System.Windows.Forms.DataGridViewTextBoxColumn SO_IDColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn SO_NameColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn SO_PasswordColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn SO_YearColumn;
    private System.Windows.Forms.Label CPQActiveCourseLabel;
    private System.Windows.Forms.Label CPQDummyActiveCourseLabel;
    private System.Windows.Forms.DataGridViewTextBoxColumn CPQ_NameColumn;
    private System.Windows.Forms.GroupBox CPQGroupBox;
    private System.Windows.Forms.Label DummyCourseNameInBoxLabel;
    private System.Windows.Forms.Button CPQAddButton;
    private System.Windows.Forms.TextBox CPQAddInputTextBox;
    private System.Windows.Forms.DataGridViewTextBoxColumn CIS_NameColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn SIC_StatusColumn;
    private System.Windows.Forms.NumericUpDown InputCoursesInStudent;
    private System.Windows.Forms.TextBox InputStudentsInCourse;
    private System.Windows.Forms.GroupBox CPQActiveBox;
    private System.Windows.Forms.Label label2;
}

