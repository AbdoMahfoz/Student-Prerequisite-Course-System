namespace Student_prerequisite_course_system
{
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_form));
            this.Loginpanel = new System.Windows.Forms.Panel();
            this.LOGIN = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.viewCourses = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.AvailableCbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.vcscroll2 = new System.Windows.Forms.VScrollBar();
            this.AllCbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.VCNext = new System.Windows.Forms.Button();
            this.VCPrevious = new System.Windows.Forms.Button();
            this.PasswordLABEL = new System.Windows.Forms.Label();
            this.UNLABEL = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.passwordtextbox = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.usernametextbox = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.CurrentDetails = new System.Windows.Forms.Panel();
            this.currentcoursesscroll = new System.Windows.Forms.VScrollBar();
            this.CurrentCoursesList = new System.Windows.Forms.ListView();
            this.DetailscurrentCourses = new System.Windows.Forms.Button();
            this.currentNext = new System.Windows.Forms.Button();
            this.RegisterPanel = new System.Windows.Forms.Panel();
            this.RegisterScroll = new System.Windows.Forms.VScrollBar();
            this.RegistercheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.RegisterPrevious = new System.Windows.Forms.Button();
            this.Register = new System.Windows.Forms.Button();
            this.RegisterNext = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.EditPanel = new System.Windows.Forms.Panel();
            this.Previous = new System.Windows.Forms.Button();
            this.Loginpanel.SuspendLayout();
            this.viewCourses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.CurrentDetails.SuspendLayout();
            this.RegisterPanel.SuspendLayout();
            this.EditPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Loginpanel
            // 
            this.Loginpanel.Controls.Add(this.LOGIN);
            this.Loginpanel.Controls.Add(this.panel3);
            this.Loginpanel.Controls.Add(this.panel4);
            this.Loginpanel.Controls.Add(this.panel2);
            this.Loginpanel.Controls.Add(this.PasswordLABEL);
            this.Loginpanel.Controls.Add(this.UNLABEL);
            this.Loginpanel.Location = new System.Drawing.Point(57, 21);
            this.Loginpanel.Name = "Loginpanel";
            this.Loginpanel.Size = new System.Drawing.Size(443, 196);
            this.Loginpanel.TabIndex = 0;
            // 
            // LOGIN
            // 
            this.LOGIN.Location = new System.Drawing.Point(270, 173);
            this.LOGIN.Name = "LOGIN";
            this.LOGIN.Size = new System.Drawing.Size(43, 20);
            this.LOGIN.TabIndex = 6;
            this.LOGIN.Text = "OK";
            this.LOGIN.UseVisualStyleBackColor = true;
            this.LOGIN.Click += new System.EventHandler(this.LOGIN_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(205, 196);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // viewCourses
            // 
            this.viewCourses.Controls.Add(this.splitContainer1);
            this.viewCourses.Controls.Add(this.VCNext);
            this.viewCourses.Controls.Add(this.VCPrevious);
            this.viewCourses.Location = new System.Drawing.Point(544, 90);
            this.viewCourses.Name = "viewCourses";
            this.viewCourses.Size = new System.Drawing.Size(431, 193);
            this.viewCourses.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            this.splitContainer1.Panel1.Controls.Add(this.vScrollBar1);
            this.splitContainer1.Panel1.Controls.Add(this.AvailableCbtn);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBox2);
            this.splitContainer1.Panel2.Controls.Add(this.vcscroll2);
            this.splitContainer1.Panel2.Controls.Add(this.AllCbtn);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Size = new System.Drawing.Size(428, 165);
            this.splitContainer1.SplitterDistance = 142;
            this.splitContainer1.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 55);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 20);
            this.textBox1.TabIndex = 4;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(127, 4);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(14, 161);
            this.vScrollBar1.TabIndex = 0;
            // 
            // AvailableCbtn
            // 
            this.AvailableCbtn.Location = new System.Drawing.Point(3, 4);
            this.AvailableCbtn.Name = "AvailableCbtn";
            this.AvailableCbtn.Size = new System.Drawing.Size(122, 21);
            this.AvailableCbtn.TabIndex = 1;
            this.AvailableCbtn.Text = "Available Courses";
            this.AvailableCbtn.UseVisualStyleBackColor = true;
            this.AvailableCbtn.Click += new System.EventHandler(this.AvailableCbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(24, 55);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // vcscroll2
            // 
            this.vcscroll2.Location = new System.Drawing.Point(264, 4);
            this.vcscroll2.Name = "vcscroll2";
            this.vcscroll2.Size = new System.Drawing.Size(14, 161);
            this.vcscroll2.TabIndex = 0;
            // 
            // AllCbtn
            // 
            this.AllCbtn.Location = new System.Drawing.Point(81, 3);
            this.AllCbtn.Name = "AllCbtn";
            this.AllCbtn.Size = new System.Drawing.Size(110, 21);
            this.AllCbtn.TabIndex = 0;
            this.AllCbtn.Text = "All Courses";
            this.AllCbtn.UseVisualStyleBackColor = true;
            this.AllCbtn.Click += new System.EventHandler(this.AllCbtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // VCNext
            // 
            this.VCNext.Location = new System.Drawing.Point(353, 166);
            this.VCNext.Name = "VCNext";
            this.VCNext.Size = new System.Drawing.Size(75, 23);
            this.VCNext.TabIndex = 2;
            this.VCNext.Text = "Next";
            this.VCNext.UseVisualStyleBackColor = true;
            this.VCNext.Click += new System.EventHandler(this.VCNext_Click);
            // 
            // VCPrevious
            // 
            this.VCPrevious.Location = new System.Drawing.Point(265, 166);
            this.VCPrevious.Name = "VCPrevious";
            this.VCPrevious.Size = new System.Drawing.Size(75, 23);
            this.VCPrevious.TabIndex = 1;
            this.VCPrevious.Text = "Previous ";
            this.VCPrevious.UseVisualStyleBackColor = true;
            this.VCPrevious.Click += new System.EventHandler(this.VCPrevious_Click);
            // 
            // PasswordLABEL
            // 
            this.PasswordLABEL.AutoSize = true;
            this.PasswordLABEL.Location = new System.Drawing.Point(215, 91);
            this.PasswordLABEL.Name = "PasswordLABEL";
            this.PasswordLABEL.Size = new System.Drawing.Size(53, 13);
            this.PasswordLABEL.TabIndex = 4;
            this.PasswordLABEL.Text = "Password";
            this.PasswordLABEL.Click += new System.EventHandler(this.label2_Click);
            // 
            // UNLABEL
            // 
            this.UNLABEL.AutoSize = true;
            this.UNLABEL.Location = new System.Drawing.Point(218, 13);
            this.UNLABEL.Name = "UNLABEL";
            this.UNLABEL.Size = new System.Drawing.Size(55, 13);
            this.UNLABEL.TabIndex = 3;
            this.UNLABEL.Text = "Username";
            this.UNLABEL.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.passwordtextbox);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Location = new System.Drawing.Point(211, 115);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(231, 40);
            this.panel4.TabIndex = 2;
            // 
            // passwordtextbox
            // 
            this.passwordtextbox.Location = new System.Drawing.Point(55, 3);
            this.passwordtextbox.Name = "passwordtextbox";
            this.passwordtextbox.Size = new System.Drawing.Size(173, 20);
            this.passwordtextbox.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel6.Location = new System.Drawing.Point(3, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(46, 38);
            this.panel6.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.usernametextbox);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(211, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(232, 40);
            this.panel3.TabIndex = 1;
            // 
            // usernametextbox
            // 
            this.usernametextbox.Location = new System.Drawing.Point(55, 4);
            this.usernametextbox.Name = "usernametextbox";
            this.usernametextbox.Size = new System.Drawing.Size(174, 20);
            this.usernametextbox.TabIndex = 1;
            this.usernametextbox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel5.Location = new System.Drawing.Point(1, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(48, 37);
            this.panel5.TabIndex = 0;
            // 
            // CurrentDetails
            // 
            this.CurrentDetails.Controls.Add(this.currentcoursesscroll);
            this.CurrentDetails.Controls.Add(this.CurrentCoursesList);
            this.CurrentDetails.Controls.Add(this.DetailscurrentCourses);
            this.CurrentDetails.Controls.Add(this.currentNext);
            this.CurrentDetails.Location = new System.Drawing.Point(57, 24);
            this.CurrentDetails.Name = "CurrentDetails";
            this.CurrentDetails.Size = new System.Drawing.Size(464, 190);
            this.CurrentDetails.TabIndex = 1;
            this.CurrentDetails.Paint += new System.Windows.Forms.PaintEventHandler(this.CurrentDetails_Paint);
            // 
            // currentcoursesscroll
            // 
            this.currentcoursesscroll.Location = new System.Drawing.Point(449, 43);
            this.currentcoursesscroll.Name = "currentcoursesscroll";
            this.currentcoursesscroll.Size = new System.Drawing.Size(15, 114);
            this.currentcoursesscroll.TabIndex = 6;
            // 
            // CurrentCoursesList
            // 
            this.CurrentCoursesList.Location = new System.Drawing.Point(3, 43);
            this.CurrentCoursesList.Name = "CurrentCoursesList";
            this.CurrentCoursesList.Size = new System.Drawing.Size(461, 114);
            this.CurrentCoursesList.TabIndex = 5;
            this.CurrentCoursesList.UseCompatibleStateImageBehavior = false;
            this.CurrentCoursesList.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // DetailscurrentCourses
            // 
            this.DetailscurrentCourses.Location = new System.Drawing.Point(3, 13);
            this.DetailscurrentCourses.Name = "DetailscurrentCourses";
            this.DetailscurrentCourses.Size = new System.Drawing.Size(157, 25);
            this.DetailscurrentCourses.TabIndex = 2;
            this.DetailscurrentCourses.Text = " Details Of Current Courses";
            this.DetailscurrentCourses.UseVisualStyleBackColor = true;
            this.DetailscurrentCourses.Click += new System.EventHandler(this.DetailscurrentCourses_Click);
            // 
            // currentNext
            // 
            this.currentNext.Location = new System.Drawing.Point(354, 163);
            this.currentNext.Name = "currentNext";
            this.currentNext.Size = new System.Drawing.Size(75, 23);
            this.currentNext.TabIndex = 2;
            this.currentNext.Text = "Next";
            this.currentNext.UseVisualStyleBackColor = true;
            this.currentNext.Click += new System.EventHandler(this.button2_Click);
            // 
            // RegisterPanel
            // 
            this.RegisterPanel.Controls.Add(this.RegisterScroll);
            this.RegisterPanel.Controls.Add(this.RegistercheckedListBox);
            this.RegisterPanel.Controls.Add(this.RegisterPrevious);
            this.RegisterPanel.Controls.Add(this.Register);
            this.RegisterPanel.Controls.Add(this.RegisterNext);
            this.RegisterPanel.Location = new System.Drawing.Point(57, 21);
            this.RegisterPanel.Name = "RegisterPanel";
            this.RegisterPanel.Size = new System.Drawing.Size(356, 176);
            this.RegisterPanel.TabIndex = 3;
            this.RegisterPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel9_Paint);
            // 
            // RegisterScroll
            // 
            this.RegisterScroll.Location = new System.Drawing.Point(333, 32);
            this.RegisterScroll.Name = "RegisterScroll";
            this.RegisterScroll.Size = new System.Drawing.Size(20, 106);
            this.RegisterScroll.TabIndex = 6;
            // 
            // RegistercheckedListBox
            // 
            this.RegistercheckedListBox.FormattingEnabled = true;
            this.RegistercheckedListBox.Location = new System.Drawing.Point(3, 32);
            this.RegistercheckedListBox.Name = "RegistercheckedListBox";
            this.RegistercheckedListBox.Size = new System.Drawing.Size(350, 109);
            this.RegistercheckedListBox.TabIndex = 5;
            // 
            // RegisterPrevious
            // 
            this.RegisterPrevious.Location = new System.Drawing.Point(188, 150);
            this.RegisterPrevious.Name = "RegisterPrevious";
            this.RegisterPrevious.Size = new System.Drawing.Size(75, 23);
            this.RegisterPrevious.TabIndex = 3;
            this.RegisterPrevious.Text = "Previous";
            this.RegisterPrevious.UseVisualStyleBackColor = true;
            this.RegisterPrevious.Click += new System.EventHandler(this.button8_Click);
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(3, 3);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(75, 23);
            this.Register.TabIndex = 2;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // RegisterNext
            // 
            this.RegisterNext.Location = new System.Drawing.Point(278, 150);
            this.RegisterNext.Name = "RegisterNext";
            this.RegisterNext.Size = new System.Drawing.Size(75, 23);
            this.RegisterNext.TabIndex = 1;
            this.RegisterNext.Text = "Next";
            this.RegisterNext.UseVisualStyleBackColor = true;
            this.RegisterNext.Click += new System.EventHandler(this.RegisterNext_Click);
            // 
            // EditPanel
            // 
            this.EditPanel.Controls.Add(this.Previous);
            this.EditPanel.Location = new System.Drawing.Point(57, 21);
            this.EditPanel.Name = "EditPanel";
            this.EditPanel.Size = new System.Drawing.Size(200, 169);
            this.EditPanel.TabIndex = 4;
            // 
            // Previous
            // 
            this.Previous.Location = new System.Drawing.Point(45, 16);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(75, 23);
            this.Previous.TabIndex = 0;
            this.Previous.Text = "Edit";
            this.Previous.UseVisualStyleBackColor = true;
            this.Previous.Click += new System.EventHandler(this.Previous_Click);
            // 
            // Student_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1051, 475);
            this.Controls.Add(this.viewCourses);
            this.Controls.Add(this.Loginpanel);
            this.Controls.Add(this.EditPanel);
            this.Controls.Add(this.RegisterPanel);
            this.Controls.Add(this.CurrentDetails);
            this.Name = "Student_form";
            this.Text = "Previous";
            this.Load += new System.EventHandler(this.logindesign_Load);
            this.Loginpanel.ResumeLayout(false);
            this.Loginpanel.PerformLayout();
            this.viewCourses.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.CurrentDetails.ResumeLayout(false);
            this.RegisterPanel.ResumeLayout(false);
            this.EditPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Loginpanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label UNLABEL;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label PasswordLABEL;
        private System.Windows.Forms.Panel viewCourses;
        private System.Windows.Forms.Panel RegisterPanel;
        private System.Windows.Forms.Button VCPrevious;
        private System.Windows.Forms.Button AvailableCbtn;
        private System.Windows.Forms.Button AllCbtn;
        private System.Windows.Forms.Button VCNext;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button currentNext;
        private System.Windows.Forms.Button DetailscurrentCourses;
        private System.Windows.Forms.Panel CurrentDetails;
        private System.Windows.Forms.Button RegisterNext;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button RegisterPrevious;
        private System.Windows.Forms.Button LOGIN;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.VScrollBar vcscroll2;
        private System.Windows.Forms.VScrollBar RegisterScroll;
        private System.Windows.Forms.CheckedListBox RegistercheckedListBox;
        private System.Windows.Forms.Panel EditPanel;
        private System.Windows.Forms.Button Previous;
        private System.Windows.Forms.ListView CurrentCoursesList;
        private System.Windows.Forms.VScrollBar currentcoursesscroll;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox passwordtextbox;
        private System.Windows.Forms.TextBox usernametextbox;
    }
}