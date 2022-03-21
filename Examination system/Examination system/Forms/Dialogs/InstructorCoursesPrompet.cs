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
	public partial class InstructorCoursesPrompet : Form
	{
		public ExamSystemEntities Ent { get; set; } = new ExamSystemEntities();
		public int InsId { get; set; }

		public InstructorCoursesPrompet()
		{
			InitializeComponent();
			FillInsCombo();
		}

		private void FillInsCombo()
		{
			var inss = Ent.Instructors
				.Select(i => i.Ins_Fname + " " + i.Ins_Lname)
				.ToList();
			foreach (var i in inss)
			{
				InsCombo.Items.Add(i);
			}
		}

		private void Select_Click(object sender, EventArgs e)
		{
			if (InsCombo.Text != String.Empty
				&& InsCombo.Items.Contains(InsCombo.Text))
			{
				string[] sp = InsCombo.Text.Split(' ');
				string fn = sp[0];
				string ln = sp[1];
				var insId = Ent.Instructors
					.Where(i => i.Ins_Fname == fn
					&& i.Ins_Lname == ln)
					.Select(i => i.Ins_Id)
					.FirstOrDefault();
				InsId = insId;
				DialogResult = DialogResult.OK;
				this.Close();
			}
			else
			{
				MessageBox.Show("Please, Choose an Instructor Name");
			}
		}
	}
}
