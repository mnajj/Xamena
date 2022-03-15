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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_adduser = new System.Windows.Forms.Button();
            this.btn_generateexam = new System.Windows.Forms.Button();
            this.btn_report = new System.Windows.Forms.Button();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_adduser);
            this.groupBox1.Controls.Add(this.btn_generateexam);
            this.groupBox1.Controls.Add(this.btn_report);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(295, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // btn_adduser
            // 
            this.btn_adduser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adduser.Location = new System.Drawing.Point(109, 295);
            this.btn_adduser.Name = "btn_adduser";
            this.btn_adduser.Size = new System.Drawing.Size(172, 133);
            this.btn_adduser.TabIndex = 2;
            this.btn_adduser.Text = "Add user";
            this.btn_adduser.UseVisualStyleBackColor = true;
            // 
            // btn_generateexam
            // 
            this.btn_generateexam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generateexam.Location = new System.Drawing.Point(109, 162);
            this.btn_generateexam.Name = "btn_generateexam";
            this.btn_generateexam.Size = new System.Drawing.Size(172, 133);
            this.btn_generateexam.TabIndex = 1;
            this.btn_generateexam.Text = "Generate exam";
            this.btn_generateexam.UseVisualStyleBackColor = true;
            this.btn_generateexam.Click += new System.EventHandler(this.btn_generateexam_Click);
            // 
            // btn_report
            // 
            this.btn_report.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_report.Location = new System.Drawing.Point(109, 29);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(172, 133);
            this.btn_report.TabIndex = 0;
            this.btn_report.Text = "Reports";
            this.btn_report.UseVisualStyleBackColor = true;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.Location = new System.Drawing.Point(37, 64);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(132, 32);
            this.lbl_welcome.TabIndex = 1;
            this.lbl_welcome.Text = "Welcome";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Noto Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(57, 115);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(104, 38);
            this.lbl_username.TabIndex = 2;
            this.lbl_username.Text = "label1";
            // 
            // instructorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 450);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.lbl_welcome);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "instructorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "instructor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.instructorForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.Button btn_generateexam;
        private System.Windows.Forms.Button btn_adduser;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Label lbl_username;
    }
}