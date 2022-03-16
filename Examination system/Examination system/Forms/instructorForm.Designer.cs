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
            this.tabCtrl_DashBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.tabpage_exams.Location = new System.Drawing.Point(4, 34);
            this.tabpage_exams.Name = "tabpage_exams";
            this.tabpage_exams.Padding = new System.Windows.Forms.Padding(3);
            this.tabpage_exams.Size = new System.Drawing.Size(1103, 548);
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
            this.listView1.Location = new System.Drawing.Point(3, 23);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1003, 146);
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
            // txt_examGrade
            // 
            this.txt_examGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_examGrade.Location = new System.Drawing.Point(542, 50);
            this.txt_examGrade.Name = "txt_examGrade";
            this.txt_examGrade.Size = new System.Drawing.Size(100, 30);
            this.txt_examGrade.TabIndex = 4;
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
            this.btn_display.Text = "Display exams";
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
            this.tabpage_department.Location = new System.Drawing.Point(4, 34);
            this.tabpage_department.Name = "tabpage_department";
            this.tabpage_department.Padding = new System.Windows.Forms.Padding(3);
            this.tabpage_department.Size = new System.Drawing.Size(1103, 548);
            this.tabpage_department.TabIndex = 1;
            this.tabpage_department.Text = "Departments";
            this.tabpage_department.UseVisualStyleBackColor = true;
            // 
            // date_deptHire
            // 
            this.date_deptHire.Location = new System.Drawing.Point(200, 428);
            this.date_deptHire.Name = "date_deptHire";
            this.date_deptHire.Size = new System.Drawing.Size(224, 30);
            this.date_deptHire.TabIndex = 6;
            this.date_deptHire.Value = new System.DateTime(2022, 3, 17, 1, 9, 56, 0);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 464);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 25);
            this.label11.TabIndex = 5;
            this.label11.Text = "Manager";
            // 
            // cmbo_deptManager
            // 
            this.cmbo_deptManager.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbo_deptManager.FormattingEnabled = true;
            this.cmbo_deptManager.Location = new System.Drawing.Point(200, 461);
            this.cmbo_deptManager.Name = "cmbo_deptManager";
            this.cmbo_deptManager.Size = new System.Drawing.Size(224, 33);
            this.cmbo_deptManager.TabIndex = 4;
            this.cmbo_deptManager.DropDown += new System.EventHandler(this.cmbo_deptManager_DropDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 425);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(173, 25);
            this.label10.TabIndex = 2;
            this.label10.Text = "Manager Hire date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 389);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "Location";
            // 
            // txt_deptLoc
            // 
            this.txt_deptLoc.Location = new System.Drawing.Point(200, 392);
            this.txt_deptLoc.Name = "txt_deptLoc";
            this.txt_deptLoc.Size = new System.Drawing.Size(224, 30);
            this.txt_deptLoc.TabIndex = 3;
            // 
            // txt_deptName
            // 
            this.txt_deptName.Location = new System.Drawing.Point(200, 353);
            this.txt_deptName.Name = "txt_deptName";
            this.txt_deptName.Size = new System.Drawing.Size(224, 30);
            this.txt_deptName.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 353);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "Name";
            // 
            // txt_deptId
            // 
            this.txt_deptId.Location = new System.Drawing.Point(200, 317);
            this.txt_deptId.Name = "txt_deptId";
            this.txt_deptId.ReadOnly = true;
            this.txt_deptId.Size = new System.Drawing.Size(224, 30);
            this.txt_deptId.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "ID";
            // 
            // btn_deptInsert
            // 
            this.btn_deptInsert.Location = new System.Drawing.Point(546, 412);
            this.btn_deptInsert.Name = "btn_deptInsert";
            this.btn_deptInsert.Size = new System.Drawing.Size(243, 56);
            this.btn_deptInsert.TabIndex = 1;
            this.btn_deptInsert.Text = "Insert";
            this.btn_deptInsert.UseVisualStyleBackColor = true;
            this.btn_deptInsert.Click += new System.EventHandler(this.btn_deptInsert_Click);
            // 
            // btn_deptDelete
            // 
            this.btn_deptDelete.Location = new System.Drawing.Point(833, 412);
            this.btn_deptDelete.Name = "btn_deptDelete";
            this.btn_deptDelete.Size = new System.Drawing.Size(243, 56);
            this.btn_deptDelete.TabIndex = 1;
            this.btn_deptDelete.Text = "Delete";
            this.btn_deptDelete.UseVisualStyleBackColor = true;
            this.btn_deptDelete.Click += new System.EventHandler(this.btn_deptDelete_Click);
            // 
            // btn_deptDisplayByname
            // 
            this.btn_deptDisplayByname.Location = new System.Drawing.Point(706, 474);
            this.btn_deptDisplayByname.Name = "btn_deptDisplayByname";
            this.btn_deptDisplayByname.Size = new System.Drawing.Size(243, 56);
            this.btn_deptDisplayByname.TabIndex = 1;
            this.btn_deptDisplayByname.Text = "Display by Dept name";
            this.btn_deptDisplayByname.UseVisualStyleBackColor = true;
            this.btn_deptDisplayByname.Click += new System.EventHandler(this.btn_deptDisplayByname_Click);
            // 
            // btn_deptDisplay
            // 
            this.btn_deptDisplay.Location = new System.Drawing.Point(546, 329);
            this.btn_deptDisplay.Name = "btn_deptDisplay";
            this.btn_deptDisplay.Size = new System.Drawing.Size(243, 56);
            this.btn_deptDisplay.TabIndex = 1;
            this.btn_deptDisplay.Text = "Display";
            this.btn_deptDisplay.UseVisualStyleBackColor = true;
            this.btn_deptDisplay.Click += new System.EventHandler(this.btn_deptDisplay_Click);
            // 
            // btn_dept_update
            // 
            this.btn_dept_update.Location = new System.Drawing.Point(833, 329);
            this.btn_dept_update.Name = "btn_dept_update";
            this.btn_dept_update.Size = new System.Drawing.Size(243, 56);
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
            this.lst_department.Location = new System.Drawing.Point(3, 3);
            this.lst_department.Name = "lst_department";
            this.lst_department.Size = new System.Drawing.Size(1097, 292);
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
            this.tabpage_students.Location = new System.Drawing.Point(4, 34);
            this.tabpage_students.Name = "tabpage_students";
            this.tabpage_students.Padding = new System.Windows.Forms.Padding(3);
            this.tabpage_students.Size = new System.Drawing.Size(1103, 548);
            this.tabpage_students.TabIndex = 2;
            this.tabpage_students.Text = "Students";
            this.tabpage_students.UseVisualStyleBackColor = true;
            // 
            // tabPage_questions
            // 
            this.tabPage_questions.Location = new System.Drawing.Point(4, 34);
            this.tabPage_questions.Name = "tabPage_questions";
            this.tabPage_questions.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_questions.Size = new System.Drawing.Size(1103, 548);
            this.tabPage_questions.TabIndex = 3;
            this.tabPage_questions.Text = "Questions";
            this.tabPage_questions.UseVisualStyleBackColor = true;
            // 
            // tabPage_users
            // 
            this.tabPage_users.Location = new System.Drawing.Point(4, 34);
            this.tabPage_users.Name = "tabPage_users";
            this.tabPage_users.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_users.Size = new System.Drawing.Size(1103, 548);
            this.tabPage_users.TabIndex = 4;
            this.tabPage_users.Text = "Users";
            this.tabPage_users.UseVisualStyleBackColor = true;
            // 
            // tabPage_Reports
            // 
            this.tabPage_Reports.Location = new System.Drawing.Point(4, 34);
            this.tabPage_Reports.Name = "tabPage_Reports";
            this.tabPage_Reports.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Reports.Size = new System.Drawing.Size(1103, 548);
            this.tabPage_Reports.TabIndex = 5;
            this.tabPage_Reports.Text = "Reports";
            this.tabPage_Reports.UseVisualStyleBackColor = true;
            // 
            // tabPage_instructors
            // 
            this.tabPage_instructors.Location = new System.Drawing.Point(4, 34);
            this.tabPage_instructors.Name = "tabPage_instructors";
            this.tabPage_instructors.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_instructors.Size = new System.Drawing.Size(1103, 548);
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
            this.tabpage_department.ResumeLayout(false);
            this.tabpage_department.PerformLayout();
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
    }
}