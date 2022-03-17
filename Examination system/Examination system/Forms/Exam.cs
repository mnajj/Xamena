using Examination_system.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Examination_system.Forms
{
	public partial class Exam : Form
	{
		public Student PrevForm { get; set; }
		public List<Question> Questions { get; set; }
		public int Iterator { get; set; }
		public Dictionary<int,char> Answers { get; set; } = new Dictionary<int,char>();
		public ExamSystemEntities Ent { get; set; } = new ExamSystemEntities();

		public Exam(Student prevForm)
		{
			InitializeComponent();
			this.PrevForm = prevForm;
			GetExamQuestions();
			ShowExamFirstQuestion();
		}

		private void GetExamQuestions()
		{
			Questions = Ent.Exm_Ques
				.Where(x => (x.Exam.Exm_Id == PrevForm.RandExam.Exm_Id)
				&& (x.Question.Crs_Id == PrevForm.CourseId))
				.Select(x => x.Question)
				.ToList();
		}

		private void ShowExamFirstQuestion()
		{
			Iterator = 0;
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

		private void AssignStudentAnswer()
		{
			char ans = '\0';
			if (radioButton1.Checked) ans = 'A';
			else if (radioButton2.Checked) ans = 'B';
			else if (radioButton3.Checked) ans = 'C';
			else if (radioButton4.Checked) ans = 'D';
			Answers.Add(Iterator + 1, ans);
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
				AssignStudentAnswer();
				UnCheckedRadioButtons();
				if (Iterator == 9)
				{
					SaveAnswersToDb();
					CorrectExam();
					this.PrevForm.Show();
					this.Close();
				}
			}
		}

		private void CorrectExam()
		{
			try
			{
				Ent.sp_CorrectStdExam(PrevForm.StudentId, PrevForm.RandExam.Exm_Id);
			}
			catch (Exception e)
			{
				MessageBox.Show($"{e.Message}");
			}
		}

		private void SaveAnswersToDb()
		{
			DataTable dt = ConvertDictToDataTable();
			using (SqlConnection conn = new SqlConnection("data source=.;initial catalog=ExamSystem;integrated security=True;"))
			{
				conn.Open();
				using (SqlCommand comm = new SqlCommand("sp_AssignAnsToStd", conn))
				{
					comm.CommandType = CommandType.StoredProcedure;
					var param1 = comm.Parameters.AddWithValue("std_id", PrevForm.StudentId);
					var param2 = comm.Parameters.AddWithValue("exm_id", PrevForm.RandExam.Exm_Id);
					var param3 = comm.Parameters.AddWithValue("ans_dict", dt);
					param1.SqlDbType = SqlDbType.Int;
					param2.SqlDbType = SqlDbType.Int;
					param3.SqlDbType = SqlDbType.Structured;
					var reader = comm.ExecuteReader();
				}
			}
			Ent.SaveChanges();
		}

		private DataTable ConvertDictToDataTable()
		{
			DataTable dt = new DataTable();
			dt.Columns.Add("Id", typeof(int));
			dt.Columns.Add("Ans", typeof(char));

			foreach (var item in Answers)
			{
				DataRow dr = dt.NewRow();
				dr["Id"] = item.Key;
				dr["Ans"] = item.Value;
				dt.Rows.Add(dr);
			}
			return dt;
		}

		public void UnCheckedRadioButtons()
		{
			radioButton1.Checked =
				radioButton2.Checked =
				radioButton3.Checked =
				radioButton4.Checked = false;
		}
	}
}
