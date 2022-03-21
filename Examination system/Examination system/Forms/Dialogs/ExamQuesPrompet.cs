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
	public partial class ExamQuesPrompet : Form
	{
		public ExamSystemEntities Ent { get; set; } = new ExamSystemEntities();
		public int ExamId { get; set; }

		public ExamQuesPrompet()
		{
			InitializeComponent();
			FillExamCombo();
		}

		private void FillExamCombo()
		{
			var exams = Ent.Exams
				.Select(e => e.Exm_Id)
				.ToList();
			foreach (var exam in exams)
			{
				ExamCombo.Items.Add(exam);
			}
		}

		private void Select_Click(object sender, EventArgs e)
		{
			if (
				ExamCombo.Text != String.Empty
				&& ExamCombo.Items.Contains(ExamCombo.Text)
				)
			{
				ExamId = int.Parse(ExamCombo.Text);
				DialogResult = DialogResult.OK;
				this.Close();
			}
			else
			{
				MessageBox.Show("Please, Choose Exam Number!");
			}
		}
	}
}
