using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination_system.Forms
{
	public partial class ChooseCrsExamDialog : Form
	{
		public Student PrevForm { get; set; }

		public ChooseCrsExamDialog(Student prevForm)
		{
			InitializeComponent();
			this.PrevForm = prevForm;
		}

		private void Start_Click(object sender, EventArgs e)
		{
			PrevForm.ExamCourse = comboBox1.Text;
			this.Close();
		}
	}
}
