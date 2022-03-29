namespace Examination_system.Forms
{
	partial class Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student));
            this.GreetingLabel = new System.Windows.Forms.Label();
            this.ShowGrade = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.StartExam = new System.Windows.Forms.Button();
            this.Enrool = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.StudentGradePerCourse = new Stimulsoft.Report.StiReport();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GreetingLabel
            // 
            this.GreetingLabel.AutoSize = true;
            this.GreetingLabel.Font = new System.Drawing.Font("Segoe UI Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreetingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(57)))));
            this.GreetingLabel.Location = new System.Drawing.Point(3, 11);
            this.GreetingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GreetingLabel.Name = "GreetingLabel";
            this.GreetingLabel.Size = new System.Drawing.Size(322, 54);
            this.GreetingLabel.TabIndex = 5;
            this.GreetingLabel.Text = "Welcome Back,";
            // 
            // ShowGrade
            // 
            this.ShowGrade.BackColor = System.Drawing.Color.White;
            this.ShowGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowGrade.Location = new System.Drawing.Point(40, 22);
            this.ShowGrade.Margin = new System.Windows.Forms.Padding(4);
            this.ShowGrade.Name = "ShowGrade";
            this.ShowGrade.Size = new System.Drawing.Size(201, 70);
            this.ShowGrade.TabIndex = 4;
            this.ShowGrade.Text = "Show My Grades";
            this.ShowGrade.UseVisualStyleBackColor = false;
            this.ShowGrade.Click += new System.EventHandler(this.ShowGrade_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(224)))), ((int)(((byte)(241)))));
            this.panel2.Controls.Add(this.ShowGrade);
            this.panel2.Location = new System.Drawing.Point(411, 428);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(277, 111);
            this.panel2.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(143)))), ((int)(((byte)(155)))));
            this.panel1.Controls.Add(this.StartExam);
            this.panel1.Location = new System.Drawing.Point(717, 428);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 111);
            this.panel1.TabIndex = 6;
            // 
            // StartExam
            // 
            this.StartExam.BackColor = System.Drawing.Color.White;
            this.StartExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartExam.Location = new System.Drawing.Point(43, 22);
            this.StartExam.Margin = new System.Windows.Forms.Padding(4);
            this.StartExam.Name = "StartExam";
            this.StartExam.Size = new System.Drawing.Size(201, 70);
            this.StartExam.TabIndex = 3;
            this.StartExam.Text = "Start Course Exam";
            this.StartExam.UseVisualStyleBackColor = false;
            this.StartExam.Click += new System.EventHandler(this.StartExam_Click);
            // 
            // Enrool
            // 
            this.Enrool.BackColor = System.Drawing.Color.White;
            this.Enrool.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enrool.Location = new System.Drawing.Point(36, 22);
            this.Enrool.Margin = new System.Windows.Forms.Padding(4);
            this.Enrool.Name = "Enrool";
            this.Enrool.Size = new System.Drawing.Size(201, 70);
            this.Enrool.TabIndex = 4;
            this.Enrool.Text = "Enroll in a Course";
            this.Enrool.UseVisualStyleBackColor = false;
            this.Enrool.Click += new System.EventHandler(this.Enrool_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(227)))), ((int)(((byte)(156)))));
            this.panel3.Controls.Add(this.Enrool);
            this.panel3.Location = new System.Drawing.Point(104, 428);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(277, 111);
            this.panel3.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(111)))), ((int)(((byte)(221)))));
            this.label1.Location = new System.Drawing.Point(16, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 54);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::Examination_system.Properties.Resources.image_processing20210504_13513_xqr1s1;
            this.pictureBox1.Location = new System.Drawing.Point(27, -52);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1024, 522);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // StudentGradePerCourse
            // 
            this.StudentGradePerCourse.CookieContainer = null;
            this.StudentGradePerCourse.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.StudentGradePerCourse.HttpHeadersContainer = null;
            this.StudentGradePerCourse.Key = "c827faaa7fd44acf957e2c0586febb01";
            this.StudentGradePerCourse.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.StudentGradePerCourse.ReportAlias = "Report";
            this.StudentGradePerCourse.ReportGuid = "6cb5903ce34046d5a402c351df2e721b";
            this.StudentGradePerCourse.ReportName = "Report";
            this.StudentGradePerCourse.ReportSource = resources.GetString("StudentGradePerCourse.ReportSource");
            this.StudentGradePerCourse.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches;
            this.StudentGradePerCourse.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.StudentGradePerCourse.UseProgressInThread = false;
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GreetingLabel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Student";
            this.Text = "Student";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label GreetingLabel;
		private System.Windows.Forms.Button ShowGrade;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button StartExam;
		private System.Windows.Forms.Button Enrool;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label1;
        private Stimulsoft.Report.StiReport StudentGradePerCourse;
    }
}