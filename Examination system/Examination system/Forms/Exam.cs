using Examination_system.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Examination_system.Forms
{
	public partial class Exam : Form
	{
		public Student PrevForm { get; set; }
		public List<Question> Questions { get; set; }
		public Model.Exam RandExam { get; set; }
		public int Iterator { get; set; } = 0;
		public ExamSystemEntities Ent { get; set; } = new ExamSystemEntities();

		public Exam(Student prevForm)
		{
			InitializeComponent();
			this.PrevForm = prevForm;
			PickRandomExam();
			ShowExamFirstQuestion();
		}

		private void PickRandomExam()
		{
			try
			{
				RandExam = Ent.Exams
					.OrderBy(x => Guid.NewGuid())
					.Take(1)
					.FirstOrDefault();
			}
			catch (Exception e)
			{
				MessageBox.Show($"{e}");
			}
			if (RandExam != null)
			{
				GetExamQuestions();
				ShowExamFirstQuestion();
			}
		}

		private void GetExamQuestions()
		{
			Questions = Ent.Exm_Ques
				.Where(x => (x.Exam.Exm_Id == RandExam.Exm_Id)
				&& (x.Question.Crs_Id == PrevForm.CourseId))
				.Select(x => x.Question)
				.ToList();
		}

		private void ShowExamFirstQuestion()
		{
			label1.Text = Questions[Iterator].Ques_Content;
			if (Questions[Iterator].Ques_Type == "MCQ")
			{
				FillQuestion(Questions[Iterator].Ques_Id, true);
			}
			else
			{
				FillQuestion(Questions[Iterator].Ques_Id, false);
			}
		}

		private void FillQuestion(int id, bool isMCQ)
		{
			if (isMCQ)
			{
				var choices = Ent.Choices
					.Where(c => c.Ques_Id == id)
					.ToList();
				radioButton1.Text = choices[0].Cho_Content;
				radioButton2.Text = choices[1].Cho_Content;
				radioButton3.Text = choices[2].Cho_Content;
				radioButton4.Text = choices[3].Cho_Content;
			}
			else
			{
				radioButton1.Text = "True";
				radioButton2.Text = "False";
				radioButton3.Visible = false;
				radioButton4.Visible = false;
			}
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			if (Iterator < 9)
			{
				this.Iterator++;
				if (Iterator == 8)
				{
					button1.Text = "Finish";
				}
				label1.Text = Questions[Iterator].Ques_Content;
				if (Questions[Iterator].Ques_Type == "MCQ")
				{
					FillQuestion(Questions[Iterator].Ques_Id, true);
				}
				else
				{
					FillQuestion(Questions[Iterator].Ques_Id, false);
				}
				if (Iterator == 9)
				{
					this.PrevForm.Show();
					this.Close();
				}
			}
		}
	}
}
