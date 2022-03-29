using Examination_system.Forms.Dialogs;
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
		public string CourseName { get; set; }
		public int CourseId { get; set; }
		public Model.Exam RandExam { get; set; }
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
			label1.Text = $"{UserName}";
		}

		private void StartExam_Click(object sender, EventArgs e)
		{
			ChooseCrsExamDialog chooseCrsExamDialog = new ChooseCrsExamDialog(this);
			chooseCrsExamDialog.ShowDialog();
			if (String.IsNullOrEmpty(CourseName) == false)
			{
				CourseId = Ent.Courses
					.Where(c => c.Crs_Name == CourseName)
					.Select(c => c.Crs_Id)
					.FirstOrDefault();
				PickRandomExam();
			}
		}

		private void PickRandomExam()
		{
			try
			{
				RandExam = Ent.Exams
					.Where(e => e.Course.Crs_Name == CourseName)
					.OrderBy(x => Guid.NewGuid())
					.Take(1)
					.FirstOrDefault();
			}
			catch (Exception e)
			{
				MessageBox.Show($"{e.Message}");
			}
			if (RandExam != null)
			{
				Exam examForm = new Exam(this);
				examForm.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("No Exams Avaliable for this Course");
			}
		}

		private void Enrool_Click(object sender, EventArgs e)
		{
			CourseEnrollDialog enrollDlg = new CourseEnrollDialog(this);
			enrollDlg.ShowDialog();
		}

        private void ShowGrade_Click(object sender, EventArgs e)
        {
			GenerateStudentGradesPerCourse();

		}

		private void GenerateStudentGradesPerCourse()
		{
				StudentGradePerCourse.Compile();
				StudentGradePerCourse["@std_id"] = StudentId.ToString();
				StudentGradePerCourse.Show();

		}

		private void Student_FormClosing(object sender, FormClosingEventArgs e)
		{
			PrevForm.Close();
		}
	}
}
