using System;
using System.Windows.Forms;

namespace Examination_system.Forms
{
	public partial class Student : Form
	{
		public LogIn PrevForm { get; set; }
		public string UserName { get; set; }
		public string ExamCourse { get; set; }

		public Student(LogIn prevForm, string userName)
		{
			InitializeComponent();
			this.PrevForm = prevForm;
			this.UserName = userName;
			GreetingUser();
		}

		private void GreetingUser()
		{
			GreetingLabel.Text = $"Welcome, {UserName}";
		}

		private void StartExam_Click(object sender, EventArgs e)
		{
			ChooseCrsExamDialog chooseCrsExamDialog = new ChooseCrsExamDialog(this);
			chooseCrsExamDialog.ShowDialog();
		}
	}
}
