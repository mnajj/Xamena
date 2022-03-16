using Examination_system.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Examination_system.Forms
{
	public partial class Student : Form
	{
		public LogIn PrevForm { get; set; }
		public string UserName { get; set; }
		public int StudentId { get; set; }
		public string ExamCourse { get; set; }
		public ExamSystemEntities Ent { get; set; } = new ExamSystemEntities();

		public Student(LogIn prevForm, string userName)
		{
			InitializeComponent();
			this.PrevForm = prevForm;
			this.UserName = userName;
			this.StudentId = Ent.Students
				.Where(s => s.User.U_UserName == UserName)
				.Select(s => s.Std_Id)
				.First();

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
