using System;
using System.Windows.Forms;

namespace Examination_system.Forms
{
	public partial class ChooseExamForCrs : Form
	{
		Student PrevForm { get; set; }

		public ChooseExamForCrs(Student prevForm)
		{
			InitializeComponent();
			this.PrevForm = prevForm;
		}

		private void Start_Click(object sender, EventArgs e)
		{
			Exam examForm = new Exam(this);
			examForm.Show();
			this.Hide();
		}
	}
}
