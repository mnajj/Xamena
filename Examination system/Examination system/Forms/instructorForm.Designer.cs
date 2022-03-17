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
			this.listView1 = new System.Windows.Forms.ListView();
			this.clm_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.clm_crs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.clm_ins = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.clm_grade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
			this.txt_examGrade = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
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
			this.date_deptHire = new System.Windows.Forms.DateTimePicker();
			this.label11 = new System.Windows.Forms.Label();
			this.cmbo_deptManager = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.txt_deptLoc = new System.Windows.Forms.TextBox();
			this.txt_deptName = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txt_deptId = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.btn_deptInsert = new System.Windows.Forms.Button();
			this.btn_deptDelete = new System.Windows.Forms.Button();
			this.btn_deptDisplayByname = new System.Windows.Forms.Button();
			this.btn_deptDisplay = new System.Windows.Forms.Button();
			this.btn_dept_update = new System.Windows.Forms.Button();
			this.lst_department = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.tabpage_students = new System.Windows.Forms.TabPage();
			this.StdLNameFld = new System.Windows.Forms.TextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.StdAddressFld = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.StdFnameField = new System.Windows.Forms.TextBox();
			this.StdBirthFld = new System.Windows.Forms.DateTimePicker();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.StdDepartmentFiled = new System.Windows.Forms.TextBox();
			this.StdUserNameField = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.StdIdField = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.StdList = new System.Windows.Forms.ListView();
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.InsertStd = new System.Windows.Forms.Button();
			this.DeleteStd = new System.Windows.Forms.Button();
			this.DisplayStdByName = new System.Windows.Forms.Button();
			this.DisplayStd = new System.Windows.Forms.Button();
			this.UpdateStd = new System.Windows.Forms.Button();
			this.tabPage_questions = new System.Windows.Forms.TabPage();
			this.tabPage_users = new System.Windows.Forms.TabPage();
			this.tabPage_Reports = new System.Windows.Forms.TabPage();
			this.tabPage_instructors = new System.Windows.Forms.TabPage();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tabCtrl_DashBoard.SuspendLayout();
			this.tabpage_exams.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tabpage_department.SuspendLayout();
			this.tabpage_students.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbl_welcome
			// 
			this.lbl_welcome.AutoSize = true;
			this.lbl_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_welcome.Location = new System.Drawing.Point(2, 13);
			this.lbl_welcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_welcome.Name = "lbl_welcome";
			this.lbl_welcome.Size = new System.Drawing.Size(104, 26);
			this.lbl_welcome.TabIndex = 1;
			this.lbl_welcome.Text = "Welcome";
			// 
			// lbl_username
			// 
			this.lbl_username.AutoSize = true;
			this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_username.Location = new System.Drawing.Point(17, 54);
			this.lbl_username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_username.Name = "lbl_username";
			this.lbl_username.Size = new System.Drawing.Size(76, 26);
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
			this.tabCtrl_DashBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabCtrl_DashBoard.Location = new System.Drawing.Point(156, 0);
			this.tabCtrl_DashBoard.Margin = new System.Windows.Forms.Padding(2);
			this.tabCtrl_DashBoard.Name = "tabCtrl_DashBoard";
			this.tabCtrl_DashBoard.SelectedIndex = 0;
			this.tabCtrl_DashBoard.Size = new System.Drawing.Size(833, 483);
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
			this.tabpage_exams.Location = new System.Drawing.Point(4, 29);
			this.tabpage_exams.Margin = new System.Windows.Forms.Padding(2);
			this.tabpage_exams.Name = "tabpage_exams";
			this.tabpage_exams.Padding = new System.Windows.Forms.Padding(2);
			this.tabpage_exams.Size = new System.Drawing.Size(825, 450);
			this.tabpage_exams.TabIndex = 0;
			this.tabpage_exams.Text = "Exams";
			this.tabpage_exams.UseVisualStyleBackColor = true;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.listView1);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(42, 306);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox3.Size = new System.Drawing.Size(757, 140);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Display";
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clm_id,
            this.clm_crs,
            this.clm_ins,
            this.clm_grade});
			this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listView1.FullRowSelect = true;
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(2, 18);
			this.listView1.Margin = new System.Windows.Forms.Padding(2);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(753, 120);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// clm_id
			// 
			this.clm_id.Text = "ID";
			this.clm_id.Width = 190;
			// 
			// clm_crs
			// 
			this.clm_crs.Text = "Course";
			this.clm_crs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.clm_crs.Width = 190;
			// 
			// clm_ins
			// 
			this.clm_ins.Text = "Instructor";
			this.clm_ins.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.clm_ins.Width = 190;
			// 
			// clm_grade
			// 
			this.clm_grade.Text = "Grade";
			this.clm_grade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.clm_grade.Width = 190;
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
			this.groupBox2.Location = new System.Drawing.Point(42, 200);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox2.Size = new System.Drawing.Size(757, 91);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Delete";
			// 
			// lbl_grade
			// 
			this.lbl_grade.AutoSize = true;
			this.lbl_grade.Location = new System.Drawing.Point(573, 20);
			this.lbl_grade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_grade.Name = "lbl_grade";
			this.lbl_grade.Size = new System.Drawing.Size(48, 17);
			this.lbl_grade.TabIndex = 2;
			this.lbl_grade.Text = "Grade";
			// 
			// lbl_generator
			// 
			this.lbl_generator.AutoSize = true;
			this.lbl_generator.Location = new System.Drawing.Point(458, 20);
			this.lbl_generator.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_generator.Name = "lbl_generator";
			this.lbl_generator.Size = new System.Drawing.Size(73, 17);
			this.lbl_generator.TabIndex = 2;
			this.lbl_generator.Text = "Generator";
			// 
			// label
			// 
			this.label.AutoSize = true;
			this.label.Location = new System.Drawing.Point(342, 20);
			this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(53, 17);
			this.label.TabIndex = 2;
			this.label.Text = "Course";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(226, 20);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(21, 17);
			this.label5.TabIndex = 2;
			this.label5.Text = "ID";
			// 
			// txt_grade
			// 
			this.txt_grade.Location = new System.Drawing.Point(576, 39);
			this.txt_grade.Margin = new System.Windows.Forms.Padding(2);
			this.txt_grade.Name = "txt_grade";
			this.txt_grade.ReadOnly = true;
			this.txt_grade.Size = new System.Drawing.Size(116, 23);
			this.txt_grade.TabIndex = 1;
			// 
			// txt_generator
			// 
			this.txt_generator.Location = new System.Drawing.Point(460, 39);
			this.txt_generator.Margin = new System.Windows.Forms.Padding(2);
			this.txt_generator.Name = "txt_generator";
			this.txt_generator.ReadOnly = true;
			this.txt_generator.Size = new System.Drawing.Size(116, 23);
			this.txt_generator.TabIndex = 1;
			// 
			// txt_course
			// 
			this.txt_course.Location = new System.Drawing.Point(345, 39);
			this.txt_course.Margin = new System.Windows.Forms.Padding(2);
			this.txt_course.Name = "txt_course";
			this.txt_course.ReadOnly = true;
			this.txt_course.Size = new System.Drawing.Size(116, 23);
			this.txt_course.TabIndex = 1;
			// 
			// txt_ex_id
			// 
			this.txt_ex_id.Location = new System.Drawing.Point(230, 39);
			this.txt_ex_id.Margin = new System.Windows.Forms.Padding(2);
			this.txt_ex_id.Name = "txt_ex_id";
			this.txt_ex_id.ReadOnly = true;
			this.txt_ex_id.Size = new System.Drawing.Size(116, 23);
			this.txt_ex_id.TabIndex = 1;
			// 
			// txt_id
			// 
			this.txt_id.Location = new System.Drawing.Point(73, 39);
			this.txt_id.Margin = new System.Windows.Forms.Padding(2);
			this.txt_id.Name = "txt_id";
			this.txt_id.Size = new System.Drawing.Size(76, 23);
			this.txt_id.TabIndex = 1;
			this.txt_id.TextChanged += new System.EventHandler(this.txt_id_TextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(38, 41);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(21, 17);
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
			this.groupBox1.Location = new System.Drawing.Point(42, 93);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox1.Size = new System.Drawing.Size(757, 91);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Generate exam";
			// 
			// txt_examGrade
			// 
			this.txt_examGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_examGrade.Location = new System.Drawing.Point(406, 41);
			this.txt_examGrade.Margin = new System.Windows.Forms.Padding(2);
			this.txt_examGrade.Name = "txt_examGrade";
			this.txt_examGrade.Size = new System.Drawing.Size(76, 26);
			this.txt_examGrade.TabIndex = 4;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(355, 43);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(54, 20);
			this.label6.TabIndex = 3;
			this.label6.Text = "Grade";
			// 
			// cmbo_crsname
			// 
			this.cmbo_crsname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbo_crsname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbo_crsname.FormattingEnabled = true;
			this.cmbo_crsname.Location = new System.Drawing.Point(584, 40);
			this.cmbo_crsname.Margin = new System.Windows.Forms.Padding(2);
			this.cmbo_crsname.Name = "cmbo_crsname";
			this.cmbo_crsname.Size = new System.Drawing.Size(165, 28);
			this.cmbo_crsname.TabIndex = 2;
			this.cmbo_crsname.DropDown += new System.EventHandler(this.cmbo_crsname_DropDown);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(484, 43);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(104, 20);
			this.label3.TabIndex = 0;
			this.label3.Text = "Course name";
			// 
			// txt_tfq
			// 
			this.txt_tfq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_tfq.Location = new System.Drawing.Point(249, 41);
			this.txt_tfq.Margin = new System.Windows.Forms.Padding(2);
			this.txt_tfq.Name = "txt_tfq";
			this.txt_tfq.Size = new System.Drawing.Size(104, 26);
			this.txt_tfq.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(181, 43);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 20);
			this.label2.TabIndex = 0;
			this.label2.Text = "TFQ No.";
			// 
			// txt_mcq
			// 
			this.txt_mcq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_mcq.Location = new System.Drawing.Point(75, 41);
			this.txt_mcq.Margin = new System.Windows.Forms.Padding(2);
			this.txt_mcq.Name = "txt_mcq";
			this.txt_mcq.Size = new System.Drawing.Size(104, 26);
			this.txt_mcq.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(2, 43);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "MCQ No.";
			// 
			// btn_display
			// 
			this.btn_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_display.Location = new System.Drawing.Point(542, 24);
			this.btn_display.Margin = new System.Windows.Forms.Padding(2);
			this.btn_display.Name = "btn_display";
			this.btn_display.Size = new System.Drawing.Size(256, 46);
			this.btn_display.TabIndex = 1;
			this.btn_display.Text = "Display exams";
			this.btn_display.UseVisualStyleBackColor = true;
			this.btn_display.Click += new System.EventHandler(this.btn_display_Click);
			// 
			// btn_delete
			// 
			this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_delete.Location = new System.Drawing.Point(286, 24);
			this.btn_delete.Margin = new System.Windows.Forms.Padding(2);
			this.btn_delete.Name = "btn_delete";
			this.btn_delete.Size = new System.Drawing.Size(256, 46);
			this.btn_delete.TabIndex = 1;
			this.btn_delete.Text = "Delete";
			this.btn_delete.UseVisualStyleBackColor = true;
			this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
			// 
			// btn_generate
			// 
			this.btn_generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_generate.Location = new System.Drawing.Point(29, 24);
			this.btn_generate.Margin = new System.Windows.Forms.Padding(2);
			this.btn_generate.Name = "btn_generate";
			this.btn_generate.Size = new System.Drawing.Size(256, 46);
			this.btn_generate.TabIndex = 0;
			this.btn_generate.Text = "Generate";
			this.btn_generate.UseVisualStyleBackColor = true;
			this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
			// 
			// tabpage_department
			// 
			this.tabpage_department.Controls.Add(this.date_deptHire);
			this.tabpage_department.Controls.Add(this.label11);
			this.tabpage_department.Controls.Add(this.cmbo_deptManager);
			this.tabpage_department.Controls.Add(this.label10);
			this.tabpage_department.Controls.Add(this.label9);
			this.tabpage_department.Controls.Add(this.txt_deptLoc);
			this.tabpage_department.Controls.Add(this.txt_deptName);
			this.tabpage_department.Controls.Add(this.label8);
			this.tabpage_department.Controls.Add(this.txt_deptId);
			this.tabpage_department.Controls.Add(this.label7);
			this.tabpage_department.Controls.Add(this.btn_deptInsert);
			this.tabpage_department.Controls.Add(this.btn_deptDelete);
			this.tabpage_department.Controls.Add(this.btn_deptDisplayByname);
			this.tabpage_department.Controls.Add(this.btn_deptDisplay);
			this.tabpage_department.Controls.Add(this.btn_dept_update);
			this.tabpage_department.Controls.Add(this.lst_department);
			this.tabpage_department.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabpage_department.Location = new System.Drawing.Point(4, 29);
			this.tabpage_department.Margin = new System.Windows.Forms.Padding(2);
			this.tabpage_department.Name = "tabpage_department";
			this.tabpage_department.Padding = new System.Windows.Forms.Padding(2);
			this.tabpage_department.Size = new System.Drawing.Size(825, 450);
			this.tabpage_department.TabIndex = 1;
			this.tabpage_department.Text = "Departments";
			this.tabpage_department.UseVisualStyleBackColor = true;
			// 
			// date_deptHire
			// 
			this.date_deptHire.Location = new System.Drawing.Point(150, 348);
			this.date_deptHire.Margin = new System.Windows.Forms.Padding(2);
			this.date_deptHire.Name = "date_deptHire";
			this.date_deptHire.Size = new System.Drawing.Size(169, 26);
			this.date_deptHire.TabIndex = 6;
			this.date_deptHire.Value = new System.DateTime(2022, 3, 17, 1, 9, 56, 0);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(16, 377);
			this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(72, 20);
			this.label11.TabIndex = 5;
			this.label11.Text = "Manager";
			// 
			// cmbo_deptManager
			// 
			this.cmbo_deptManager.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbo_deptManager.FormattingEnabled = true;
			this.cmbo_deptManager.Location = new System.Drawing.Point(150, 375);
			this.cmbo_deptManager.Margin = new System.Windows.Forms.Padding(2);
			this.cmbo_deptManager.Name = "cmbo_deptManager";
			this.cmbo_deptManager.Size = new System.Drawing.Size(169, 28);
			this.cmbo_deptManager.TabIndex = 4;
			this.cmbo_deptManager.DropDown += new System.EventHandler(this.cmbo_deptManager_DropDown);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(16, 345);
			this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(141, 20);
			this.label10.TabIndex = 2;
			this.label10.Text = "Manager Hire date";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(16, 316);
			this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(70, 20);
			this.label9.TabIndex = 2;
			this.label9.Text = "Location";
			// 
			// txt_deptLoc
			// 
			this.txt_deptLoc.Location = new System.Drawing.Point(150, 318);
			this.txt_deptLoc.Margin = new System.Windows.Forms.Padding(2);
			this.txt_deptLoc.Name = "txt_deptLoc";
			this.txt_deptLoc.Size = new System.Drawing.Size(169, 26);
			this.txt_deptLoc.TabIndex = 3;
			// 
			// txt_deptName
			// 
			this.txt_deptName.Location = new System.Drawing.Point(150, 287);
			this.txt_deptName.Margin = new System.Windows.Forms.Padding(2);
			this.txt_deptName.Name = "txt_deptName";
			this.txt_deptName.Size = new System.Drawing.Size(169, 26);
			this.txt_deptName.TabIndex = 3;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(16, 287);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(51, 20);
			this.label8.TabIndex = 2;
			this.label8.Text = "Name";
			// 
			// txt_deptId
			// 
			this.txt_deptId.Location = new System.Drawing.Point(150, 258);
			this.txt_deptId.Margin = new System.Windows.Forms.Padding(2);
			this.txt_deptId.Name = "txt_deptId";
			this.txt_deptId.ReadOnly = true;
			this.txt_deptId.Size = new System.Drawing.Size(169, 26);
			this.txt_deptId.TabIndex = 3;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(16, 258);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(26, 20);
			this.label7.TabIndex = 2;
			this.label7.Text = "ID";
			// 
			// btn_deptInsert
			// 
			this.btn_deptInsert.Location = new System.Drawing.Point(410, 335);
			this.btn_deptInsert.Margin = new System.Windows.Forms.Padding(2);
			this.btn_deptInsert.Name = "btn_deptInsert";
			this.btn_deptInsert.Size = new System.Drawing.Size(182, 46);
			this.btn_deptInsert.TabIndex = 1;
			this.btn_deptInsert.Text = "Insert";
			this.btn_deptInsert.UseVisualStyleBackColor = true;
			this.btn_deptInsert.Click += new System.EventHandler(this.btn_deptInsert_Click);
			// 
			// btn_deptDelete
			// 
			this.btn_deptDelete.Location = new System.Drawing.Point(625, 335);
			this.btn_deptDelete.Margin = new System.Windows.Forms.Padding(2);
			this.btn_deptDelete.Name = "btn_deptDelete";
			this.btn_deptDelete.Size = new System.Drawing.Size(182, 46);
			this.btn_deptDelete.TabIndex = 1;
			this.btn_deptDelete.Text = "Delete";
			this.btn_deptDelete.UseVisualStyleBackColor = true;
			this.btn_deptDelete.Click += new System.EventHandler(this.btn_deptDelete_Click);
			// 
			// btn_deptDisplayByname
			// 
			this.btn_deptDisplayByname.Location = new System.Drawing.Point(530, 385);
			this.btn_deptDisplayByname.Margin = new System.Windows.Forms.Padding(2);
			this.btn_deptDisplayByname.Name = "btn_deptDisplayByname";
			this.btn_deptDisplayByname.Size = new System.Drawing.Size(182, 46);
			this.btn_deptDisplayByname.TabIndex = 1;
			this.btn_deptDisplayByname.Text = "Display by Dept name";
			this.btn_deptDisplayByname.UseVisualStyleBackColor = true;
			this.btn_deptDisplayByname.Click += new System.EventHandler(this.btn_deptDisplayByname_Click);
			// 
			// btn_deptDisplay
			// 
			this.btn_deptDisplay.Location = new System.Drawing.Point(410, 267);
			this.btn_deptDisplay.Margin = new System.Windows.Forms.Padding(2);
			this.btn_deptDisplay.Name = "btn_deptDisplay";
			this.btn_deptDisplay.Size = new System.Drawing.Size(182, 46);
			this.btn_deptDisplay.TabIndex = 1;
			this.btn_deptDisplay.Text = "Display";
			this.btn_deptDisplay.UseVisualStyleBackColor = true;
			this.btn_deptDisplay.Click += new System.EventHandler(this.btn_deptDisplay_Click);
			// 
			// btn_dept_update
			// 
			this.btn_dept_update.Location = new System.Drawing.Point(625, 267);
			this.btn_dept_update.Margin = new System.Windows.Forms.Padding(2);
			this.btn_dept_update.Name = "btn_dept_update";
			this.btn_dept_update.Size = new System.Drawing.Size(182, 46);
			this.btn_dept_update.TabIndex = 1;
			this.btn_dept_update.Text = "Update";
			this.btn_dept_update.UseVisualStyleBackColor = true;
			this.btn_dept_update.Click += new System.EventHandler(this.btn_dept_update_Click);
			// 
			// lst_department
			// 
			this.lst_department.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
			this.lst_department.Dock = System.Windows.Forms.DockStyle.Top;
			this.lst_department.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lst_department.FullRowSelect = true;
			this.lst_department.HideSelection = false;
			this.lst_department.Location = new System.Drawing.Point(2, 2);
			this.lst_department.Margin = new System.Windows.Forms.Padding(2);
			this.lst_department.Name = "lst_department";
			this.lst_department.Size = new System.Drawing.Size(821, 238);
			this.lst_department.TabIndex = 0;
			this.lst_department.UseCompatibleStateImageBehavior = false;
			this.lst_department.View = System.Windows.Forms.View.Details;
			this.lst_department.Click += new System.EventHandler(this.lst_department_Click);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "ID";
			this.columnHeader1.Width = 100;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Name";
			this.columnHeader2.Width = 100;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Location";
			this.columnHeader3.Width = 100;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Manager hire date";
			this.columnHeader4.Width = 150;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Manager";
			this.columnHeader5.Width = 100;
			// 
			// tabpage_students
			// 
			this.tabpage_students.Controls.Add(this.StdLNameFld);
			this.tabpage_students.Controls.Add(this.label18);
			this.tabpage_students.Controls.Add(this.StdAddressFld);
			this.tabpage_students.Controls.Add(this.label17);
			this.tabpage_students.Controls.Add(this.StdFnameField);
			this.tabpage_students.Controls.Add(this.StdBirthFld);
			this.tabpage_students.Controls.Add(this.label12);
			this.tabpage_students.Controls.Add(this.label13);
			this.tabpage_students.Controls.Add(this.label14);
			this.tabpage_students.Controls.Add(this.StdDepartmentFiled);
			this.tabpage_students.Controls.Add(this.StdUserNameField);
			this.tabpage_students.Controls.Add(this.label15);
			this.tabpage_students.Controls.Add(this.StdIdField);
			this.tabpage_students.Controls.Add(this.label16);
			this.tabpage_students.Controls.Add(this.StdList);
			this.tabpage_students.Controls.Add(this.InsertStd);
			this.tabpage_students.Controls.Add(this.DeleteStd);
			this.tabpage_students.Controls.Add(this.DisplayStdByName);
			this.tabpage_students.Controls.Add(this.DisplayStd);
			this.tabpage_students.Controls.Add(this.UpdateStd);
			this.tabpage_students.Location = new System.Drawing.Point(4, 29);
			this.tabpage_students.Margin = new System.Windows.Forms.Padding(2);
			this.tabpage_students.Name = "tabpage_students";
			this.tabpage_students.Padding = new System.Windows.Forms.Padding(2);
			this.tabpage_students.Size = new System.Drawing.Size(825, 450);
			this.tabpage_students.TabIndex = 2;
			this.tabpage_students.Text = "Students";
			this.tabpage_students.UseVisualStyleBackColor = true;
			// 
			// StdLNameFld
			// 
			this.StdLNameFld.Location = new System.Drawing.Point(144, 364);
			this.StdLNameFld.Margin = new System.Windows.Forms.Padding(2);
			this.StdLNameFld.Name = "StdLNameFld";
			this.StdLNameFld.Size = new System.Drawing.Size(169, 26);
			this.StdLNameFld.TabIndex = 22;
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(10, 415);
			this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(68, 20);
			this.label18.TabIndex = 20;
			this.label18.Text = "Address";
			// 
			// StdAddressFld
			// 
			this.StdAddressFld.Location = new System.Drawing.Point(144, 420);
			this.StdAddressFld.Margin = new System.Windows.Forms.Padding(2);
			this.StdAddressFld.Name = "StdAddressFld";
			this.StdAddressFld.Size = new System.Drawing.Size(169, 26);
			this.StdAddressFld.TabIndex = 21;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(10, 389);
			this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(42, 20);
			this.label17.TabIndex = 18;
			this.label17.Text = "Birth";
			// 
			// StdFnameField
			// 
			this.StdFnameField.Location = new System.Drawing.Point(144, 334);
			this.StdFnameField.Margin = new System.Windows.Forms.Padding(2);
			this.StdFnameField.Name = "StdFnameField";
			this.StdFnameField.Size = new System.Drawing.Size(169, 26);
			this.StdFnameField.TabIndex = 19;
			// 
			// StdBirthFld
			// 
			this.StdBirthFld.Location = new System.Drawing.Point(144, 393);
			this.StdBirthFld.Margin = new System.Windows.Forms.Padding(2);
			this.StdBirthFld.Name = "StdBirthFld";
			this.StdBirthFld.Size = new System.Drawing.Size(169, 26);
			this.StdBirthFld.TabIndex = 17;
			this.StdBirthFld.Value = new System.DateTime(2022, 3, 17, 1, 9, 56, 0);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(10, 363);
			this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(86, 20);
			this.label12.TabIndex = 16;
			this.label12.Text = "Last Name";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(10, 331);
			this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(86, 20);
			this.label13.TabIndex = 8;
			this.label13.Text = "First Name";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(10, 302);
			this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(94, 20);
			this.label14.TabIndex = 9;
			this.label14.Text = "Deaprtment";
			// 
			// StdDepartmentFiled
			// 
			this.StdDepartmentFiled.Location = new System.Drawing.Point(144, 304);
			this.StdDepartmentFiled.Margin = new System.Windows.Forms.Padding(2);
			this.StdDepartmentFiled.Name = "StdDepartmentFiled";
			this.StdDepartmentFiled.Size = new System.Drawing.Size(169, 26);
			this.StdDepartmentFiled.TabIndex = 12;
			// 
			// StdUserNameField
			// 
			this.StdUserNameField.Location = new System.Drawing.Point(144, 273);
			this.StdUserNameField.Margin = new System.Windows.Forms.Padding(2);
			this.StdUserNameField.Name = "StdUserNameField";
			this.StdUserNameField.Size = new System.Drawing.Size(169, 26);
			this.StdUserNameField.TabIndex = 13;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(10, 273);
			this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(89, 20);
			this.label15.TabIndex = 10;
			this.label15.Text = "User Name";
			// 
			// StdIdField
			// 
			this.StdIdField.Location = new System.Drawing.Point(144, 244);
			this.StdIdField.Margin = new System.Windows.Forms.Padding(2);
			this.StdIdField.Name = "StdIdField";
			this.StdIdField.ReadOnly = true;
			this.StdIdField.Size = new System.Drawing.Size(169, 26);
			this.StdIdField.TabIndex = 14;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(10, 244);
			this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(26, 20);
			this.label16.TabIndex = 11;
			this.label16.Text = "ID";
			// 
			// StdList
			// 
			this.StdList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
			this.StdList.Dock = System.Windows.Forms.DockStyle.Top;
			this.StdList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.StdList.FullRowSelect = true;
			this.StdList.HideSelection = false;
			this.StdList.Location = new System.Drawing.Point(2, 2);
			this.StdList.Margin = new System.Windows.Forms.Padding(2);
			this.StdList.Name = "StdList";
			this.StdList.Size = new System.Drawing.Size(821, 238);
			this.StdList.TabIndex = 7;
			this.StdList.UseCompatibleStateImageBehavior = false;
			this.StdList.View = System.Windows.Forms.View.Details;
			this.StdList.Click += new System.EventHandler(this.StdList_Click);
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Id";
			this.columnHeader6.Width = 100;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "User Name";
			this.columnHeader7.Width = 100;
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "Department";
			this.columnHeader8.Width = 143;
			// 
			// columnHeader9
			// 
			this.columnHeader9.Text = "First Name";
			this.columnHeader9.Width = 116;
			// 
			// columnHeader10
			// 
			this.columnHeader10.Text = "Last Name";
			this.columnHeader10.Width = 100;
			// 
			// columnHeader11
			// 
			this.columnHeader11.Text = "Birth";
			this.columnHeader11.Width = 100;
			// 
			// columnHeader12
			// 
			this.columnHeader12.Text = "Address";
			this.columnHeader12.Width = 100;
			// 
			// InsertStd
			// 
			this.InsertStd.Location = new System.Drawing.Point(411, 339);
			this.InsertStd.Margin = new System.Windows.Forms.Padding(2);
			this.InsertStd.Name = "InsertStd";
			this.InsertStd.Size = new System.Drawing.Size(182, 46);
			this.InsertStd.TabIndex = 2;
			this.InsertStd.Text = "Insert";
			this.InsertStd.UseVisualStyleBackColor = true;
			this.InsertStd.Click += new System.EventHandler(this.InsertStd_Click);
			// 
			// DeleteStd
			// 
			this.DeleteStd.Location = new System.Drawing.Point(626, 339);
			this.DeleteStd.Margin = new System.Windows.Forms.Padding(2);
			this.DeleteStd.Name = "DeleteStd";
			this.DeleteStd.Size = new System.Drawing.Size(182, 46);
			this.DeleteStd.TabIndex = 3;
			this.DeleteStd.Text = "Delete";
			this.DeleteStd.UseVisualStyleBackColor = true;
			this.DeleteStd.Click += new System.EventHandler(this.DeleteStd_Click);
			// 
			// DisplayStdByName
			// 
			this.DisplayStdByName.Location = new System.Drawing.Point(496, 389);
			this.DisplayStdByName.Margin = new System.Windows.Forms.Padding(2);
			this.DisplayStdByName.Name = "DisplayStdByName";
			this.DisplayStdByName.Size = new System.Drawing.Size(229, 46);
			this.DisplayStdByName.TabIndex = 4;
			this.DisplayStdByName.Text = "Display by Student Name";
			this.DisplayStdByName.UseVisualStyleBackColor = true;
			this.DisplayStdByName.Click += new System.EventHandler(this.DisplayStdByName_Click);
			// 
			// DisplayStd
			// 
			this.DisplayStd.Location = new System.Drawing.Point(411, 271);
			this.DisplayStd.Margin = new System.Windows.Forms.Padding(2);
			this.DisplayStd.Name = "DisplayStd";
			this.DisplayStd.Size = new System.Drawing.Size(182, 46);
			this.DisplayStd.TabIndex = 5;
			this.DisplayStd.Text = "Display";
			this.DisplayStd.UseVisualStyleBackColor = true;
			this.DisplayStd.Click += new System.EventHandler(this.DisplayStd_Click);
			// 
			// UpdateStd
			// 
			this.UpdateStd.Location = new System.Drawing.Point(626, 271);
			this.UpdateStd.Margin = new System.Windows.Forms.Padding(2);
			this.UpdateStd.Name = "UpdateStd";
			this.UpdateStd.Size = new System.Drawing.Size(182, 46);
			this.UpdateStd.TabIndex = 6;
			this.UpdateStd.Text = "Update";
			this.UpdateStd.UseVisualStyleBackColor = true;
			this.UpdateStd.Click += new System.EventHandler(this.UpdateStd_Click);
			// 
			// tabPage_questions
			// 
			this.tabPage_questions.Location = new System.Drawing.Point(4, 29);
			this.tabPage_questions.Margin = new System.Windows.Forms.Padding(2);
			this.tabPage_questions.Name = "tabPage_questions";
			this.tabPage_questions.Padding = new System.Windows.Forms.Padding(2);
			this.tabPage_questions.Size = new System.Drawing.Size(825, 450);
			this.tabPage_questions.TabIndex = 3;
			this.tabPage_questions.Text = "Questions";
			this.tabPage_questions.UseVisualStyleBackColor = true;
			// 
			// tabPage_users
			// 
			this.tabPage_users.Location = new System.Drawing.Point(4, 29);
			this.tabPage_users.Margin = new System.Windows.Forms.Padding(2);
			this.tabPage_users.Name = "tabPage_users";
			this.tabPage_users.Padding = new System.Windows.Forms.Padding(2);
			this.tabPage_users.Size = new System.Drawing.Size(825, 450);
			this.tabPage_users.TabIndex = 4;
			this.tabPage_users.Text = "Users";
			this.tabPage_users.UseVisualStyleBackColor = true;
			// 
			// tabPage_Reports
			// 
			this.tabPage_Reports.Location = new System.Drawing.Point(4, 29);
			this.tabPage_Reports.Margin = new System.Windows.Forms.Padding(2);
			this.tabPage_Reports.Name = "tabPage_Reports";
			this.tabPage_Reports.Padding = new System.Windows.Forms.Padding(2);
			this.tabPage_Reports.Size = new System.Drawing.Size(825, 450);
			this.tabPage_Reports.TabIndex = 5;
			this.tabPage_Reports.Text = "Reports";
			this.tabPage_Reports.UseVisualStyleBackColor = true;
			// 
			// tabPage_instructors
			// 
			this.tabPage_instructors.Location = new System.Drawing.Point(4, 29);
			this.tabPage_instructors.Margin = new System.Windows.Forms.Padding(2);
			this.tabPage_instructors.Name = "tabPage_instructors";
			this.tabPage_instructors.Padding = new System.Windows.Forms.Padding(2);
			this.tabPage_instructors.Size = new System.Drawing.Size(825, 450);
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
			this.panel1.Margin = new System.Windows.Forms.Padding(2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(150, 483);
			this.panel1.TabIndex = 4;
			// 
			// instructorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(989, 483);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.tabCtrl_DashBoard);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(1005, 522);
			this.MinimumSize = new System.Drawing.Size(1005, 522);
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
			this.tabpage_department.ResumeLayout(false);
			this.tabpage_department.PerformLayout();
			this.tabpage_students.ResumeLayout(false);
			this.tabpage_students.PerformLayout();
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
        private System.Windows.Forms.ColumnHeader clm_id;
        private System.Windows.Forms.ColumnHeader clm_crs;
        private System.Windows.Forms.ColumnHeader clm_ins;
        private System.Windows.Forms.ColumnHeader clm_grade;
        private System.Windows.Forms.ListView lst_department;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btn_deptInsert;
        private System.Windows.Forms.Button btn_deptDelete;
        private System.Windows.Forms.Button btn_deptDisplay;
        private System.Windows.Forms.Button btn_dept_update;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_deptName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_deptId;
        private System.Windows.Forms.ComboBox cmbo_deptManager;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_deptLoc;
        private System.Windows.Forms.DateTimePicker date_deptHire;
        private System.Windows.Forms.Button btn_deptDisplayByname;
		private System.Windows.Forms.Button InsertStd;
		private System.Windows.Forms.Button DeleteStd;
		private System.Windows.Forms.Button DisplayStdByName;
		private System.Windows.Forms.Button DisplayStd;
		private System.Windows.Forms.Button UpdateStd;
		private System.Windows.Forms.ListView StdList;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.ColumnHeader columnHeader9;
		private System.Windows.Forms.ColumnHeader columnHeader10;
		private System.Windows.Forms.ColumnHeader columnHeader11;
		private System.Windows.Forms.ColumnHeader columnHeader12;
		private System.Windows.Forms.DateTimePicker StdBirthFld;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox StdDepartmentFiled;
		private System.Windows.Forms.TextBox StdUserNameField;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox StdIdField;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.TextBox StdAddressFld;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox StdFnameField;
		private System.Windows.Forms.TextBox StdLNameFld;
	}
}