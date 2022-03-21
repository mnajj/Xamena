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
	public partial class CourseTopicPrompet : Form
	{
		public ExamSystemEntities Ent { get; set; } = new ExamSystemEntities();
		public int CrsId { get; set; }

		public CourseTopicPrompet()
		{
			InitializeComponent();
			FillCoursesCombo();
		}

		private void FillCoursesCombo()
		{
			var crss = Ent.Courses
				.Select(c => c.Crs_Name)
				.ToList();
			foreach (var c in crss)
			{
				CoursesCombo.Items.Add(c);
			}
		}

		private void Select_Click(object sender, EventArgs e)
		{
			if (CoursesCombo.Text != String.Empty
				&& CoursesCombo.Items.Contains(CoursesCombo.Text))
			{
				var crsId = Ent.Courses
					.Where(c => c.Crs_Name == CoursesCombo.Text)
					.Select(c => c.Crs_Id)
					.FirstOrDefault();
				CrsId = crsId;
				DialogResult = DialogResult.OK;
				this.Close();
			}
			else
			{
				MessageBox.Show("Please, Select a Course!");
			}
		}
	}
}
