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
			this.GreetingLabel = new System.Windows.Forms.Label();
			this.ShowGrade = new System.Windows.Forms.Button();
			this.StartExam = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// GreetingLabel
			// 
			this.GreetingLabel.AutoSize = true;
			this.GreetingLabel.Location = new System.Drawing.Point(58, 115);
			this.GreetingLabel.Name = "GreetingLabel";
			this.GreetingLabel.Size = new System.Drawing.Size(35, 13);
			this.GreetingLabel.TabIndex = 5;
			this.GreetingLabel.Text = "label1";
			// 
			// ShowGrade
			// 
			this.ShowGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ShowGrade.Location = new System.Drawing.Point(592, 241);
			this.ShowGrade.Name = "ShowGrade";
			this.ShowGrade.Size = new System.Drawing.Size(151, 94);
			this.ShowGrade.TabIndex = 4;
			this.ShowGrade.Text = "Show My Grades";
			this.ShowGrade.UseVisualStyleBackColor = true;
			// 
			// StartExam
			// 
			this.StartExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.StartExam.Location = new System.Drawing.Point(592, 141);
			this.StartExam.Name = "StartExam";
			this.StartExam.Size = new System.Drawing.Size(151, 94);
			this.StartExam.TabIndex = 3;
			this.StartExam.Text = "Start Course Exam";
			this.StartExam.UseVisualStyleBackColor = true;
			this.StartExam.Click += new System.EventHandler(this.StartExam_Click);
			// 
			// Student
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.GreetingLabel);
			this.Controls.Add(this.ShowGrade);
			this.Controls.Add(this.StartExam);
			this.Name = "Student";
			this.Text = "Student";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label GreetingLabel;
		private System.Windows.Forms.Button ShowGrade;
		private System.Windows.Forms.Button StartExam;
	}
}