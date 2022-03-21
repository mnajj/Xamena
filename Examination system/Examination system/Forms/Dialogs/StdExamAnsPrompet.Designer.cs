namespace Examination_system.Forms.Dialogs
{
	partial class StdExamAnsPrompet
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
			this.Select = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.ExamCombo = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.StdsCombo = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// Select
			// 
			this.Select.Location = new System.Drawing.Point(70, 130);
			this.Select.Name = "Select";
			this.Select.Size = new System.Drawing.Size(75, 23);
			this.Select.TabIndex = 14;
			this.Select.Text = "Select";
			this.Select.UseVisualStyleBackColor = true;
			this.Select.Click += new System.EventHandler(this.Select_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(56, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(102, 20);
			this.label1.TabIndex = 13;
			this.label1.Text = "Select Exam:";
			// 
			// ExamCombo
			// 
			this.ExamCombo.FormattingEnabled = true;
			this.ExamCombo.Location = new System.Drawing.Point(12, 43);
			this.ExamCombo.Name = "ExamCombo";
			this.ExamCombo.Size = new System.Drawing.Size(183, 21);
			this.ExamCombo.TabIndex = 12;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(26, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(163, 20);
			this.label2.TabIndex = 16;
			this.label2.Text = "Select Student name:";
			// 
			// StdsCombo
			// 
			this.StdsCombo.FormattingEnabled = true;
			this.StdsCombo.Location = new System.Drawing.Point(12, 99);
			this.StdsCombo.Name = "StdsCombo";
			this.StdsCombo.Size = new System.Drawing.Size(183, 21);
			this.StdsCombo.TabIndex = 15;
			// 
			// StdExamAnsPrompet
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(215, 161);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.StdsCombo);
			this.Controls.Add(this.Select);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ExamCombo);
			this.Name = "StdExamAnsPrompet";
			this.Text = "StdExamAnsPrompet";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Select;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox ExamCombo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox StdsCombo;
	}
}