using Examination_system.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination_system.Forms
{
    public partial class instructorForm : Form
    {
        string ins_username;
        Form logform;
        ExamSystemEntities ent;
        static Instructor insData;
        public static int InstructorDataProp
        {
            get { return insData.Ins_Id; }
        }
        public instructorForm(string username, Form logform)
        {
            InitializeComponent();
            ent = new ExamSystemEntities();
            ins_username = username;
            this.logform = logform;
            insData = ent.Instructors.Where(i => i.User.U_UserName == username).ToList().First();
            lbl_username.Text = insData.Ins_Fname;

        }

        private void instructorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            logform.Close();
        }
        #region exam
        private void btn_generate_Click(object sender, EventArgs e)
        {
            if (txt_mcq.Text != "" && txt_tfq.Text != "" && cmbo_crsname.Text != "")
            {
                int mcq;
                int tfq;
                int grade;
                if (int.TryParse(txt_mcq.Text, out mcq) && int.TryParse(txt_tfq.Text, out tfq) && int.TryParse(txt_examGrade.Text, out grade))
                {
                    int sum = (mcq + tfq);
                    if (sum == 10)
                    {
                        var course = ent.Courses.Where(c => c.Crs_Name == cmbo_crsname.Text).ToList().First();
                        int crsId = course.Crs_Id;
                        try
                        {
                            ent.sp_GenerateExam(mcq, tfq, crsId, insData.Ins_Id, grade);

                        }
                        catch (Exception)
                        {
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sum of question number must be 10");
                    }

                }
                else
                {
                    MessageBox.Show("Enter data in invalid format");
                }

            }
            else
            {
                MessageBox.Show("Enter the missing field");
            }

            ent.SaveChanges();
        }

        private void cmbo_crsname_DropDown(object sender, EventArgs e)
        {
            cmbo_crsname.Items.Clear();
            var result = ent.Courses.Select(c => c).ToList();
            foreach (var item in result)
            {

                cmbo_crsname.Items.Add(item.Crs_Name);
            }
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {
            int id;
            if (txt_id.Text != "")
            {
                if (int.TryParse(txt_id.Text, out id))
                {
                    var result = ent.Exams.Where(ex => ex.Exm_Id == id).ToList();
                    if (result.Count > 0)
                    {
                        var exam = result[0];
                        txt_ex_id.Text = exam.Exm_Id.ToString();
                        txt_course.Text = exam.Course.Crs_Name;
                        txt_generator.Text = exam.Instructor.Ins_Fname;
                        txt_grade.Text = exam.Exm_Grade.ToString();
                    }
                    else
                    {
                        txt_ex_id.Text = txt_course.Text = txt_generator.Text = txt_grade.Text = String.Empty;
                    }

                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int id;

            if (txt_id.Text != "" && int.TryParse(txt_id.Text, out id))
            {
                var result = ent.Exams.Where(ex => ex.Exm_Id == id).ToList();
                if (result.Count > 0)
                {
                    var exam = result[0];
                    ent.sp_deleteExam(id);
                    ent.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("Enter missing field data");
            }
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            var result = ent.Exams.Select(ex => ex).ToList();
            listView1.Items.Clear();
            foreach (var item in result)
            {

                string[] row = { item.Exm_Id.ToString(),
                    item.Course.Crs_Name,
                    item.Instructor.Ins_Fname,item.Exm_Grade.ToString()};
                ListViewItem Rowitem = new ListViewItem(row);
                listView1.Items.Add(Rowitem);

            }
        }
        #endregion
        #region departmennt
        private void btn_deptDisplay_Click(object sender, EventArgs e)
        {
            displayDepartments();
            
        }

        private void lst_department_Click(object sender, EventArgs e)
        {
            if (lst_department.SelectedItems.Count > 0)
            {
                txt_deptName.Text = lst_department.SelectedItems[0].SubItems[1].Text;
                txt_deptLoc.Text = lst_department.SelectedItems[0].SubItems[2].Text;
                txt_deptId.Text = lst_department.SelectedItems[0].SubItems[0].Text;                 
            }
        }

        private void cmbo_deptManager_DropDown(object sender, EventArgs e)
        {
            cmbo_deptManager.Items.Clear();
            var result = ent.Instructors.Select(ins => ins).ToList();
            foreach (var item in result)
            {
                cmbo_deptManager.Items.Add(item.Ins_Fname);
            }
        }

        private void btn_deptDisplayByname_Click(object sender, EventArgs e)
        {
            lst_department.Items.Clear();
            if (txt_deptName.Text != "")
            {
                var dept = ent.Departments.Where(dep => dep.Dept_Name == txt_deptName.Text).ToList();
                if (dept.Count > 0)
                {
                    foreach (var item in dept)
                    {
                        string[] row = { dept[0].Dept_Id.ToString(),
                    dept[0].Dept_Name,
                    dept[0].Dept_Loc,dept[0].Dept_ManagerHireDate.ToString(),dept[0].Instructor.Ins_Fname};
                        ListViewItem Rowitem = new ListViewItem(row);
                        lst_department.Items.Add(Rowitem);
                       
                    }
                }
                else {
                    MessageBox.Show("Not found");
                }
                txt_deptId.Text = txt_deptLoc.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Type the name you want to search by in name \"textbox\" ");
            }
        }


        private void btn_deptInsert_Click(object sender, EventArgs e)
        {
            if (txt_deptName.Text != "" && txt_deptLoc.Text != "" && cmbo_deptManager.Text != "")
            {
                string name = txt_deptName.Text;
                string location = txt_deptLoc.Text;
                DateTime dt = date_deptHire.Value;
                string managername = cmbo_deptManager.Text;

                var manager = ent.Instructors.Where(ins => ins.Ins_Fname == managername).ToList().First();
                int managerid = manager.Ins_Id;
                try
                {
                    ent.sp_insertDepartment(name, location, dt, managerid);
                }
                catch (Exception)
                {

                }

                ent.SaveChanges();
                displayDepartments();
            }
            else {
                MessageBox.Show("Enter missing filed data");
            }
        }

        private void displayDepartments() {
            lst_department.Items.Clear();
            var result =  ent.Departments.Select(dep => dep).ToList();
            if (result.Count > 0)
            {
                foreach (var item in result)
                {
                    string[] row = { item.Dept_Id.ToString(),
                    item.Dept_Name,
                    item.Dept_Loc,item.Dept_ManagerHireDate.ToString(),item.Instructor.Ins_Fname};
                    ListViewItem Rowitem = new ListViewItem(row);
                    lst_department.Items.Add(Rowitem);
                }
                btn_deptDelete.Enabled = true;
                btn_dept_update.Enabled = true;
            }
        }

        private void btn_dept_update_Click(object sender, EventArgs e)
        {
            if (txt_deptName.Text != "" && txt_deptLoc.Text != "" && txt_deptId.Text != "" && cmbo_deptManager.Text != "")
            {
                string name = txt_deptName.Text;
                string location = txt_deptLoc.Text;
                DateTime dt = date_deptHire.Value;
                string managername = cmbo_deptManager.Text;
                var manager = ent.Instructors.Where(ins => ins.Ins_Fname == managername).ToList().First();
                int managerid = manager.Ins_Id;
                int deptid = int.Parse(txt_deptId.Text);
                try
                {
                    ent.sp_updateDepartment(deptid, name, location, dt, managerid);
                }
                catch (Exception)
                {

                }
                ent.SaveChanges();
                displayDepartments();
            }
            else {
                MessageBox.Show("Enter full data to update");
            }
        }

        private void btn_deptDelete_Click(object sender, EventArgs e)
        {
            if (txt_deptId.Text != "")
            {
                int id =  int.Parse(txt_deptId.Text);
                try
                {
                    ent.sp_deleteDepartment(id);
                }
                catch (Exception)
                {

                }
                ent.SaveChanges();
                displayDepartments();
            }
            else {
                MessageBox.Show("Select department to delete");
            }
        }
		#endregion

		#region Student
		private void DisplayStd_Click(object sender, EventArgs e)
		{
            displayStudentsData();

        }
        private void displayStudentsData() {
            StdList.Items.Clear();
            var result = ent.Students.Select(s => s).ToList();
            if (result.Count > 0)
            {
                foreach (var item in result)
                {
                    string[] row =
                    {
                        item.Std_Id.ToString(),
                        item.User.U_UserName,
                        item.Department.Dept_Name,
                        item.Std_Fname,
                        item.Std_Lname,
                        item.Std_BOD.ToString(),
                        item.Std_Address
                    };
                    ListViewItem Rowitem = new ListViewItem(row);
                    StdList.Items.Add(Rowitem);
                }
            }
        }
		private void InsertStd_Click(object sender, EventArgs e)
		{
			if (StdUserNameField.Text != String.Empty
				&& StdDepartmentFiled.Text != String.Empty
				&& StdFnameField.Text != String.Empty
				&& StdLNameFld.Text != String.Empty
				&& StdBirthFld.Text != String.Empty
				&& StdAddressFld.Text != String.Empty
				)
			{
				int userName = ent.Users
					.Where(u => u.U_UserName == StdUserNameField.Text)
					.Select(u => u.U_Id)
					.FirstOrDefault();
				int deptId = ent.Departments
					.Where(d => d.Dept_Name == StdDepartmentFiled.Text)
					.Select(d => d.Dept_Id)
					.FirstOrDefault();
				string fName = StdFnameField.Text;
				string lName = StdLNameFld.Text;
				DateTime bod = StdBirthFld.Value;
				string address = StdAddressFld.Text;

				try
				{
					ent.InsertNewStd(userName, deptId, fName, lName, bod, address);
					MessageBox.Show("Student Inserted Successfully");
				}
				catch (Exception)
				{

				}
				ent.SaveChanges();
                displayStudentsData();
            }
			else
			{
				MessageBox.Show("Enter missing filed data");
			}
		}

		private void UpdateStd_Click(object sender, EventArgs e)
		{
			if (StdIdField.Text != String.Empty
				&& StdUserNameField.Text != String.Empty
				&& StdDepartmentFiled.Text != String.Empty
				&& StdFnameField.Text != String.Empty
				&& StdLNameFld.Text != String.Empty
				&& StdBirthFld.Text != String.Empty
				&& StdAddressFld.Text != String.Empty
				)
			{
				int id = int.Parse(StdIdField.Text);
				int userNameId = ent.Users
					.Where(u => u.U_UserName == StdUserNameField.Text)
					.Select(u => u.U_Id)
					.FirstOrDefault();
				int deptId = ent.Departments
					.Where(d => d.Dept_Name == StdDepartmentFiled.Text)
					.Select(d => d.Dept_Id)
					.FirstOrDefault();
				string fName = StdFnameField.Text;
				string lName = StdLNameFld.Text;
				DateTime bod = StdBirthFld.Value;
				string address = StdAddressFld.Text;
				try
				{
					ent.UpdateStdInfo(id, userNameId, deptId, fName, lName, bod, address);
					MessageBox.Show("Student Info Updated Successfully");
				}
				catch (Exception)
				{

				}
				ent.SaveChanges();
                displayStudentsData();
            }
			else
			{
				MessageBox.Show("Enter full data to update");
			}
		}

		private void DeleteStd_Click(object sender, EventArgs e)
		{
			if (StdIdField.Text != String.Empty)
			{
				int id = int.Parse(StdIdField.Text);
				try
				{
					ent.DeleteStdById(id);
					MessageBox.Show("Student Deleted Successfully");
				}
				catch (Exception)
				{

				}
				ent.SaveChanges();
                displayStudentsData();
            }
			else
			{
				MessageBox.Show("Select department to delete");
			}
		}

		private void DisplayStdByName_Click(object sender, EventArgs e)
		{
			StdList.Items.Clear();
			if (StdFnameField.Text != String.Empty && StdLNameFld.Text != String.Empty)
			{
				var stds = ent.Students
					.Where(s => s.Std_Fname == StdFnameField.Text)
					.Where(s => s.Std_Lname == StdLNameFld.Text)
					.ToList();
				if (stds.Count > 0)
				{
					foreach (var item in stds)
					{
						string[] row =
						{
							item.Std_Id.ToString(),
							item.User.U_UserName,
							item.Department.Dept_Name,
							item.Std_Fname,
							item.Std_Lname,
							item.Std_BOD.ToString(),
							item.Std_Address
						};
						ListViewItem Rowitem = new ListViewItem(row);
						StdList.Items.Add(Rowitem);
					}
				}
				else
				{
					MessageBox.Show("Not found");
				}
				StdIdField.Text =
				StdUserNameField.Text =
					StdDepartmentFiled.Text =
					StdFnameField.Text =
					StdLNameFld.Text =
					StdBirthFld.Text =
					StdAddressFld.Text = string.Empty;
			}
			else
			{
				MessageBox.Show("Type the name you want to search by in name \"textbox\" ");
			}
		}

		private void StdList_Click(object sender, EventArgs e)
		{
			if (StdList.SelectedItems.Count > 0)
			{
				StdIdField.Text = StdList.SelectedItems[0].SubItems[0].Text;
				StdUserNameField.Text = StdList.SelectedItems[0].SubItems[1].Text;
				StdDepartmentFiled.Text = StdList.SelectedItems[0].SubItems[2].Text;
				StdFnameField.Text = StdList.SelectedItems[0].SubItems[3].Text;
				StdLNameFld.Text = StdList.SelectedItems[0].SubItems[4].Text;
				try
				{
					StdBirthFld.Value = DateTime.Parse(StdList.SelectedItems[0].SubItems[5].Text);
				}
				catch (Exception ex)
				{

				}
				StdAddressFld.Text = StdList.SelectedItems[0].SubItems[6].Text;
			}
		}

        #endregion

        #region questions
        #endregion

        private void btn_quesDisplay_Click(object sender, EventArgs e)
        {
            displayQuestions();
        }
        private void displayQuestions() {
            lst_questions.Items.Clear();
            var result = ent.Questions.Select(ques=>ques).ToList();
            if (result.Count > 0) {

                foreach (var ques in result)
                {
                    string[] row = { ques.Ques_Id.ToString(),
                        ques.Crs_Id.ToString(),
                        ques.Ques_Content,ques.Ques_Type,
                        ques.Choice.Cho_Content};
                    ListViewItem Rowitem = new ListViewItem(row);
                    lst_questions.Items.Add(Rowitem);

                }
            }
        }
       

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (lst_questions.Items.Count > 0)
            {
                ListViewItem foundItem = null;
                foreach (ListViewItem item in lst_questions.Items)
                {

                    if (item.SubItems[2].Text.ToLower().Contains(txt_searchText.Text.ToLower()))
                    {
                        foundItem = item;
                        break;
                    }
                }

                if (foundItem != null)
                {                    
                    lst_questions.TopItem = foundItem;                    
                }
                else {
                    displayQuestions();
                }
            }
        }

        private void lst_questions_MouseClick(object sender, MouseEventArgs e)
        {
            if (lst_questions.SelectedItems.Count > 0) { 
            txt_quesId.Text = lst_questions.SelectedItems[0].SubItems[0].Text;
            txt_quesContent.Text = lst_questions.SelectedItems[0].SubItems[2].Text;
            }
        }

       

        private void cmbo_QuesCourse_DropDown(object sender, EventArgs e)
        {
            cmbo_QuesCourse.Items.Clear();
            var result = ent.Courses.Select(crs => crs.Crs_Name).ToList();
            if (result.Count > 0)
            {
                foreach (var item in result)
                {
                    cmbo_QuesCourse.Items.Add(item);
                }
            }
           
        }

        private void btn_quesInsert_Click(object sender, EventArgs e)
        {
           // if(cmbo_QuesCourse.Text!=""&&)
        }
    }
}
