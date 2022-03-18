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
			this.tabPage1 = new System.Windows.Forms.TabPage();
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
			this.grp_TFQ = new System.Windows.Forms.GroupBox();
			this.txt_lastquesContentTFQ = new System.Windows.Forms.TextBox();
			this.btn_TfqAdd = new System.Windows.Forms.Button();
			this.label28 = new System.Windows.Forms.Label();
			this.cmbo_TfqModel = new System.Windows.Forms.ComboBox();
			this.label26 = new System.Windows.Forms.Label();
			this.lbl_lastquesIdTFQ = new System.Windows.Forms.Label();
			this.label30 = new System.Windows.Forms.Label();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.btn_search = new System.Windows.Forms.Button();
			this.txt_searchText = new System.Windows.Forms.TextBox();
			this.grp_choices = new System.Windows.Forms.GroupBox();
			this.cho4radio = new System.Windows.Forms.RadioButton();
			this.cho3radio = new System.Windows.Forms.RadioButton();
			this.cho2radio = new System.Windows.Forms.RadioButton();
			this.cho1radio = new System.Windows.Forms.RadioButton();
			this.button1 = new System.Windows.Forms.Button();
			this.txt_lastQuesContent = new System.Windows.Forms.TextBox();
			this.label32 = new System.Windows.Forms.Label();
			this.lbl_lastQuesID = new System.Windows.Forms.Label();
			this.label31 = new System.Windows.Forms.Label();
			this.txt_choice3Content = new System.Windows.Forms.TextBox();
			this.txt_choice4Content = new System.Windows.Forms.TextBox();
			this.txt_choice2Content = new System.Windows.Forms.TextBox();
			this.txt_choice1Content = new System.Windows.Forms.TextBox();
			this.label27 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.btn_choiceAdd = new System.Windows.Forms.Button();
			this.cmbo_quesType = new System.Windows.Forms.ComboBox();
			this.cmbo_QuesCourse = new System.Windows.Forms.ComboBox();
			this.label21 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.txt_quesContent = new System.Windows.Forms.TextBox();
			this.label24 = new System.Windows.Forms.Label();
			this.txt_quesId = new System.Windows.Forms.TextBox();
			this.label25 = new System.Windows.Forms.Label();
			this.btn_quesInsert = new System.Windows.Forms.Button();
			this.btn_quesDelete = new System.Windows.Forms.Button();
			this.btn_quesDisplay = new System.Windows.Forms.Button();
			this.lst_questions = new System.Windows.Forms.ListView();
			this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.tabPage_users = new System.Windows.Forms.TabPage();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.UserSexFld = new System.Windows.Forms.TextBox();
			this.UserPassFld = new System.Windows.Forms.TextBox();
			this.label29 = new System.Windows.Forms.Label();
			this.label33 = new System.Windows.Forms.Label();
			this.label34 = new System.Windows.Forms.Label();
			this.UserMailFld = new System.Windows.Forms.TextBox();
			this.UserUserNameFld = new System.Windows.Forms.TextBox();
			this.label35 = new System.Windows.Forms.Label();
			this.UserIdFld = new System.Windows.Forms.TextBox();
			this.label36 = new System.Windows.Forms.Label();
			this.InsertUserBtn = new System.Windows.Forms.Button();
			this.DeleteUser = new System.Windows.Forms.Button();
			this.DisplayUserByUserName = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.UpdateUser = new System.Windows.Forms.Button();
			this.UsersList = new System.Windows.Forms.ListView();
			this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.tabPage_instructors = new System.Windows.Forms.TabPage();
			this.InsDegFld = new System.Windows.Forms.TextBox();
			this.InsLnameFld = new System.Windows.Forms.TextBox();
			this.label37 = new System.Windows.Forms.Label();
			this.InsSalaryFld = new System.Windows.Forms.TextBox();
			this.label38 = new System.Windows.Forms.Label();
			this.InsFnameFld = new System.Windows.Forms.TextBox();
			this.label39 = new System.Windows.Forms.Label();
			this.label40 = new System.Windows.Forms.Label();
			this.labe55 = new System.Windows.Forms.Label();
			this.InsDeptFld = new System.Windows.Forms.TextBox();
			this.InsUserNameFld = new System.Windows.Forms.TextBox();
			this.label41 = new System.Windows.Forms.Label();
			this.InsIdFld = new System.Windows.Forms.TextBox();
			this.label42 = new System.Windows.Forms.Label();
			this.InsertIns = new System.Windows.Forms.Button();
			this.DeleteIns = new System.Windows.Forms.Button();
			this.DisplayInsByName = new System.Windows.Forms.Button();
			this.DisplayIns = new System.Windows.Forms.Button();
			this.UpdateIns = new System.Windows.Forms.Button();
			this.InsList = new System.Windows.Forms.ListView();
			this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader25 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader26 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader27 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader28 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader29 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.tabPage_Reports = new System.Windows.Forms.TabPage();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.tabCtrl_DashBoard.SuspendLayout();
			this.tabpage_exams.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tabpage_department.SuspendLayout();
			this.tabpage_students.SuspendLayout();
			this.tabPage_questions.SuspendLayout();
			this.grp_TFQ.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.grp_choices.SuspendLayout();
			this.tabPage_users.SuspendLayout();
			this.tabPage_instructors.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lbl_welcome
			// 
			this.lbl_welcome.AutoSize = true;
			this.lbl_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_welcome.Location = new System.Drawing.Point(17, 28);
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
			this.lbl_username.Location = new System.Drawing.Point(30, 54);
			this.lbl_username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_username.Name = "lbl_username";
			this.lbl_username.Size = new System.Drawing.Size(76, 26);
			this.lbl_username.TabIndex = 2;
			this.lbl_username.Text = "label1";
			// 
			// tabCtrl_DashBoard
			// 
			this.tabCtrl_DashBoard.Controls.Add(this.tabPage1);
			this.tabCtrl_DashBoard.Controls.Add(this.tabpage_exams);
			this.tabCtrl_DashBoard.Controls.Add(this.tabpage_department);
			this.tabCtrl_DashBoard.Controls.Add(this.tabpage_students);
			this.tabCtrl_DashBoard.Controls.Add(this.tabPage_questions);
			this.tabCtrl_DashBoard.Controls.Add(this.tabPage_users);
			this.tabCtrl_DashBoard.Controls.Add(this.tabPage_instructors);
			this.tabCtrl_DashBoard.Controls.Add(this.tabPage_Reports);
			this.tabCtrl_DashBoard.Dock = System.Windows.Forms.DockStyle.Right;
			this.tabCtrl_DashBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabCtrl_DashBoard.Location = new System.Drawing.Point(155, 0);
			this.tabCtrl_DashBoard.Margin = new System.Windows.Forms.Padding(2);
			this.tabCtrl_DashBoard.Name = "tabCtrl_DashBoard";
			this.tabCtrl_DashBoard.SelectedIndex = 0;
			this.tabCtrl_DashBoard.Size = new System.Drawing.Size(833, 609);
			this.tabCtrl_DashBoard.TabIndex = 3;
			// 
			// tabPage1
			// 
			this.tabPage1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
			this.tabPage1.BackgroundImage = global::Examination_system.Properties.Resources.image_processing20210504_13513_dw5uip;
			this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.tabPage1.Location = new System.Drawing.Point(4, 29);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(825, 576);
			this.tabPage1.TabIndex = 7;
			this.tabPage1.Text = "Home";
			this.tabPage1.UseVisualStyleBackColor = true;
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
			this.tabpage_exams.Size = new System.Drawing.Size(825, 576);
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
			this.tabpage_department.Size = new System.Drawing.Size(825, 576);
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
			this.btn_deptDelete.Enabled = false;
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
			this.btn_dept_update.Enabled = false;
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
			this.tabpage_students.Size = new System.Drawing.Size(825, 576);
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
			this.tabPage_questions.Controls.Add(this.grp_TFQ);
			this.tabPage_questions.Controls.Add(this.groupBox5);
			this.tabPage_questions.Controls.Add(this.grp_choices);
			this.tabPage_questions.Controls.Add(this.btn_choiceAdd);
			this.tabPage_questions.Controls.Add(this.cmbo_quesType);
			this.tabPage_questions.Controls.Add(this.cmbo_QuesCourse);
			this.tabPage_questions.Controls.Add(this.label21);
			this.tabPage_questions.Controls.Add(this.label23);
			this.tabPage_questions.Controls.Add(this.txt_quesContent);
			this.tabPage_questions.Controls.Add(this.label24);
			this.tabPage_questions.Controls.Add(this.txt_quesId);
			this.tabPage_questions.Controls.Add(this.label25);
			this.tabPage_questions.Controls.Add(this.btn_quesInsert);
			this.tabPage_questions.Controls.Add(this.btn_quesDelete);
			this.tabPage_questions.Controls.Add(this.btn_quesDisplay);
			this.tabPage_questions.Controls.Add(this.lst_questions);
			this.tabPage_questions.Location = new System.Drawing.Point(4, 29);
			this.tabPage_questions.Margin = new System.Windows.Forms.Padding(2);
			this.tabPage_questions.Name = "tabPage_questions";
			this.tabPage_questions.Padding = new System.Windows.Forms.Padding(2);
			this.tabPage_questions.Size = new System.Drawing.Size(825, 576);
			this.tabPage_questions.TabIndex = 3;
			this.tabPage_questions.Text = "Questions";
			this.tabPage_questions.UseVisualStyleBackColor = true;
			// 
			// grp_TFQ
			// 
			this.grp_TFQ.Controls.Add(this.txt_lastquesContentTFQ);
			this.grp_TFQ.Controls.Add(this.btn_TfqAdd);
			this.grp_TFQ.Controls.Add(this.label28);
			this.grp_TFQ.Controls.Add(this.cmbo_TfqModel);
			this.grp_TFQ.Controls.Add(this.label26);
			this.grp_TFQ.Controls.Add(this.lbl_lastquesIdTFQ);
			this.grp_TFQ.Controls.Add(this.label30);
			this.grp_TFQ.Enabled = false;
			this.grp_TFQ.Location = new System.Drawing.Point(19, 411);
			this.grp_TFQ.Margin = new System.Windows.Forms.Padding(2);
			this.grp_TFQ.Name = "grp_TFQ";
			this.grp_TFQ.Padding = new System.Windows.Forms.Padding(2);
			this.grp_TFQ.Size = new System.Drawing.Size(372, 163);
			this.grp_TFQ.TabIndex = 43;
			this.grp_TFQ.TabStop = false;
			this.grp_TFQ.Text = "TFQ";
			// 
			// txt_lastquesContentTFQ
			// 
			this.txt_lastquesContentTFQ.Location = new System.Drawing.Point(5, 78);
			this.txt_lastquesContentTFQ.Margin = new System.Windows.Forms.Padding(2);
			this.txt_lastquesContentTFQ.Name = "txt_lastquesContentTFQ";
			this.txt_lastquesContentTFQ.ReadOnly = true;
			this.txt_lastquesContentTFQ.Size = new System.Drawing.Size(362, 26);
			this.txt_lastquesContentTFQ.TabIndex = 15;
			// 
			// btn_TfqAdd
			// 
			this.btn_TfqAdd.Location = new System.Drawing.Point(255, 118);
			this.btn_TfqAdd.Margin = new System.Windows.Forms.Padding(2);
			this.btn_TfqAdd.Name = "btn_TfqAdd";
			this.btn_TfqAdd.Size = new System.Drawing.Size(73, 31);
			this.btn_TfqAdd.TabIndex = 12;
			this.btn_TfqAdd.Text = "Add";
			this.btn_TfqAdd.UseVisualStyleBackColor = true;
			this.btn_TfqAdd.Click += new System.EventHandler(this.btn_TfqAdd_Click);
			// 
			// label28
			// 
			this.label28.AutoSize = true;
			this.label28.Location = new System.Drawing.Point(14, 54);
			this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(138, 20);
			this.label28.TabIndex = 12;
			this.label28.Text = "Question Content:";
			// 
			// cmbo_TfqModel
			// 
			this.cmbo_TfqModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbo_TfqModel.FormattingEnabled = true;
			this.cmbo_TfqModel.Items.AddRange(new object[] {
            "True",
            "False"});
			this.cmbo_TfqModel.Location = new System.Drawing.Point(120, 120);
			this.cmbo_TfqModel.Margin = new System.Windows.Forms.Padding(2);
			this.cmbo_TfqModel.Name = "cmbo_TfqModel";
			this.cmbo_TfqModel.Size = new System.Drawing.Size(92, 28);
			this.cmbo_TfqModel.TabIndex = 2;
			// 
			// label26
			// 
			this.label26.AutoSize = true;
			this.label26.Location = new System.Drawing.Point(14, 124);
			this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(107, 20);
			this.label26.TabIndex = 1;
			this.label26.Text = "Model answer";
			// 
			// lbl_lastquesIdTFQ
			// 
			this.lbl_lastquesIdTFQ.AutoSize = true;
			this.lbl_lastquesIdTFQ.ForeColor = System.Drawing.Color.Red;
			this.lbl_lastquesIdTFQ.Location = new System.Drawing.Point(105, 30);
			this.lbl_lastquesIdTFQ.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_lastquesIdTFQ.Name = "lbl_lastquesIdTFQ";
			this.lbl_lastquesIdTFQ.Size = new System.Drawing.Size(94, 20);
			this.lbl_lastquesIdTFQ.TabIndex = 14;
			this.lbl_lastquesIdTFQ.Text = "Question ID";
			// 
			// label30
			// 
			this.label30.AutoSize = true;
			this.label30.Location = new System.Drawing.Point(14, 30);
			this.label30.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(98, 20);
			this.label30.TabIndex = 13;
			this.label30.Text = "Question ID:";
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.btn_search);
			this.groupBox5.Controls.Add(this.txt_searchText);
			this.groupBox5.Location = new System.Drawing.Point(19, 344);
			this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox5.Size = new System.Drawing.Size(364, 53);
			this.groupBox5.TabIndex = 42;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Search";
			// 
			// btn_search
			// 
			this.btn_search.Location = new System.Drawing.Point(260, 24);
			this.btn_search.Margin = new System.Windows.Forms.Padding(2);
			this.btn_search.Name = "btn_search";
			this.btn_search.Size = new System.Drawing.Size(100, 24);
			this.btn_search.TabIndex = 41;
			this.btn_search.Text = "Search";
			this.btn_search.UseVisualStyleBackColor = true;
			this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
			// 
			// txt_searchText
			// 
			this.txt_searchText.Location = new System.Drawing.Point(32, 24);
			this.txt_searchText.Margin = new System.Windows.Forms.Padding(2);
			this.txt_searchText.Name = "txt_searchText";
			this.txt_searchText.Size = new System.Drawing.Size(224, 26);
			this.txt_searchText.TabIndex = 40;
			// 
			// grp_choices
			// 
			this.grp_choices.Controls.Add(this.cho4radio);
			this.grp_choices.Controls.Add(this.cho3radio);
			this.grp_choices.Controls.Add(this.cho2radio);
			this.grp_choices.Controls.Add(this.cho1radio);
			this.grp_choices.Controls.Add(this.button1);
			this.grp_choices.Controls.Add(this.txt_lastQuesContent);
			this.grp_choices.Controls.Add(this.label32);
			this.grp_choices.Controls.Add(this.lbl_lastQuesID);
			this.grp_choices.Controls.Add(this.label31);
			this.grp_choices.Controls.Add(this.txt_choice3Content);
			this.grp_choices.Controls.Add(this.txt_choice4Content);
			this.grp_choices.Controls.Add(this.txt_choice2Content);
			this.grp_choices.Controls.Add(this.txt_choice1Content);
			this.grp_choices.Controls.Add(this.label27);
			this.grp_choices.Controls.Add(this.label22);
			this.grp_choices.Controls.Add(this.label20);
			this.grp_choices.Controls.Add(this.label19);
			this.grp_choices.Enabled = false;
			this.grp_choices.Location = new System.Drawing.Point(405, 288);
			this.grp_choices.Margin = new System.Windows.Forms.Padding(2);
			this.grp_choices.Name = "grp_choices";
			this.grp_choices.Padding = new System.Windows.Forms.Padding(2);
			this.grp_choices.Size = new System.Drawing.Size(398, 288);
			this.grp_choices.TabIndex = 41;
			this.grp_choices.TabStop = false;
			this.grp_choices.Text = "MCQ choices";
			// 
			// cho4radio
			// 
			this.cho4radio.AutoSize = true;
			this.cho4radio.ForeColor = System.Drawing.Color.Red;
			this.cho4radio.Location = new System.Drawing.Point(306, 224);
			this.cho4radio.Margin = new System.Windows.Forms.Padding(2);
			this.cho4radio.Name = "cho4radio";
			this.cho4radio.Size = new System.Drawing.Size(87, 24);
			this.cho4radio.TabIndex = 11;
			this.cho4radio.Text = "Is model";
			this.cho4radio.UseVisualStyleBackColor = true;
			// 
			// cho3radio
			// 
			this.cho3radio.AutoSize = true;
			this.cho3radio.ForeColor = System.Drawing.Color.Red;
			this.cho3radio.Location = new System.Drawing.Point(306, 180);
			this.cho3radio.Margin = new System.Windows.Forms.Padding(2);
			this.cho3radio.Name = "cho3radio";
			this.cho3radio.Size = new System.Drawing.Size(87, 24);
			this.cho3radio.TabIndex = 10;
			this.cho3radio.Text = "Is model";
			this.cho3radio.UseVisualStyleBackColor = true;
			// 
			// cho2radio
			// 
			this.cho2radio.AutoSize = true;
			this.cho2radio.ForeColor = System.Drawing.Color.Red;
			this.cho2radio.Location = new System.Drawing.Point(306, 136);
			this.cho2radio.Margin = new System.Windows.Forms.Padding(2);
			this.cho2radio.Name = "cho2radio";
			this.cho2radio.Size = new System.Drawing.Size(87, 24);
			this.cho2radio.TabIndex = 9;
			this.cho2radio.Text = "Is model";
			this.cho2radio.UseVisualStyleBackColor = true;
			// 
			// cho1radio
			// 
			this.cho1radio.AutoSize = true;
			this.cho1radio.Checked = true;
			this.cho1radio.ForeColor = System.Drawing.Color.Red;
			this.cho1radio.Location = new System.Drawing.Point(306, 93);
			this.cho1radio.Margin = new System.Windows.Forms.Padding(2);
			this.cho1radio.Name = "cho1radio";
			this.cho1radio.Size = new System.Drawing.Size(87, 24);
			this.cho1radio.TabIndex = 8;
			this.cho1radio.TabStop = true;
			this.cho1radio.Text = "Is model";
			this.cho1radio.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(306, 255);
			this.button1.Margin = new System.Windows.Forms.Padding(2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(56, 31);
			this.button1.TabIndex = 7;
			this.button1.Text = "Add";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// txt_lastQuesContent
			// 
			this.txt_lastQuesContent.Location = new System.Drawing.Point(21, 66);
			this.txt_lastQuesContent.Margin = new System.Windows.Forms.Padding(2);
			this.txt_lastQuesContent.Name = "txt_lastQuesContent";
			this.txt_lastQuesContent.ReadOnly = true;
			this.txt_lastQuesContent.Size = new System.Drawing.Size(373, 26);
			this.txt_lastQuesContent.TabIndex = 6;
			// 
			// label32
			// 
			this.label32.AutoSize = true;
			this.label32.Location = new System.Drawing.Point(16, 46);
			this.label32.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(138, 20);
			this.label32.TabIndex = 4;
			this.label32.Text = "Question Content:";
			// 
			// lbl_lastQuesID
			// 
			this.lbl_lastQuesID.AutoSize = true;
			this.lbl_lastQuesID.ForeColor = System.Drawing.Color.Red;
			this.lbl_lastQuesID.Location = new System.Drawing.Point(106, 21);
			this.lbl_lastQuesID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbl_lastQuesID.Name = "lbl_lastQuesID";
			this.lbl_lastQuesID.Size = new System.Drawing.Size(94, 20);
			this.lbl_lastQuesID.TabIndex = 5;
			this.lbl_lastQuesID.Text = "Question ID";
			// 
			// label31
			// 
			this.label31.AutoSize = true;
			this.label31.Location = new System.Drawing.Point(16, 21);
			this.label31.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(98, 20);
			this.label31.TabIndex = 4;
			this.label31.Text = "Question ID:";
			// 
			// txt_choice3Content
			// 
			this.txt_choice3Content.Location = new System.Drawing.Point(130, 180);
			this.txt_choice3Content.Margin = new System.Windows.Forms.Padding(2);
			this.txt_choice3Content.Name = "txt_choice3Content";
			this.txt_choice3Content.Size = new System.Drawing.Size(161, 26);
			this.txt_choice3Content.TabIndex = 0;
			// 
			// txt_choice4Content
			// 
			this.txt_choice4Content.Location = new System.Drawing.Point(130, 223);
			this.txt_choice4Content.Margin = new System.Windows.Forms.Padding(2);
			this.txt_choice4Content.Name = "txt_choice4Content";
			this.txt_choice4Content.Size = new System.Drawing.Size(161, 26);
			this.txt_choice4Content.TabIndex = 0;
			// 
			// txt_choice2Content
			// 
			this.txt_choice2Content.Location = new System.Drawing.Point(130, 136);
			this.txt_choice2Content.Margin = new System.Windows.Forms.Padding(2);
			this.txt_choice2Content.Name = "txt_choice2Content";
			this.txt_choice2Content.Size = new System.Drawing.Size(161, 26);
			this.txt_choice2Content.TabIndex = 0;
			// 
			// txt_choice1Content
			// 
			this.txt_choice1Content.Location = new System.Drawing.Point(130, 92);
			this.txt_choice1Content.Margin = new System.Windows.Forms.Padding(2);
			this.txt_choice1Content.Name = "txt_choice1Content";
			this.txt_choice1Content.Size = new System.Drawing.Size(161, 26);
			this.txt_choice1Content.TabIndex = 0;
			// 
			// label27
			// 
			this.label27.AutoSize = true;
			this.label27.Location = new System.Drawing.Point(16, 182);
			this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(116, 20);
			this.label27.TabIndex = 1;
			this.label27.Text = "Choice content";
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Location = new System.Drawing.Point(16, 226);
			this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(116, 20);
			this.label22.TabIndex = 1;
			this.label22.Text = "Choice content";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(16, 138);
			this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(116, 20);
			this.label20.TabIndex = 1;
			this.label20.Text = "Choice content";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(16, 94);
			this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(116, 20);
			this.label19.TabIndex = 1;
			this.label19.Text = "Choice content";
			// 
			// btn_choiceAdd
			// 
			this.btn_choiceAdd.Location = new System.Drawing.Point(419, 457);
			this.btn_choiceAdd.Margin = new System.Windows.Forms.Padding(2);
			this.btn_choiceAdd.Name = "btn_choiceAdd";
			this.btn_choiceAdd.Size = new System.Drawing.Size(56, 26);
			this.btn_choiceAdd.TabIndex = 2;
			this.btn_choiceAdd.Text = "Add";
			this.btn_choiceAdd.UseVisualStyleBackColor = true;
			// 
			// cmbo_quesType
			// 
			this.cmbo_quesType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbo_quesType.FormattingEnabled = true;
			this.cmbo_quesType.Items.AddRange(new object[] {
            "MCQ",
            "TFQ"});
			this.cmbo_quesType.Location = new System.Drawing.Point(139, 269);
			this.cmbo_quesType.Margin = new System.Windows.Forms.Padding(2);
			this.cmbo_quesType.Name = "cmbo_quesType";
			this.cmbo_quesType.Size = new System.Drawing.Size(169, 28);
			this.cmbo_quesType.TabIndex = 39;
			this.cmbo_quesType.SelectedValueChanged += new System.EventHandler(this.cmbo_quesType_SelectedValueChanged);
			// 
			// cmbo_QuesCourse
			// 
			this.cmbo_QuesCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbo_QuesCourse.FormattingEnabled = true;
			this.cmbo_QuesCourse.Location = new System.Drawing.Point(139, 228);
			this.cmbo_QuesCourse.Margin = new System.Windows.Forms.Padding(2);
			this.cmbo_QuesCourse.Name = "cmbo_QuesCourse";
			this.cmbo_QuesCourse.Size = new System.Drawing.Size(169, 28);
			this.cmbo_QuesCourse.TabIndex = 39;
			this.cmbo_QuesCourse.DropDown += new System.EventHandler(this.cmbo_QuesCourse_DropDown);
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Location = new System.Drawing.Point(4, 266);
			this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(43, 20);
			this.label21.TabIndex = 35;
			this.label21.Text = "Type";
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.Location = new System.Drawing.Point(4, 305);
			this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(66, 20);
			this.label23.TabIndex = 29;
			this.label23.Text = "Content";
			// 
			// txt_quesContent
			// 
			this.txt_quesContent.Location = new System.Drawing.Point(139, 307);
			this.txt_quesContent.Margin = new System.Windows.Forms.Padding(2);
			this.txt_quesContent.Name = "txt_quesContent";
			this.txt_quesContent.Size = new System.Drawing.Size(224, 26);
			this.txt_quesContent.TabIndex = 32;
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Location = new System.Drawing.Point(4, 228);
			this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(60, 20);
			this.label24.TabIndex = 30;
			this.label24.Text = "Course";
			// 
			// txt_quesId
			// 
			this.txt_quesId.Location = new System.Drawing.Point(139, 193);
			this.txt_quesId.Margin = new System.Windows.Forms.Padding(2);
			this.txt_quesId.Name = "txt_quesId";
			this.txt_quesId.ReadOnly = true;
			this.txt_quesId.Size = new System.Drawing.Size(169, 26);
			this.txt_quesId.TabIndex = 34;
			// 
			// label25
			// 
			this.label25.AutoSize = true;
			this.label25.Location = new System.Drawing.Point(4, 193);
			this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(26, 20);
			this.label25.TabIndex = 31;
			this.label25.Text = "ID";
			// 
			// btn_quesInsert
			// 
			this.btn_quesInsert.Location = new System.Drawing.Point(608, 182);
			this.btn_quesInsert.Margin = new System.Windows.Forms.Padding(2);
			this.btn_quesInsert.Name = "btn_quesInsert";
			this.btn_quesInsert.Size = new System.Drawing.Size(182, 46);
			this.btn_quesInsert.TabIndex = 23;
			this.btn_quesInsert.Text = "Insert";
			this.btn_quesInsert.UseVisualStyleBackColor = true;
			this.btn_quesInsert.Click += new System.EventHandler(this.btn_quesInsert_Click);
			// 
			// btn_quesDelete
			// 
			this.btn_quesDelete.Location = new System.Drawing.Point(513, 240);
			this.btn_quesDelete.Margin = new System.Windows.Forms.Padding(2);
			this.btn_quesDelete.Name = "btn_quesDelete";
			this.btn_quesDelete.Size = new System.Drawing.Size(182, 46);
			this.btn_quesDelete.TabIndex = 24;
			this.btn_quesDelete.Text = "Delete";
			this.btn_quesDelete.UseVisualStyleBackColor = true;
			this.btn_quesDelete.Click += new System.EventHandler(this.btn_quesDelete_Click);
			// 
			// btn_quesDisplay
			// 
			this.btn_quesDisplay.Location = new System.Drawing.Point(405, 182);
			this.btn_quesDisplay.Margin = new System.Windows.Forms.Padding(2);
			this.btn_quesDisplay.Name = "btn_quesDisplay";
			this.btn_quesDisplay.Size = new System.Drawing.Size(182, 46);
			this.btn_quesDisplay.TabIndex = 26;
			this.btn_quesDisplay.Text = "Display";
			this.btn_quesDisplay.UseVisualStyleBackColor = true;
			this.btn_quesDisplay.Click += new System.EventHandler(this.btn_quesDisplay_Click);
			// 
			// lst_questions
			// 
			this.lst_questions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader17,
            this.columnHeader18});
			this.lst_questions.Dock = System.Windows.Forms.DockStyle.Top;
			this.lst_questions.FullRowSelect = true;
			this.lst_questions.HideSelection = false;
			this.lst_questions.Location = new System.Drawing.Point(2, 2);
			this.lst_questions.Margin = new System.Windows.Forms.Padding(2);
			this.lst_questions.Name = "lst_questions";
			this.lst_questions.Size = new System.Drawing.Size(821, 166);
			this.lst_questions.TabIndex = 0;
			this.lst_questions.UseCompatibleStateImageBehavior = false;
			this.lst_questions.View = System.Windows.Forms.View.Details;
			this.lst_questions.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lst_questions_MouseClick);
			// 
			// columnHeader13
			// 
			this.columnHeader13.Text = "ID";
			// 
			// columnHeader14
			// 
			this.columnHeader14.Text = "Course";
			this.columnHeader14.Width = 90;
			// 
			// columnHeader15
			// 
			this.columnHeader15.Text = "Content";
			this.columnHeader15.Width = 370;
			// 
			// columnHeader17
			// 
			this.columnHeader17.Text = "Type";
			this.columnHeader17.Width = 90;
			// 
			// columnHeader18
			// 
			this.columnHeader18.Text = "Model Answer";
			this.columnHeader18.Width = 120;
			// 
			// tabPage_users
			// 
			this.tabPage_users.Controls.Add(this.radioButton2);
			this.tabPage_users.Controls.Add(this.radioButton1);
			this.tabPage_users.Controls.Add(this.UserSexFld);
			this.tabPage_users.Controls.Add(this.UserPassFld);
			this.tabPage_users.Controls.Add(this.label29);
			this.tabPage_users.Controls.Add(this.label33);
			this.tabPage_users.Controls.Add(this.label34);
			this.tabPage_users.Controls.Add(this.UserMailFld);
			this.tabPage_users.Controls.Add(this.UserUserNameFld);
			this.tabPage_users.Controls.Add(this.label35);
			this.tabPage_users.Controls.Add(this.UserIdFld);
			this.tabPage_users.Controls.Add(this.label36);
			this.tabPage_users.Controls.Add(this.InsertUserBtn);
			this.tabPage_users.Controls.Add(this.DeleteUser);
			this.tabPage_users.Controls.Add(this.DisplayUserByUserName);
			this.tabPage_users.Controls.Add(this.button4);
			this.tabPage_users.Controls.Add(this.UpdateUser);
			this.tabPage_users.Controls.Add(this.UsersList);
			this.tabPage_users.Location = new System.Drawing.Point(4, 29);
			this.tabPage_users.Margin = new System.Windows.Forms.Padding(2);
			this.tabPage_users.Name = "tabPage_users";
			this.tabPage_users.Padding = new System.Windows.Forms.Padding(2);
			this.tabPage_users.Size = new System.Drawing.Size(825, 576);
			this.tabPage_users.TabIndex = 4;
			this.tabPage_users.Text = "Users";
			this.tabPage_users.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(197, 483);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(95, 24);
			this.radioButton2.TabIndex = 61;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Instructor";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Location = new System.Drawing.Point(67, 483);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(84, 24);
			this.radioButton1.TabIndex = 60;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Student";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// UserSexFld
			// 
			this.UserSexFld.Location = new System.Drawing.Point(166, 446);
			this.UserSexFld.Margin = new System.Windows.Forms.Padding(2);
			this.UserSexFld.Name = "UserSexFld";
			this.UserSexFld.Size = new System.Drawing.Size(169, 26);
			this.UserSexFld.TabIndex = 59;
			// 
			// UserPassFld
			// 
			this.UserPassFld.Location = new System.Drawing.Point(166, 416);
			this.UserPassFld.Margin = new System.Windows.Forms.Padding(2);
			this.UserPassFld.Name = "UserPassFld";
			this.UserPassFld.Size = new System.Drawing.Size(169, 26);
			this.UserPassFld.TabIndex = 58;
			// 
			// label29
			// 
			this.label29.AutoSize = true;
			this.label29.Location = new System.Drawing.Point(32, 445);
			this.label29.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(36, 20);
			this.label29.TabIndex = 57;
			this.label29.Text = "Sex";
			// 
			// label33
			// 
			this.label33.AutoSize = true;
			this.label33.Location = new System.Drawing.Point(32, 413);
			this.label33.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(78, 20);
			this.label33.TabIndex = 50;
			this.label33.Text = "Password";
			// 
			// label34
			// 
			this.label34.AutoSize = true;
			this.label34.Location = new System.Drawing.Point(32, 384);
			this.label34.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(53, 20);
			this.label34.TabIndex = 51;
			this.label34.Text = "E-mail";
			// 
			// UserMailFld
			// 
			this.UserMailFld.Location = new System.Drawing.Point(166, 386);
			this.UserMailFld.Margin = new System.Windows.Forms.Padding(2);
			this.UserMailFld.Name = "UserMailFld";
			this.UserMailFld.Size = new System.Drawing.Size(169, 26);
			this.UserMailFld.TabIndex = 54;
			// 
			// UserUserNameFld
			// 
			this.UserUserNameFld.Location = new System.Drawing.Point(166, 355);
			this.UserUserNameFld.Margin = new System.Windows.Forms.Padding(2);
			this.UserUserNameFld.Name = "UserUserNameFld";
			this.UserUserNameFld.Size = new System.Drawing.Size(169, 26);
			this.UserUserNameFld.TabIndex = 55;
			// 
			// label35
			// 
			this.label35.AutoSize = true;
			this.label35.Location = new System.Drawing.Point(32, 355);
			this.label35.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(89, 20);
			this.label35.TabIndex = 52;
			this.label35.Text = "User Name";
			// 
			// UserIdFld
			// 
			this.UserIdFld.Location = new System.Drawing.Point(166, 326);
			this.UserIdFld.Margin = new System.Windows.Forms.Padding(2);
			this.UserIdFld.Name = "UserIdFld";
			this.UserIdFld.ReadOnly = true;
			this.UserIdFld.Size = new System.Drawing.Size(169, 26);
			this.UserIdFld.TabIndex = 56;
			// 
			// label36
			// 
			this.label36.AutoSize = true;
			this.label36.Location = new System.Drawing.Point(32, 326);
			this.label36.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label36.Name = "label36";
			this.label36.Size = new System.Drawing.Size(26, 20);
			this.label36.TabIndex = 53;
			this.label36.Text = "ID";
			// 
			// InsertUserBtn
			// 
			this.InsertUserBtn.Location = new System.Drawing.Point(377, 400);
			this.InsertUserBtn.Margin = new System.Windows.Forms.Padding(2);
			this.InsertUserBtn.Name = "InsertUserBtn";
			this.InsertUserBtn.Size = new System.Drawing.Size(182, 46);
			this.InsertUserBtn.TabIndex = 45;
			this.InsertUserBtn.Text = "Insert";
			this.InsertUserBtn.UseVisualStyleBackColor = true;
			this.InsertUserBtn.Click += new System.EventHandler(this.InsertUserBtn_Click);
			// 
			// DeleteUser
			// 
			this.DeleteUser.Location = new System.Drawing.Point(592, 400);
			this.DeleteUser.Margin = new System.Windows.Forms.Padding(2);
			this.DeleteUser.Name = "DeleteUser";
			this.DeleteUser.Size = new System.Drawing.Size(182, 46);
			this.DeleteUser.TabIndex = 46;
			this.DeleteUser.Text = "Delete";
			this.DeleteUser.UseVisualStyleBackColor = true;
			this.DeleteUser.Click += new System.EventHandler(this.DeleteUser_Click);
			// 
			// DisplayUserByUserName
			// 
			this.DisplayUserByUserName.Location = new System.Drawing.Point(462, 450);
			this.DisplayUserByUserName.Margin = new System.Windows.Forms.Padding(2);
			this.DisplayUserByUserName.Name = "DisplayUserByUserName";
			this.DisplayUserByUserName.Size = new System.Drawing.Size(229, 46);
			this.DisplayUserByUserName.TabIndex = 47;
			this.DisplayUserByUserName.Text = "Display by User name";
			this.DisplayUserByUserName.UseVisualStyleBackColor = true;
			this.DisplayUserByUserName.Click += new System.EventHandler(this.DisplayUserByUserName_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(377, 348);
			this.button4.Margin = new System.Windows.Forms.Padding(2);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(182, 46);
			this.button4.TabIndex = 48;
			this.button4.Text = "Display";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4_Click);
			// 
			// UpdateUser
			// 
			this.UpdateUser.Location = new System.Drawing.Point(592, 350);
			this.UpdateUser.Margin = new System.Windows.Forms.Padding(2);
			this.UpdateUser.Name = "UpdateUser";
			this.UpdateUser.Size = new System.Drawing.Size(182, 46);
			this.UpdateUser.TabIndex = 49;
			this.UpdateUser.Text = "Update";
			this.UpdateUser.UseVisualStyleBackColor = true;
			this.UpdateUser.Click += new System.EventHandler(this.UpdateUser_Click);
			// 
			// UsersList
			// 
			this.UsersList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader16,
            this.columnHeader19,
            this.columnHeader20,
            this.columnHeader21,
            this.columnHeader22});
			this.UsersList.Dock = System.Windows.Forms.DockStyle.Top;
			this.UsersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UsersList.FullRowSelect = true;
			this.UsersList.HideSelection = false;
			this.UsersList.Location = new System.Drawing.Point(2, 2);
			this.UsersList.Margin = new System.Windows.Forms.Padding(2);
			this.UsersList.Name = "UsersList";
			this.UsersList.Size = new System.Drawing.Size(821, 304);
			this.UsersList.TabIndex = 44;
			this.UsersList.UseCompatibleStateImageBehavior = false;
			this.UsersList.View = System.Windows.Forms.View.Details;
			this.UsersList.Click += new System.EventHandler(this.UsersList_Click);
			// 
			// columnHeader16
			// 
			this.columnHeader16.Text = "Id";
			this.columnHeader16.Width = 100;
			// 
			// columnHeader19
			// 
			this.columnHeader19.Text = "User Name";
			this.columnHeader19.Width = 172;
			// 
			// columnHeader20
			// 
			this.columnHeader20.Text = "E-mail";
			this.columnHeader20.Width = 253;
			// 
			// columnHeader21
			// 
			this.columnHeader21.Text = "Password";
			this.columnHeader21.Width = 116;
			// 
			// columnHeader22
			// 
			this.columnHeader22.Text = "Sex";
			this.columnHeader22.Width = 100;
			// 
			// tabPage_instructors
			// 
			this.tabPage_instructors.Controls.Add(this.InsDegFld);
			this.tabPage_instructors.Controls.Add(this.InsLnameFld);
			this.tabPage_instructors.Controls.Add(this.label37);
			this.tabPage_instructors.Controls.Add(this.InsSalaryFld);
			this.tabPage_instructors.Controls.Add(this.label38);
			this.tabPage_instructors.Controls.Add(this.InsFnameFld);
			this.tabPage_instructors.Controls.Add(this.label39);
			this.tabPage_instructors.Controls.Add(this.label40);
			this.tabPage_instructors.Controls.Add(this.labe55);
			this.tabPage_instructors.Controls.Add(this.InsDeptFld);
			this.tabPage_instructors.Controls.Add(this.InsUserNameFld);
			this.tabPage_instructors.Controls.Add(this.label41);
			this.tabPage_instructors.Controls.Add(this.InsIdFld);
			this.tabPage_instructors.Controls.Add(this.label42);
			this.tabPage_instructors.Controls.Add(this.InsertIns);
			this.tabPage_instructors.Controls.Add(this.DeleteIns);
			this.tabPage_instructors.Controls.Add(this.DisplayInsByName);
			this.tabPage_instructors.Controls.Add(this.DisplayIns);
			this.tabPage_instructors.Controls.Add(this.UpdateIns);
			this.tabPage_instructors.Controls.Add(this.InsList);
			this.tabPage_instructors.Location = new System.Drawing.Point(4, 29);
			this.tabPage_instructors.Margin = new System.Windows.Forms.Padding(2);
			this.tabPage_instructors.Name = "tabPage_instructors";
			this.tabPage_instructors.Padding = new System.Windows.Forms.Padding(2);
			this.tabPage_instructors.Size = new System.Drawing.Size(825, 576);
			this.tabPage_instructors.TabIndex = 6;
			this.tabPage_instructors.Text = "Instructors";
			this.tabPage_instructors.UseVisualStyleBackColor = true;
			// 
			// InsDegFld
			// 
			this.InsDegFld.Location = new System.Drawing.Point(148, 456);
			this.InsDegFld.Margin = new System.Windows.Forms.Padding(2);
			this.InsDegFld.Name = "InsDegFld";
			this.InsDegFld.Size = new System.Drawing.Size(169, 26);
			this.InsDegFld.TabIndex = 62;
			// 
			// InsLnameFld
			// 
			this.InsLnameFld.Location = new System.Drawing.Point(148, 428);
			this.InsLnameFld.Margin = new System.Windows.Forms.Padding(2);
			this.InsLnameFld.Name = "InsLnameFld";
			this.InsLnameFld.Size = new System.Drawing.Size(169, 26);
			this.InsLnameFld.TabIndex = 61;
			// 
			// label37
			// 
			this.label37.AutoSize = true;
			this.label37.Location = new System.Drawing.Point(14, 479);
			this.label37.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label37.Name = "label37";
			this.label37.Size = new System.Drawing.Size(53, 20);
			this.label37.TabIndex = 59;
			this.label37.Text = "Salary";
			// 
			// InsSalaryFld
			// 
			this.InsSalaryFld.Location = new System.Drawing.Point(148, 484);
			this.InsSalaryFld.Margin = new System.Windows.Forms.Padding(2);
			this.InsSalaryFld.Name = "InsSalaryFld";
			this.InsSalaryFld.Size = new System.Drawing.Size(169, 26);
			this.InsSalaryFld.TabIndex = 60;
			// 
			// label38
			// 
			this.label38.AutoSize = true;
			this.label38.Location = new System.Drawing.Point(14, 453);
			this.label38.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label38.Name = "label38";
			this.label38.Size = new System.Drawing.Size(62, 20);
			this.label38.TabIndex = 57;
			this.label38.Text = "Degree";
			// 
			// InsFnameFld
			// 
			this.InsFnameFld.Location = new System.Drawing.Point(148, 398);
			this.InsFnameFld.Margin = new System.Windows.Forms.Padding(2);
			this.InsFnameFld.Name = "InsFnameFld";
			this.InsFnameFld.Size = new System.Drawing.Size(169, 26);
			this.InsFnameFld.TabIndex = 58;
			// 
			// label39
			// 
			this.label39.AutoSize = true;
			this.label39.Location = new System.Drawing.Point(14, 427);
			this.label39.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label39.Name = "label39";
			this.label39.Size = new System.Drawing.Size(86, 20);
			this.label39.TabIndex = 56;
			this.label39.Text = "Last Name";
			// 
			// label40
			// 
			this.label40.AutoSize = true;
			this.label40.Location = new System.Drawing.Point(14, 401);
			this.label40.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label40.Name = "label40";
			this.label40.Size = new System.Drawing.Size(86, 20);
			this.label40.TabIndex = 49;
			this.label40.Text = "First Name";
			// 
			// labe55
			// 
			this.labe55.AutoSize = true;
			this.labe55.Location = new System.Drawing.Point(14, 371);
			this.labe55.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labe55.Name = "labe55";
			this.labe55.Size = new System.Drawing.Size(94, 20);
			this.labe55.TabIndex = 50;
			this.labe55.Text = "Deaprtment";
			// 
			// InsDeptFld
			// 
			this.InsDeptFld.Location = new System.Drawing.Point(148, 368);
			this.InsDeptFld.Margin = new System.Windows.Forms.Padding(2);
			this.InsDeptFld.Name = "InsDeptFld";
			this.InsDeptFld.Size = new System.Drawing.Size(169, 26);
			this.InsDeptFld.TabIndex = 53;
			// 
			// InsUserNameFld
			// 
			this.InsUserNameFld.Location = new System.Drawing.Point(148, 337);
			this.InsUserNameFld.Margin = new System.Windows.Forms.Padding(2);
			this.InsUserNameFld.Name = "InsUserNameFld";
			this.InsUserNameFld.Size = new System.Drawing.Size(169, 26);
			this.InsUserNameFld.TabIndex = 54;
			// 
			// label41
			// 
			this.label41.AutoSize = true;
			this.label41.Location = new System.Drawing.Point(14, 343);
			this.label41.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label41.Name = "label41";
			this.label41.Size = new System.Drawing.Size(89, 20);
			this.label41.TabIndex = 51;
			this.label41.Text = "User Name";
			// 
			// InsIdFld
			// 
			this.InsIdFld.Location = new System.Drawing.Point(148, 308);
			this.InsIdFld.Margin = new System.Windows.Forms.Padding(2);
			this.InsIdFld.Name = "InsIdFld";
			this.InsIdFld.ReadOnly = true;
			this.InsIdFld.Size = new System.Drawing.Size(169, 26);
			this.InsIdFld.TabIndex = 55;
			// 
			// label42
			// 
			this.label42.AutoSize = true;
			this.label42.Location = new System.Drawing.Point(14, 314);
			this.label42.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label42.Name = "label42";
			this.label42.Size = new System.Drawing.Size(26, 20);
			this.label42.TabIndex = 52;
			this.label42.Text = "ID";
			// 
			// InsertIns
			// 
			this.InsertIns.Location = new System.Drawing.Point(415, 391);
			this.InsertIns.Margin = new System.Windows.Forms.Padding(2);
			this.InsertIns.Name = "InsertIns";
			this.InsertIns.Size = new System.Drawing.Size(182, 46);
			this.InsertIns.TabIndex = 44;
			this.InsertIns.Text = "Insert";
			this.InsertIns.UseVisualStyleBackColor = true;
			this.InsertIns.Click += new System.EventHandler(this.InsertIns_Click);
			// 
			// DeleteIns
			// 
			this.DeleteIns.Location = new System.Drawing.Point(630, 391);
			this.DeleteIns.Margin = new System.Windows.Forms.Padding(2);
			this.DeleteIns.Name = "DeleteIns";
			this.DeleteIns.Size = new System.Drawing.Size(182, 46);
			this.DeleteIns.TabIndex = 45;
			this.DeleteIns.Text = "Delete";
			this.DeleteIns.UseVisualStyleBackColor = true;
			this.DeleteIns.Click += new System.EventHandler(this.DeleteIns_Click);
			// 
			// DisplayInsByName
			// 
			this.DisplayInsByName.Location = new System.Drawing.Point(500, 449);
			this.DisplayInsByName.Margin = new System.Windows.Forms.Padding(2);
			this.DisplayInsByName.Name = "DisplayInsByName";
			this.DisplayInsByName.Size = new System.Drawing.Size(229, 46);
			this.DisplayInsByName.TabIndex = 46;
			this.DisplayInsByName.Text = "Display by Instructor Name";
			this.DisplayInsByName.UseVisualStyleBackColor = true;
			this.DisplayInsByName.Click += new System.EventHandler(this.DisplayInsByName_Click);
			// 
			// DisplayIns
			// 
			this.DisplayIns.Location = new System.Drawing.Point(415, 335);
			this.DisplayIns.Margin = new System.Windows.Forms.Padding(2);
			this.DisplayIns.Name = "DisplayIns";
			this.DisplayIns.Size = new System.Drawing.Size(182, 46);
			this.DisplayIns.TabIndex = 47;
			this.DisplayIns.Text = "Display";
			this.DisplayIns.UseVisualStyleBackColor = true;
			this.DisplayIns.Click += new System.EventHandler(this.DisplayIns_Click);
			// 
			// UpdateIns
			// 
			this.UpdateIns.Location = new System.Drawing.Point(630, 335);
			this.UpdateIns.Margin = new System.Windows.Forms.Padding(2);
			this.UpdateIns.Name = "UpdateIns";
			this.UpdateIns.Size = new System.Drawing.Size(182, 46);
			this.UpdateIns.TabIndex = 48;
			this.UpdateIns.Text = "Update";
			this.UpdateIns.UseVisualStyleBackColor = true;
			this.UpdateIns.Click += new System.EventHandler(this.UpdateIns_Click);
			// 
			// InsList
			// 
			this.InsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader23,
            this.columnHeader24,
            this.columnHeader25,
            this.columnHeader26,
            this.columnHeader27,
            this.columnHeader28,
            this.columnHeader29});
			this.InsList.Dock = System.Windows.Forms.DockStyle.Top;
			this.InsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.InsList.FullRowSelect = true;
			this.InsList.HideSelection = false;
			this.InsList.Location = new System.Drawing.Point(2, 2);
			this.InsList.Margin = new System.Windows.Forms.Padding(2);
			this.InsList.Name = "InsList";
			this.InsList.Size = new System.Drawing.Size(821, 290);
			this.InsList.TabIndex = 43;
			this.InsList.UseCompatibleStateImageBehavior = false;
			this.InsList.View = System.Windows.Forms.View.Details;
			this.InsList.Click += new System.EventHandler(this.InsList_Click);
			// 
			// columnHeader23
			// 
			this.columnHeader23.Text = "Id";
			this.columnHeader23.Width = 100;
			// 
			// columnHeader24
			// 
			this.columnHeader24.Text = "User Name";
			this.columnHeader24.Width = 100;
			// 
			// columnHeader25
			// 
			this.columnHeader25.Text = "Department";
			this.columnHeader25.Width = 143;
			// 
			// columnHeader26
			// 
			this.columnHeader26.Text = "First Name";
			this.columnHeader26.Width = 116;
			// 
			// columnHeader27
			// 
			this.columnHeader27.Text = "Last Name";
			this.columnHeader27.Width = 100;
			// 
			// columnHeader28
			// 
			this.columnHeader28.Text = "Degree";
			this.columnHeader28.Width = 100;
			// 
			// columnHeader29
			// 
			this.columnHeader29.Text = "Salary";
			this.columnHeader29.Width = 100;
			// 
			// tabPage_Reports
			// 
			this.tabPage_Reports.Location = new System.Drawing.Point(4, 29);
			this.tabPage_Reports.Margin = new System.Windows.Forms.Padding(2);
			this.tabPage_Reports.Name = "tabPage_Reports";
			this.tabPage_Reports.Padding = new System.Windows.Forms.Padding(2);
			this.tabPage_Reports.Size = new System.Drawing.Size(825, 576);
			this.tabPage_Reports.TabIndex = 5;
			this.tabPage_Reports.Text = "Reports";
			this.tabPage_Reports.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.lbl_welcome);
			this.panel1.Controls.Add(this.lbl_username);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(150, 609);
			this.panel1.TabIndex = 4;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Examination_system.Properties.Resources.image_processing20200415_30469_4yiukf;
			this.pictureBox1.Location = new System.Drawing.Point(-379, 47);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(851, 555);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// instructorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(988, 609);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.tabCtrl_DashBoard);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(1004, 657);
			this.MinimumSize = new System.Drawing.Size(1004, 591);
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
			this.tabPage_questions.ResumeLayout(false);
			this.tabPage_questions.PerformLayout();
			this.grp_TFQ.ResumeLayout(false);
			this.grp_TFQ.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.grp_choices.ResumeLayout(false);
			this.grp_choices.PerformLayout();
			this.tabPage_users.ResumeLayout(false);
			this.tabPage_users.PerformLayout();
			this.tabPage_instructors.ResumeLayout(false);
			this.tabPage_instructors.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.ListView lst_questions;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txt_quesContent;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txt_quesId;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btn_quesInsert;
        private System.Windows.Forms.Button btn_quesDelete;
        private System.Windows.Forms.Button btn_quesDisplay;
        private System.Windows.Forms.ComboBox cmbo_quesType;
        private System.Windows.Forms.ComboBox cmbo_QuesCourse;
        private System.Windows.Forms.TextBox txt_searchText;
        private System.Windows.Forms.GroupBox grp_choices;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_choice1Content;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btn_choiceAdd;
        private System.Windows.Forms.TextBox txt_choice3Content;
        private System.Windows.Forms.TextBox txt_choice2Content;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txt_choice4Content;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label lbl_lastQuesID;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox txt_lastQuesContent;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton cho4radio;
        private System.Windows.Forms.RadioButton cho3radio;
        private System.Windows.Forms.RadioButton cho2radio;
        private System.Windows.Forms.RadioButton cho1radio;
        private System.Windows.Forms.GroupBox grp_TFQ;
        private System.Windows.Forms.ComboBox cmbo_TfqModel;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button btn_TfqAdd;
        private System.Windows.Forms.TextBox txt_lastquesContentTFQ;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label lbl_lastquesIdTFQ;
        private System.Windows.Forms.Label label30;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.TextBox UserSexFld;
		private System.Windows.Forms.TextBox UserPassFld;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.Label label34;
		private System.Windows.Forms.TextBox UserMailFld;
		private System.Windows.Forms.TextBox UserUserNameFld;
		private System.Windows.Forms.Label label35;
		private System.Windows.Forms.TextBox UserIdFld;
		private System.Windows.Forms.Label label36;
		private System.Windows.Forms.Button InsertUserBtn;
		private System.Windows.Forms.Button DeleteUser;
		private System.Windows.Forms.Button DisplayUserByUserName;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button UpdateUser;
		private System.Windows.Forms.ListView UsersList;
		private System.Windows.Forms.ColumnHeader columnHeader16;
		private System.Windows.Forms.ColumnHeader columnHeader19;
		private System.Windows.Forms.ColumnHeader columnHeader20;
		private System.Windows.Forms.ColumnHeader columnHeader21;
		private System.Windows.Forms.ColumnHeader columnHeader22;
		private System.Windows.Forms.TextBox InsDegFld;
		private System.Windows.Forms.TextBox InsLnameFld;
		private System.Windows.Forms.Label label37;
		private System.Windows.Forms.TextBox InsSalaryFld;
		private System.Windows.Forms.Label label38;
		private System.Windows.Forms.TextBox InsFnameFld;
		private System.Windows.Forms.Label label39;
		private System.Windows.Forms.Label label40;
		private System.Windows.Forms.Label labe55;
		private System.Windows.Forms.TextBox InsDeptFld;
		private System.Windows.Forms.TextBox InsUserNameFld;
		private System.Windows.Forms.Label label41;
		private System.Windows.Forms.TextBox InsIdFld;
		private System.Windows.Forms.Label label42;
		private System.Windows.Forms.Button InsertIns;
		private System.Windows.Forms.Button DeleteIns;
		private System.Windows.Forms.Button DisplayInsByName;
		private System.Windows.Forms.Button DisplayIns;
		private System.Windows.Forms.Button UpdateIns;
		private System.Windows.Forms.ListView InsList;
		private System.Windows.Forms.ColumnHeader columnHeader23;
		private System.Windows.Forms.ColumnHeader columnHeader24;
		private System.Windows.Forms.ColumnHeader columnHeader25;
		private System.Windows.Forms.ColumnHeader columnHeader26;
		private System.Windows.Forms.ColumnHeader columnHeader27;
		private System.Windows.Forms.ColumnHeader columnHeader28;
		private System.Windows.Forms.ColumnHeader columnHeader29;
	}
}