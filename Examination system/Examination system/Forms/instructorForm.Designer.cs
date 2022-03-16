namespace Examination_system.Forms
{
    partial class instructorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(instructorForm));
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.tabCtrl_DashBoard = new System.Windows.Forms.TabControl();
            this.tabpage_exams = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_grade = new System.Windows.Forms.Label();
            this.lbl_generator = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_grade = new System.Windows.Forms.TextBox();
            this.txt_generator = new System.Windows.Forms.TextBox();
            this.txt_course = new System.Windows.Forms.TextBox();
            this.txt_ex_id = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbo_crsname = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tfq = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_mcq = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_display = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_generate = new System.Windows.Forms.Button();
            this.tabpage_department = new System.Windows.Forms.TabPage();
            this.tabpage_students = new System.Windows.Forms.TabPage();
            this.tabPage_questions = new System.Windows.Forms.TabPage();
            this.tabPage_users = new System.Windows.Forms.TabPage();
            this.tabPage_Reports = new System.Windows.Forms.TabPage();
            this.tabPage_instructors = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_examGrade = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabCtrl_DashBoard.SuspendLayout();
            this.tabpage_exams.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.Location = new System.Drawing.Point(3, 16);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(132, 32);
            this.lbl_welcome.TabIndex = 1;
            this.lbl_welcome.Text = "Welcome";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Noto Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(23, 67);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(104, 38);
            this.lbl_username.TabIndex = 2;
            this.lbl_username.Text = "label1";
            // 
            // tabCtrl_DashBoard
            // 
            this.tabCtrl_DashBoard.Controls.Add(this.tabpage_exams);
            this.tabCtrl_DashBoard.Controls.Add(this.tabpage_department);
            this.tabCtrl_DashBoard.Controls.Add(this.tabpage_students);
            this.tabCtrl_DashBoard.Controls.Add(this.tabPage_questions);
            this.tabCtrl_DashBoard.Controls.Add(this.tabPage_users);
            this.tabCtrl_DashBoard.Controls.Add(this.tabPage_Reports);
            this.tabCtrl_DashBoard.Controls.Add(this.tabPage_instructors);
            this.tabCtrl_DashBoard.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabCtrl_DashBoard.Location = new System.Drawing.Point(206, 0);
            this.tabCtrl_DashBoard.Name = "tabCtrl_DashBoard";
            this.tabCtrl_DashBoard.SelectedIndex = 0;
            this.tabCtrl_DashBoard.Size = new System.Drawing.Size(1111, 586);
            this.tabCtrl_DashBoard.TabIndex = 3;
            // 
            // tabpage_exams
            // 
            this.tabpage_exams.Controls.Add(this.groupBox3);
            this.tabpage_exams.Controls.Add(this.groupBox2);
            this.tabpage_exams.Controls.Add(this.groupBox1);
            this.tabpage_exams.Controls.Add(this.btn_display);
            this.tabpage_exams.Controls.Add(this.btn_delete);
            this.tabpage_exams.Controls.Add(this.btn_generate);
            this.tabpage_exams.Location = new System.Drawing.Point(4, 25);
            this.tabpage_exams.Name = "tabpage_exams";
            this.tabpage_exams.Padding = new System.Windows.Forms.Padding(3);
            this.tabpage_exams.Size = new System.Drawing.Size(1103, 557);
            this.tabpage_exams.TabIndex = 0;
            this.tabpage_exams.Text = "Exams";
            this.tabpage_exams.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listView1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(56, 377);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1009, 172);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Display";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_grade);
            this.groupBox2.Controls.Add(this.lbl_generator);
            this.groupBox2.Controls.Add(this.label);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_grade);
            this.groupBox2.Controls.Add(this.txt_generator);
            this.groupBox2.Controls.Add(this.txt_course);
            this.groupBox2.Controls.Add(this.txt_ex_id);
            this.groupBox2.Controls.Add(this.txt_id);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(56, 246);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1009, 112);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete";
            // 
            // lbl_grade
            // 
            this.lbl_grade.AutoSize = true;
            this.lbl_grade.Location = new System.Drawing.Point(764, 25);
            this.lbl_grade.Name = "lbl_grade";
            this.lbl_grade.Size = new System.Drawing.Size(55, 20);
            this.lbl_grade.TabIndex = 2;
            this.lbl_grade.Text = "Grade";
            // 
            // lbl_generator
            // 
            this.lbl_generator.AutoSize = true;
            this.lbl_generator.Location = new System.Drawing.Point(610, 25);
            this.lbl_generator.Name = "lbl_generator";
            this.lbl_generator.Size = new System.Drawing.Size(84, 20);
            this.lbl_generator.TabIndex = 2;
            this.lbl_generator.Text = "Generator";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(456, 25);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(63, 20);
            this.label.TabIndex = 2;
            this.label.Text = "Course";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(302, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "ID";
            // 
            // txt_grade
            // 
            this.txt_grade.Location = new System.Drawing.Point(768, 48);
            this.txt_grade.Name = "txt_grade";
            this.txt_grade.ReadOnly = true;
            this.txt_grade.Size = new System.Drawing.Size(154, 27);
            this.txt_grade.TabIndex = 1;
            // 
            // txt_generator
            // 
            this.txt_generator.Location = new System.Drawing.Point(614, 48);
            this.txt_generator.Name = "txt_generator";
            this.txt_generator.ReadOnly = true;
            this.txt_generator.Size = new System.Drawing.Size(154, 27);
            this.txt_generator.TabIndex = 1;
            // 
            // txt_course
            // 
            this.txt_course.Location = new System.Drawing.Point(460, 48);
            this.txt_course.Name = "txt_course";
            this.txt_course.ReadOnly = true;
            this.txt_course.Size = new System.Drawing.Size(154, 27);
            this.txt_course.TabIndex = 1;
            // 
            // txt_ex_id
            // 
            this.txt_ex_id.Location = new System.Drawing.Point(306, 48);
            this.txt_ex_id.Name = "txt_ex_id";
            this.txt_ex_id.ReadOnly = true;
            this.txt_ex_id.Size = new System.Drawing.Size(154, 27);
            this.txt_ex_id.TabIndex = 1;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(97, 48);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 27);
            this.txt_id.TabIndex = 1;
            this.txt_id.TextChanged += new System.EventHandler(this.txt_id_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_examGrade);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbo_crsname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_tfq);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_mcq);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(56, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1009, 112);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generate exam";
            // 
            // cmbo_crsname
            // 
            this.cmbo_crsname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbo_crsname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbo_crsname.FormattingEnabled = true;
            this.cmbo_crsname.Location = new System.Drawing.Point(778, 49);
            this.cmbo_crsname.Name = "cmbo_crsname";
            this.cmbo_crsname.Size = new System.Drawing.Size(219, 33);
            this.cmbo_crsname.TabIndex = 2;
            this.cmbo_crsname.DropDown += new System.EventHandler(this.cmbo_crsname_DropDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(645, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Course name";
            // 
            // txt_tfq
            // 
            this.txt_tfq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tfq.Location = new System.Drawing.Point(332, 50);
            this.txt_tfq.Name = "txt_tfq";
            this.txt_tfq.Size = new System.Drawing.Size(138, 30);
            this.txt_tfq.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(241, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "TFQ No.";
            // 
            // txt_mcq
            // 
            this.txt_mcq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mcq.Location = new System.Drawing.Point(100, 50);
            this.txt_mcq.Name = "txt_mcq";
            this.txt_mcq.Size = new System.Drawing.Size(138, 30);
            this.txt_mcq.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "MCQ No.";
            // 
            // btn_display
            // 
            this.btn_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_display.Location = new System.Drawing.Point(723, 29);
            this.btn_display.Name = "btn_display";
            this.btn_display.Size = new System.Drawing.Size(342, 56);
            this.btn_display.TabIndex = 1;
            this.btn_display.Text = "Display";
            this.btn_display.UseVisualStyleBackColor = true;
            this.btn_display.Click += new System.EventHandler(this.btn_display_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(381, 29);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(342, 56);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_generate
            // 
            this.btn_generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generate.Location = new System.Drawing.Point(39, 29);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(342, 56);
            this.btn_generate.TabIndex = 0;
            this.btn_generate.Text = "Generate";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // tabpage_department
            // 
            this.tabpage_department.Location = new System.Drawing.Point(4, 25);
            this.tabpage_department.Name = "tabpage_department";
            this.tabpage_department.Padding = new System.Windows.Forms.Padding(3);
            this.tabpage_department.Size = new System.Drawing.Size(1103, 557);
            this.tabpage_department.TabIndex = 1;
            this.tabpage_department.Text = "Departments";
            this.tabpage_department.UseVisualStyleBackColor = true;
            // 
            // tabpage_students
            // 
            this.tabpage_students.Location = new System.Drawing.Point(4, 25);
            this.tabpage_students.Name = "tabpage_students";
            this.tabpage_students.Padding = new System.Windows.Forms.Padding(3);
            this.tabpage_students.Size = new System.Drawing.Size(1103, 557);
            this.tabpage_students.TabIndex = 2;
            this.tabpage_students.Text = "Students";
            this.tabpage_students.UseVisualStyleBackColor = true;
            // 
            // tabPage_questions
            // 
            this.tabPage_questions.Location = new System.Drawing.Point(4, 25);
            this.tabPage_questions.Name = "tabPage_questions";
            this.tabPage_questions.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_questions.Size = new System.Drawing.Size(1103, 557);
            this.tabPage_questions.TabIndex = 3;
            this.tabPage_questions.Text = "Questions";
            this.tabPage_questions.UseVisualStyleBackColor = true;
            // 
            // tabPage_users
            // 
            this.tabPage_users.Location = new System.Drawing.Point(4, 25);
            this.tabPage_users.Name = "tabPage_users";
            this.tabPage_users.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_users.Size = new System.Drawing.Size(1103, 557);
            this.tabPage_users.TabIndex = 4;
            this.tabPage_users.Text = "Users";
            this.tabPage_users.UseVisualStyleBackColor = true;
            // 
            // tabPage_Reports
            // 
            this.tabPage_Reports.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Reports.Name = "tabPage_Reports";
            this.tabPage_Reports.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Reports.Size = new System.Drawing.Size(1103, 557);
            this.tabPage_Reports.TabIndex = 5;
            this.tabPage_Reports.Text = "Reports";
            this.tabPage_Reports.UseVisualStyleBackColor = true;
            // 
            // tabPage_instructors
            // 
            this.tabPage_instructors.Location = new System.Drawing.Point(4, 25);
            this.tabPage_instructors.Name = "tabPage_instructors";
            this.tabPage_instructors.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_instructors.Size = new System.Drawing.Size(1103, 557);
            this.tabPage_instructors.TabIndex = 6;
            this.tabPage_instructors.Text = "instructors";
            this.tabPage_instructors.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_welcome);
            this.panel1.Controls.Add(this.lbl_username);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 586);
            this.panel1.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(473, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Grade";
            // 
            // txt_examGrade
            // 
            this.txt_examGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_examGrade.Location = new System.Drawing.Point(542, 50);
            this.txt_examGrade.Name = "txt_examGrade";
            this.txt_examGrade.Size = new System.Drawing.Size(100, 30);
            this.txt_examGrade.TabIndex = 4;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 23);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1003, 146);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Course";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Instructor";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Grade";
            // 
            // instructorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 586);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabCtrl_DashBoard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1335, 633);
            this.MinimumSize = new System.Drawing.Size(1335, 633);
            this.Name = "instructorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "instructor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.instructorForm_FormClosing);
            this.tabCtrl_DashBoard.ResumeLayout(false);
            this.tabpage_exams.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.TabControl tabCtrl_DashBoard;
        private System.Windows.Forms.TabPage tabpage_exams;
        private System.Windows.Forms.TabPage tabpage_department;
        private System.Windows.Forms.TabPage tabpage_students;
        private System.Windows.Forms.TabPage tabPage_questions;
        private System.Windows.Forms.TabPage tabPage_users;
        private System.Windows.Forms.TabPage tabPage_Reports;
        private System.Windows.Forms.TabPage tabPage_instructors;
        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_display;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_tfq;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_mcq;
        private System.Windows.Forms.ComboBox cmbo_crsname;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ex_id;
        private System.Windows.Forms.TextBox txt_generator;
        private System.Windows.Forms.TextBox txt_course;
        private System.Windows.Forms.TextBox txt_grade;
        private System.Windows.Forms.Label lbl_grade;
        private System.Windows.Forms.Label lbl_generator;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_examGrade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}