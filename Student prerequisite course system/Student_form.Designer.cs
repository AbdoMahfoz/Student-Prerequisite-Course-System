
partial class Student_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_form));
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.LoginButton = new System.Windows.Forms.Button();
            this.UserNamePlaceHolder = new System.Windows.Forms.Panel();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.DumyyUserPicture = new System.Windows.Forms.Panel();
            this.PasswordPlaceHolder = new System.Windows.Forms.Panel();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.DumyyPasswordPicture = new System.Windows.Forms.Panel();
            this.BigUserPicture = new System.Windows.Forms.Panel();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.ViewCourses = new System.Windows.Forms.Panel();
            this.AvailCourseCheckbox = new System.Windows.Forms.CheckBox();
            this.DynamicCourcesPanel = new System.Windows.Forms.Panel();
            this.CurrentDetails = new System.Windows.Forms.Panel();
            this.CurrentCoursesList = new System.Windows.Forms.ListView();
            this.RegisterPanel = new System.Windows.Forms.Panel();
            this.RegistercheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.Register = new System.Windows.Forms.Button();
            this.NavigationPanel = new System.Windows.Forms.Panel();
            this.HomeRegister = new System.Windows.Forms.Button();
            this.HomeView = new System.Windows.Forms.Button();
            this.HomeCurrent = new System.Windows.Forms.Button();
            this.LoginPanel.SuspendLayout();
            this.UserNamePlaceHolder.SuspendLayout();
            this.PasswordPlaceHolder.SuspendLayout();
            this.ViewCourses.SuspendLayout();
            this.CurrentDetails.SuspendLayout();
            this.RegisterPanel.SuspendLayout();
            this.NavigationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginPanel
            // 
            this.LoginPanel.Controls.Add(this.LoginButton);
            this.LoginPanel.Controls.Add(this.UserNamePlaceHolder);
            this.LoginPanel.Controls.Add(this.PasswordPlaceHolder);
            this.LoginPanel.Controls.Add(this.BigUserPicture);
            this.LoginPanel.Controls.Add(this.PasswordLabel);
            this.LoginPanel.Controls.Add(this.UserNameLabel);
            this.LoginPanel.Location = new System.Drawing.Point(0, 1);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(681, 246);
            this.LoginPanel.TabIndex = 0;
            // 
            // LoginButton
            // 
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LoginButton.Location = new System.Drawing.Point(452, 195);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(43, 20);
            this.LoginButton.TabIndex = 6;
            this.LoginButton.Text = "OK";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // UserNamePlaceHolder
            // 
            this.UserNamePlaceHolder.Controls.Add(this.UserNameTextBox);
            this.UserNamePlaceHolder.Controls.Add(this.DumyyUserPicture);
            this.UserNamePlaceHolder.Location = new System.Drawing.Point(367, 57);
            this.UserNamePlaceHolder.Name = "UserNamePlaceHolder";
            this.UserNamePlaceHolder.Size = new System.Drawing.Size(232, 40);
            this.UserNamePlaceHolder.TabIndex = 1;
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
            // PasswordPlaceHolder
            // 
            this.PasswordPlaceHolder.Controls.Add(this.PasswordTextBox);
            this.PasswordPlaceHolder.Controls.Add(this.DumyyPasswordPicture);
            this.PasswordPlaceHolder.Location = new System.Drawing.Point(367, 137);
            this.PasswordPlaceHolder.Name = "PasswordPlaceHolder";
            this.PasswordPlaceHolder.Size = new System.Drawing.Size(231, 40);
            this.PasswordPlaceHolder.TabIndex = 2;
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
            // BigUserPicture
            // 
            this.BigUserPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BigUserPicture.BackgroundImage")));
            this.BigUserPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BigUserPicture.Location = new System.Drawing.Point(0, 0);
            this.BigUserPicture.Name = "BigUserPicture";
            this.BigUserPicture.Size = new System.Drawing.Size(240, 243);
            this.BigUserPicture.TabIndex = 0;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.PasswordLabel.Location = new System.Drawing.Point(371, 113);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(76, 16);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "Password";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.UserNameLabel.Location = new System.Drawing.Point(374, 35);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(79, 16);
            this.UserNameLabel.TabIndex = 3;
            this.UserNameLabel.Text = "Username";
            // 
            // ViewCourses
            // 
            this.ViewCourses.Controls.Add(this.AvailCourseCheckbox);
            this.ViewCourses.Controls.Add(this.DynamicCourcesPanel);
            this.ViewCourses.Location = new System.Drawing.Point(0, 0);
            this.ViewCourses.Name = "ViewCourses";
            this.ViewCourses.Size = new System.Drawing.Size(530, 247);
            this.ViewCourses.TabIndex = 2;
            this.ViewCourses.Visible = false;
            this.ViewCourses.VisibleChanged += new System.EventHandler(this.ViewCourses_VisibleChanged);
            // 
            // AvailCourseCheckbox
            // 
            this.AvailCourseCheckbox.AutoSize = true;
            this.AvailCourseCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AvailCourseCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailCourseCheckbox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.AvailCourseCheckbox.Location = new System.Drawing.Point(184, 4);
            this.AvailCourseCheckbox.Name = "AvailCourseCheckbox";
            this.AvailCourseCheckbox.Size = new System.Drawing.Size(213, 20);
            this.AvailCourseCheckbox.TabIndex = 6;
            this.AvailCourseCheckbox.Text = "Show available courses only";
            this.AvailCourseCheckbox.UseVisualStyleBackColor = true;
            this.AvailCourseCheckbox.CheckedChanged += new System.EventHandler(this.AvailCourseCheckbox_CheckedChanged);
            // 
            // DynamicCourcesPanel
            // 
            this.DynamicCourcesPanel.AutoScroll = true;
            this.DynamicCourcesPanel.Location = new System.Drawing.Point(0, 26);
            this.DynamicCourcesPanel.Name = "DynamicCourcesPanel";
            this.DynamicCourcesPanel.Size = new System.Drawing.Size(530, 221);
            this.DynamicCourcesPanel.TabIndex = 5;
            // 
            // CurrentDetails
            // 
            this.CurrentDetails.Controls.Add(this.CurrentCoursesList);
            this.CurrentDetails.Location = new System.Drawing.Point(0, 0);
            this.CurrentDetails.Name = "CurrentDetails";
            this.CurrentDetails.Size = new System.Drawing.Size(530, 247);
            this.CurrentDetails.TabIndex = 1;
            this.CurrentDetails.Visible = false;
            // 
            // CurrentCoursesList
            // 
            this.CurrentCoursesList.Location = new System.Drawing.Point(3, 2);
            this.CurrentCoursesList.Name = "CurrentCoursesList";
            this.CurrentCoursesList.Size = new System.Drawing.Size(524, 239);
            this.CurrentCoursesList.TabIndex = 5;
            this.CurrentCoursesList.UseCompatibleStateImageBehavior = false;
            // 
            // RegisterPanel
            // 
            this.RegisterPanel.Controls.Add(this.RegistercheckedListBox);
            this.RegisterPanel.Controls.Add(this.Register);
            this.RegisterPanel.Location = new System.Drawing.Point(0, 0);
            this.RegisterPanel.Name = "RegisterPanel";
            this.RegisterPanel.Size = new System.Drawing.Size(530, 247);
            this.RegisterPanel.TabIndex = 3;
            this.RegisterPanel.Visible = false;
            // 
            // RegistercheckedListBox
            // 
            this.RegistercheckedListBox.FormattingEnabled = true;
            this.RegistercheckedListBox.Location = new System.Drawing.Point(3, 2);
            this.RegistercheckedListBox.Name = "RegistercheckedListBox";
            this.RegistercheckedListBox.Size = new System.Drawing.Size(524, 214);
            this.RegistercheckedListBox.TabIndex = 5;
            // 
            // Register
            // 
            this.Register.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Register.Location = new System.Drawing.Point(230, 221);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(75, 23);
            this.Register.TabIndex = 2;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = true;
            // 
            // NavigationPanel
            // 
            this.NavigationPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.NavigationPanel.Controls.Add(this.HomeRegister);
            this.NavigationPanel.Controls.Add(this.HomeView);
            this.NavigationPanel.Controls.Add(this.HomeCurrent);
            this.NavigationPanel.Location = new System.Drawing.Point(533, 1);
            this.NavigationPanel.Name = "NavigationPanel";
            this.NavigationPanel.Size = new System.Drawing.Size(148, 246);
            this.NavigationPanel.TabIndex = 7;
            this.NavigationPanel.Visible = false;
            // 
            // HomeRegister
            // 
            this.HomeRegister.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.HomeRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeRegister.Location = new System.Drawing.Point(15, 183);
            this.HomeRegister.Name = "HomeRegister";
            this.HomeRegister.Size = new System.Drawing.Size(108, 23);
            this.HomeRegister.TabIndex = 2;
            this.HomeRegister.Text = "Register Courses";
            this.HomeRegister.UseVisualStyleBackColor = true;
            this.HomeRegister.Click += new System.EventHandler(this.HomeRegister_Click);
            // 
            // HomeView
            // 
            this.HomeView.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.HomeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeView.Location = new System.Drawing.Point(15, 103);
            this.HomeView.Name = "HomeView";
            this.HomeView.Size = new System.Drawing.Size(108, 23);
            this.HomeView.TabIndex = 1;
            this.HomeView.Text = "View Courses";
            this.HomeView.UseVisualStyleBackColor = true;
            this.HomeView.Click += new System.EventHandler(this.HomeView_Click);
            // 
            // HomeCurrent
            // 
            this.HomeCurrent.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.HomeCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeCurrent.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.HomeCurrent.Location = new System.Drawing.Point(15, 25);
            this.HomeCurrent.Name = "HomeCurrent";
            this.HomeCurrent.Size = new System.Drawing.Size(108, 23);
            this.HomeCurrent.TabIndex = 0;
            this.HomeCurrent.Text = "Current Courses";
            this.HomeCurrent.UseVisualStyleBackColor = true;
            this.HomeCurrent.Click += new System.EventHandler(this.HomeCurrent_Click);
            // 
            // Student_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(682, 247);
            this.Controls.Add(this.CurrentDetails);
            this.Controls.Add(this.NavigationPanel);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.ViewCourses);
            this.Controls.Add(this.RegisterPanel);
            this.Name = "Student_form";
            this.Text = "Previous";
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.UserNamePlaceHolder.ResumeLayout(false);
            this.UserNamePlaceHolder.PerformLayout();
            this.PasswordPlaceHolder.ResumeLayout(false);
            this.PasswordPlaceHolder.PerformLayout();
            this.ViewCourses.ResumeLayout(false);
            this.ViewCourses.PerformLayout();
            this.CurrentDetails.ResumeLayout(false);
            this.RegisterPanel.ResumeLayout(false);
            this.NavigationPanel.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel LoginPanel;
    private System.Windows.Forms.Panel BigUserPicture;
    private System.Windows.Forms.Label UserNameLabel;
    private System.Windows.Forms.Panel PasswordPlaceHolder;
    private System.Windows.Forms.Panel DumyyPasswordPicture;
    private System.Windows.Forms.Panel UserNamePlaceHolder;
    private System.Windows.Forms.Panel DumyyUserPicture;
    private System.Windows.Forms.Label PasswordLabel;
    private System.Windows.Forms.Panel ViewCourses;
    private System.Windows.Forms.Panel RegisterPanel;
    private System.Windows.Forms.Panel CurrentDetails;
    private System.Windows.Forms.Button Register;
    private System.Windows.Forms.Button LoginButton;
    private System.Windows.Forms.CheckedListBox RegistercheckedListBox;
    private System.Windows.Forms.ListView CurrentCoursesList;
    private System.Windows.Forms.TextBox PasswordTextBox;
    private System.Windows.Forms.TextBox UserNameTextBox;
    private System.Windows.Forms.Panel NavigationPanel;
    private System.Windows.Forms.Button HomeRegister;
    private System.Windows.Forms.Button HomeView;
    private System.Windows.Forms.Button HomeCurrent;
    private System.Windows.Forms.CheckBox AvailCourseCheckbox;
    private System.Windows.Forms.Panel DynamicCourcesPanel;
}
