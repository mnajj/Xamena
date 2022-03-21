using Examination_system.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination_system.Forms.Dialogs
{
	public partial class StudentCourseGradePrompet : Form
	{
		public ExamSystemEntities Ent { get; set; } = new ExamSystemEntities();
		public int StdId { get; set; }

		public StudentCourseGradePrompet()
		{
			InitializeComponent();
			FillStdsCombo();
		}

		private void FillStdsCombo()
		{
			var stds = Ent.Students
				.Select(s => s.Std_Fname + " " + s.Std_Lname)
				.ToList();
			foreach (var std in stds)
			{
				StdsCombo.Items.Add(std);
			}
		}

		private void Select_Click(object sender, EventArgs e)
		{
			if (StdsCombo.Text != String.Empty
				&& StdsCombo.Items.Contains(StdsCombo.Text))
			{
				string[] split = StdsCombo.Text.Split(' ');	
				string fn = split[0];
				string ln = split[1];
				var stdId = Ent.Students
					.Where(s => s.Std_Fname == fn
					&& s.Std_Lname == ln)
					.Select(s => s.Std_Id)
					.FirstOrDefault();
				StdId = stdId;
				DialogResult = DialogResult.OK;
				this.Close();
			}
			else
			{
				MessageBox.Show("Please, Select a Student Name!");
			}
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void StdsCombo_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
