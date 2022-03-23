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
	public partial class CourseEnrollDialog : Form
	{
		public ExamSystemEntities Ent { get; set; } = new ExamSystemEntities();
		public Student PrevForm { get; set; }

		public CourseEnrollDialog(Student prevForm)
		{
			InitializeComponent();
			this.PrevForm = prevForm;
			FillComboBoxWithCourses();
		}

		private void FillComboBoxWithCourses()
		{
			var stdCrss = Ent.Std_Crs
				.Where(x => x.Std_Id == PrevForm.StudentId)
				.Select(c => c.Course.Crs_Name)
				.Distinct()
				.ToList();
			var allCrss = Ent.Courses.Select(c => c.Crs_Name).ToList();
			var res = allCrss.Except(stdCrss).ToList();
			foreach (var item in res)
			{
				comboBox1.Items.Add(item);
			}
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			if (comboBox1.Text != String.Empty)
			{
				var crsId = Ent.Courses
					.Where(c => c.Crs_Name == comboBox1.Text)
					.Select(c => c.Crs_Id)
					.FirstOrDefault();
				try
				{
					Ent.sp_InsertStdForCrs(PrevForm.StudentId, crsId, null, null);
					MessageBox.Show("Enrollment Succeeded");
				}
				catch (Exception)
				{

				}
				this.Close();
			}
			else
			{
				MessageBox.Show("Please, Choose a Course");
			}
		}
	}
}
