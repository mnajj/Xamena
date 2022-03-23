using Examination_system.Forms.Dialogs;
using Examination_system.Model;
using System;
using System.Data;
using System.Linq;
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
                         DisplayExams();                        
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
                    DialogResult drs = MessageBox.Show("Are you sure ?", "Delete confirmation", MessageBoxButtons.YesNo);

                    if (drs == DialogResult.Yes)
                    {
                        ent.sp_deleteExam(id);
                        ent.SaveChanges();
                        DisplayExams();
                    }
                }
            }
            else
            {
                MessageBox.Show("Enter missing field data");
            }
        }
        private void DisplayExams()
        {
            var result = ent.Exams.Select(ex => ex).ToList();
            lst_exams.Items.Clear();
            foreach (var item in result)
            {

                string[] row = { item.Exm_Id.ToString(),
                    item.Course.Crs_Name,
                    item.Instructor.Ins_Fname,item.Exm_Grade.ToString()};
                ListViewItem Rowitem = new ListViewItem(row);
                lst_exams.Items.Add(Rowitem);

            }
        }
        private void tabpage_exams_Enter(object sender, EventArgs e)
        {
            DisplayExams();
        }
        private void lst_exams_MouseClick(object sender, MouseEventArgs e)
        {
            if (lst_exams.SelectedItems.Count > 0)
            {
                txt_id.Text = lst_exams.SelectedItems[0].SubItems[0].Text;
            }
        }

        #endregion
        #region departmennt      
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
            
            if (txt_deptName.Text != "")
            {
                var dept = ent.Departments.Where(dep => dep.Dept_Name.Contains(txt_deptName.Text)).ToList();
                if (dept.Count>0)
                {
                    lst_department.Items.Clear();
                    foreach (var item in dept)
                    {                        
                        string[] row = { item.Dept_Id.ToString(),
                    item.Dept_Name,
                    item.Dept_Loc,item.Dept_ManagerHireDate.ToString(),item.Instructor.Ins_Fname};
                        ListViewItem Rowitem = new ListViewItem(row);
                        lst_department.Items.Add(Rowitem);
                    }
                   
                }
                else
                {
                    MessageBox.Show("Not found");
                }
                
            }
            else
            {
                MessageBox.Show("Type the name you want to search by in name \"textbox\" ");
            }
        }
        private void tabpage_department_Enter(object sender, EventArgs e)
        {
            displayDepartments();
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
            else
            {
                MessageBox.Show("Enter missing filed data");
            }
        }
        private void displayDepartments()
        {
            lst_department.Items.Clear();
            var result = ent.Departments.Select(dep => dep).ToList();
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
                txt_deptId.Text = txt_deptLoc.Text = string.Empty;
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
            else
            {
                MessageBox.Show("Enter full data to update");
            }
        }
        private void btn_deptDelete_Click(object sender, EventArgs e)
        {
            if (txt_deptId.Text != "")
            {
                int id = int.Parse(txt_deptId.Text);
                try
                {
                    DialogResult drs = MessageBox.Show("Are you sure ?", "Delete confirmation", MessageBoxButtons.YesNo);

                    if (drs == DialogResult.Yes)
                    {
                        ent.sp_deleteDepartment(id);
                    }

                }
                catch (Exception)
                {

                }
                ent.SaveChanges();
                displayDepartments();
            }
            else
            {
                MessageBox.Show("Select department to delete");
            }
        }
        #endregion
        #region Student
        private void DisplayStd_Click(object sender, EventArgs e)
        {
            displayStudentsData();

        }
        private void displayStudentsData()
        {
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
        private void btn_quesDisplay_Click(object sender, EventArgs e)
        {
            displayQuestions();
        }
        private void displayQuestions()
        {
            lst_questions.Items.Clear();
            string content = "Null";
            string[] row = new string[5];
            var result = ent.Questions.Select(ques => ques).ToList();
            if (result.Count > 0)
            {

                foreach (var ques in result)
                {
                    if (ques.Choice == null)
                    {
                        row[4] = content;
                    }
                    else
                    {
                        row[4] = ques.Choice.Cho_Content;
                    }
                    row[0] = ques.Ques_Id.ToString();
                    row[1] = ques.Crs_Id.ToString();
                    row[2] = ques.Ques_Content;
                    row[3] = ques.Ques_Type;
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
                else
                {
                    displayQuestions();
                }
            }
        }
        private void lst_questions_MouseClick(object sender, MouseEventArgs e)
        {
            if (lst_questions.SelectedItems.Count > 0)
            {
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

            if (cmbo_QuesCourse.Text != "" && cmbo_quesType.Text != "" && txt_quesContent.Text != "")
            {

                var result = ent.Courses.Where(crs => crs.Crs_Name == cmbo_QuesCourse.Text).ToList().First();
                try
                {
                    int quecmbo_QuesCourse = result.Crs_Id;
                    string content = txt_quesContent.Text;
                    string type = cmbo_quesType.Text;
                    ent.InsertQues(quecmbo_QuesCourse, content, 1, type, null);
                }
                catch (Exception)
                {


                }
                ent.SaveChanges();
                displayQuestions();
                var LastID = ent.Questions.Max(ques => ques.Ques_Id);
                var lastQuesContent = ent.Questions.Where(ques => ques.Ques_Id == LastID).ToList().First();
                if (cmbo_quesType.Text == "MCQ")
                {
                    lbl_lastQuesID.Text = LastID.ToString();
                    txt_lastQuesContent.Text = lastQuesContent.Ques_Content;
                }
                else if (cmbo_quesType.Text == "TFQ")
                {
                    lbl_lastquesIdTFQ.Text = LastID.ToString();
                    txt_lastquesContentTFQ.Text = lastQuesContent.Ques_Content;
                }

            }
            else
            {
                MessageBox.Show("Enter missing field data");
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string[] arr = { "A", "B", "C", "D" };
            string[] choices = new string[4];
            bool[] model = new bool[4];

            if (lbl_lastQuesID.Text == "Question ID")
            {
                MessageBox.Show("Must insert question first before inserting choices");
            }
            else if (txt_choice1Content.Text != "" && txt_choice2Content.Text != "" && txt_choice3Content.Text != "" && txt_choice4Content.Text != "")
            {
                choices[0] = txt_choice1Content.Text;
                choices[1] = txt_choice2Content.Text;
                choices[2] = txt_choice3Content.Text;
                choices[3] = txt_choice4Content.Text;

                model[0] = cho1radio.Checked;
                model[1] = cho2radio.Checked;
                model[2] = cho3radio.Checked;
                model[3] = cho4radio.Checked;

                int lastquesId = int.Parse(lbl_lastQuesID.Text);
                for (int i = 0; i < 4; i++)
                {
                    try
                    {
                        ent.sp_InsertChoice(lastquesId, choices[i], arr[i]);
                    }
                    catch (Exception)
                    {

                    }
                    ent.SaveChanges();
                    if (model[i])
                    {
                        var lastchoice = ent.Choices.Max(ch => ch.Cho_Id);
                        try
                        {
                            var question = ent.Questions.Where(ques => ques.Ques_Id == lastquesId).ToList().First();
                            ent.UpdateQues(question.Ques_Id, question.Crs_Id, question.Ques_Content, question.Ques_Grade, question.Ques_Type, lastchoice);
                        }
                        catch (Exception)
                        {


                        }
                        ent.SaveChanges();
                    }


                }
                displayQuestions();

            }
            else
            {
                MessageBox.Show("Enter missing fields");
            }
        }
        private void btn_quesDelete_Click(object sender, EventArgs e)
        {
            if (lst_questions.SelectedItems.Count > 0)
            {
                try
                {
                    DialogResult drs = MessageBox.Show("Are you sure ?", "Delete confirmation", MessageBoxButtons.YesNo);

                    if (drs == DialogResult.Yes)
                    {
                        ent.sp_DeleteQues(int.Parse(txt_quesId.Text));
                    }
                }
                catch (Exception)
                {


                }
                ent.SaveChanges();
                txt_quesId.Text = txt_quesContent.Text = string.Empty;
                displayQuestions();
            }
        }
        private void cmbo_quesType_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lbl_lastquesIdTFQ.Text == "Question ID" && lbl_lastQuesID.Text == "Question ID")
            {
                if (cmbo_quesType.Text == "MCQ")
                {
                    grp_choices.Enabled = true;
                    grp_TFQ.Enabled = false;
                }
                else if (cmbo_quesType.Text == "TFQ")
                {
                    grp_choices.Enabled = false;
                    grp_TFQ.Enabled = true;

                }
            }
            else
            {
                MessageBox.Show("Enter choices for the last question first");
            }

        }
        private void btn_TfqAdd_Click(object sender, EventArgs e)
        {

            if (lbl_lastquesIdTFQ.Text == "Question ID")
            {
                MessageBox.Show("Must insert question first before inserting choices");
            }
            else if (cmbo_TfqModel.Text != "")
            {
                int lastquesId = int.Parse(lbl_lastquesIdTFQ.Text);
                var question = ent.Questions.Where(ques => ques.Ques_Id == lastquesId).ToList().First();
                if (cmbo_TfqModel.Text == "True")
                {
                    try
                    {

                        ent.UpdateQues(question.Ques_Id, question.Crs_Id, question.Ques_Content, question.Ques_Grade, question.Ques_Type, 1);
                    }
                    catch (Exception)
                    {


                    }

                }
                else if (cmbo_TfqModel.Text == "False")
                {
                    try
                    {
                        ent.UpdateQues(question.Ques_Id, question.Crs_Id, question.Ques_Content, question.Ques_Grade, question.Ques_Type, 2);
                    }
                    catch (Exception)
                    {


                    }
                }
                lbl_lastquesIdTFQ.Text = string.Empty;
                ent.SaveChanges();

            }
            else
            {
                MessageBox.Show("Must select model answer");
            }

        }
        #endregion

        #region User

        private void Button4_Click(object sender, EventArgs e)
        {
            DisplayUsersData();
        }
        private void DisplayUsersData()
        {
            UsersList.Items.Clear();
            var result = ent.Users.Select(u => u).ToList();
            if (result.Count > 0)
            {
                foreach (var item in result)
                {
                    string[] row =
                    {
                        item.U_Id.ToString(),
                        item.U_UserName,
                        item.U_Email,
                        item.U_Password,
                        item.U_Sex
                    };
                    ListViewItem Rowitem = new ListViewItem(row);
                    UsersList.Items.Add(Rowitem);
                }
            }
        }
        private void UpdateUser_Click(object sender, EventArgs e)
        {
            if (
                UserIdFld.Text != String.Empty
                && UserUserNameFld.Text != String.Empty
                && UserPassFld.Text != String.Empty
                && UserMailFld.Text != String.Empty
                && UserSexFld.Text != String.Empty
                && (radioButton1.Checked == true || radioButton2.Checked == true)
                )
            {
                if (ent.Users.Contains(new User { U_UserName = UserUserNameFld.Text }))
                {
                    MessageBox.Show("Another User has the same user name. Please, enter a new one");
                    return;
                }
                else
                {
                    bool isStd = false;
                    if (radioButton1.Checked == true)
                    {
                        isStd = true;
                    }
                    else
                    {
                        isStd = false;
                    }
                    try
                    {
                        ent.UpdateUser(int.Parse(UserIdFld.Text), UserUserNameFld.Text, UserMailFld.Text, UserPassFld.Text, UserSexFld.Text, isStd);
                        MessageBox.Show("User Info Updated Successfully");
                    }
                    catch (Exception ex)
                    {

                    }
                    ent.SaveChanges();
                    DisplayUsersData();
                }
            }
            else
            {
                MessageBox.Show("Enter full data to update");
            }

        }
        private void InsertUserBtn_Click(object sender, EventArgs e)
        {
            if (UserUserNameFld.Text != String.Empty
                && UserPassFld.Text != String.Empty
                && UserMailFld.Text != String.Empty
                && UserSexFld.Text != String.Empty
                && (radioButton1.Checked == true || radioButton2.Checked == true)
                )
            {
                if (ent.Users.Contains(new User { U_UserName = UserUserNameFld.Text }))
                {
                    MessageBox.Show("Another User has the same user name. Please, enter a new one");
                    return;
                }
                else
                {
                    bool isStd = false;
                    if (radioButton1.Checked == true)
                    {
                        isStd = true;
                    }
                    else
                    {
                        isStd = false;
                    }
                    try
                    {
                        ent.InsertNewUser(UserUserNameFld.Text, UserMailFld.Text, UserPassFld.Text, UserSexFld.Text, isStd);
                        MessageBox.Show("Student Inserted Successfully");
                    }
                    catch (Exception ex)
                    {

                    }
                }
                ent.SaveChanges();
                DisplayUsersData();
            }
            else
            {
                MessageBox.Show("Enter missing filed data");
            }

        }
        private void DeleteUser_Click(object sender, EventArgs e)
        {
            if (UserUserNameFld.Text != String.Empty)
            {
                try
                {
                    ent.DeleteUserByUserName(UserUserNameFld.Text);
                    MessageBox.Show("User Deleted Successfully");
                }
                catch (Exception ex)
                {

                }
                ent.SaveChanges();
                displayStudentsData();
            }
            else
            {
                MessageBox.Show("Select User to delete");
            }
        }
        private void DisplayUserByUserName_Click(object sender, EventArgs e)
        {
            UsersList.Items.Clear();
            if (UserUserNameFld.Text != String.Empty)
            {
                var users = ent.Users
                    .Where(u => u.U_UserName == UserUserNameFld.Text)
                    .ToList();
                if (users.Count > 0)
                {
                    foreach (var item in users)
                    {
                        string[] row =
                        {
                            item.U_Id.ToString(),
                            item.U_UserName,
                            item.U_Email,
                            item.U_Password,
                            item.U_Sex
                        };
                        ListViewItem Rowitem = new ListViewItem(row);
                        StdList.Items.Add(Rowitem);
                    }
                }
                else
                {
                    MessageBox.Show("Not found");
                }
                UserUserNameFld.Text =
                 UserPassFld.Text =
                 UserMailFld.Text =
                 UserSexFld.Text = String.Empty;
                radioButton1.Checked = radioButton2.Checked = false;
            }
            else
            {
                MessageBox.Show("Type the name you want to search by in name \"textbox\" ");
            }
        }
        private void UsersList_Click(object sender, EventArgs e)
        {
            if (UsersList.SelectedItems.Count > 0)
            {
                UserIdFld.Text = UsersList.SelectedItems[0].SubItems[0].Text;
                UserUserNameFld.Text = UsersList.SelectedItems[0].SubItems[1].Text;
                UserMailFld.Text = UsersList.SelectedItems[0].SubItems[2].Text;
                UserPassFld.Text = UsersList.SelectedItems[0].SubItems[3].Text;
                UserSexFld.Text = UsersList.SelectedItems[0].SubItems[4].Text;
            }
        }
        #endregion

        #region Instructor
        private void DisplayIns_Click(object sender, EventArgs e)
        {
            DisplayInsData();
        }
        private void DisplayInsData()
        {
            InsList.Items.Clear();
            var result = ent.Instructors.Select(i => i).ToList();
            if (result.Count > 0)
            {
                foreach (var item in result)
                {
                    string[] row =
                    {
                        item.Ins_Id.ToString(),
                        item.User.U_UserName,
                        item.Department.Dept_Name,
                        item.Ins_Fname,
                        item.Ins_Lname,
                        item.Ins_Degree,
                        item.Ins_Salary.ToString()
                    };
                    ListViewItem Rowitem = new ListViewItem(row);
                    InsList.Items.Add(Rowitem);
                }
            }
        }
        private void InsertIns_Click(object sender, EventArgs e)
        {
            if (InsUserNameFld.Text != String.Empty
                && InsDeptFld.Text != String.Empty
                && InsFnameFld.Text != String.Empty
                && InsLnameFld.Text != String.Empty
                && InsDegFld.Text != String.Empty
                && InsSalaryFld.Text != String.Empty
                )
            {
                int userName = ent.Users
                    .Where(u => u.U_UserName == InsUserNameFld.Text)
                    .Select(u => u.U_Id)
                    .FirstOrDefault();
                int deptId = ent.Departments
                    .Where(d => d.Dept_Name == InsDeptFld.Text)
                    .Select(d => d.Dept_Id)
                    .FirstOrDefault();
                string fName = InsFnameFld.Text;
                string lName = InsLnameFld.Text;
                string deg = InsDegFld.Text;
                int salary = int.Parse(InsSalaryFld.Text);

                try
                {
                    ent.InsertInstructor(userName, deptId, fName, lName, deg, salary);
                    MessageBox.Show("Instructor Inserted Successfully");
                }
                catch (Exception ex) { }
                ent.SaveChanges();
                DisplayInsData();
            }
            else
            {
                MessageBox.Show("Enter missing filed data");
            }

        }
        private void UpdateIns_Click(object sender, EventArgs e)
        {
            if (
                InsIdFld.Text != String.Empty
                && InsUserNameFld.Text != String.Empty
                && InsDeptFld.Text != String.Empty
                && InsFnameFld.Text != String.Empty
                && InsLnameFld.Text != String.Empty
                && InsDegFld.Text != String.Empty
                && InsSalaryFld.Text != String.Empty
                )
            {
                int id = int.Parse(InsIdFld.Text);
                int userNameId = ent.Users
                    .Where(u => u.U_UserName == InsUserNameFld.Text)
                    .Select(u => u.U_Id)
                    .FirstOrDefault();
                int deptId = ent.Departments
                    .Where(d => d.Dept_Name == InsDeptFld.Text)
                    .Select(d => d.Dept_Id)
                    .FirstOrDefault();
                string fName = InsFnameFld.Text;
                string lName = InsLnameFld.Text;
                string deg = InsDegFld.Text;
                int salary = int.Parse(InsSalaryFld.Text);
                try
                {
                    ent.UpdateInstructor(id, userNameId, deptId, fName, lName, deg, salary);
                    MessageBox.Show("Instructor Info Updated Successfully");
                }
                catch (Exception)
                {

                }
                ent.SaveChanges();
                DisplayInsData();
            }
            else
            {
                MessageBox.Show("Enter full data to update");
            }
        }
        private void DeleteIns_Click(object sender, EventArgs e)
        {
            if (InsIdFld.Text != String.Empty)
            {
                int id = int.Parse(InsIdFld.Text);
                try
                {
                    ent.DeleteInstructor(id);
                    MessageBox.Show("Instructor Deleted Successfully");
                }
                catch (Exception ex)
                {

                }
                ent.SaveChanges();
                DisplayInsData();
            }
            else
            {
                MessageBox.Show("Select Instructor to delete");
            }
        }
        private void DisplayInsByName_Click(object sender, EventArgs e)
        {
            InsList.Items.Clear();
            if (InsFnameFld.Text != String.Empty && InsLnameFld.Text != String.Empty)
            {
                var inss = ent.Instructors
                    .Where(s => s.Ins_Fname == InsFnameFld.Text)
                    .Where(s => s.Ins_Lname == InsLnameFld.Text)
                    .ToList();
                if (inss.Count > 0)
                {
                    foreach (var item in inss)
                    {
                        string[] row =
                        {
                        item.Ins_Id.ToString(),
                        item.User.U_UserName,
                        item.Department.Dept_Name,
                        item.Ins_Fname,
                        item.Ins_Lname,
                        item.Ins_Degree,
                        item.Ins_Salary.ToString()
                        };
                        ListViewItem Rowitem = new ListViewItem(row);
                        InsList.Items.Add(Rowitem);
                    }
                }
                else
                {
                    MessageBox.Show("Not found");
                }
                InsIdFld.Text =
                InsUserNameFld.Text =
                    InsDeptFld.Text =
                    InsFnameFld.Text =
                    InsLnameFld.Text =
                    InsDegFld.Text =
                    InsSalaryFld.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Type the name you want to search by in name \"textbox\" ");
            }

        }
        private void InsList_Click(object sender, EventArgs e)
        {
            if (InsList.SelectedItems.Count > 0)
            {
                InsIdFld.Text = InsList.SelectedItems[0].SubItems[0].Text;
                InsUserNameFld.Text = InsList.SelectedItems[0].SubItems[1].Text;
                InsDeptFld.Text = InsList.SelectedItems[0].SubItems[2].Text;
                InsFnameFld.Text = InsList.SelectedItems[0].SubItems[3].Text;
                InsLnameFld.Text = InsList.SelectedItems[0].SubItems[4].Text;
                InsDegFld.Text = InsList.SelectedItems[0].SubItems[5].Text;
                InsSalaryFld.Text = InsList.SelectedItems[0].SubItems[6].Text;
            }
        }
        #endregion

        #region Reports

        private void ReportsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ReportsComboBox.Text)
            {
                case "Student per Department":
                    GenerateStudentPerDepartment();
                    break;
                case "Student Grades per Course":
                    GenerateStudentGradesPerCourse();
                    break;
                case "Courses Names with Student Count by Instructor Id":
                    GenerateCoursesNamesByInstructorId();
                    break;
                case "Course Topics":
                    GenerateCourseTopics();
                    break;
                case "Exam Questions and Answers":
                    GenerateExamQuestionsAndAnswers();
                    break;
                case "Student Answers at Exam":
                    GenerateStudentAnswersAtExam();
                    break;
            }
        }
        private void GenerateStudentAnswersAtExam()
        {
            StdExamAnsPrompet stdExamAnsPrompet = new StdExamAnsPrompet();
            DialogResult dlgRes = stdExamAnsPrompet.ShowDialog();
            if (dlgRes == DialogResult.OK)
            {
                StdExamAnswersReport.Compile();
                StdExamAnswersReport["@exm_id"] = stdExamAnsPrompet.ExamId.ToString();
                StdExamAnswersReport["@std_id"] = stdExamAnsPrompet.StdId.ToString();
                StdExamAnswersReport.Show();
                StiReportViewerControl.Report = StdExamAnswersReport;
            }
        }
        private void GenerateExamQuestionsAndAnswers()
        {
            ExamQuesPrompet examQuesPrompet = new ExamQuesPrompet();
            DialogResult dlgRes = examQuesPrompet.ShowDialog();
            if (dlgRes == DialogResult.OK)
            {
                ExamQAndAReport.Compile();
                ExamQAndAReport["@exm_id"] = examQuesPrompet.ExamId.ToString();
                ExamQAndAReport.Show();
                StiReportViewerControl.Report = ExamQAndAReport;
            }
        }
        private void GenerateCourseTopics()
        {
            CourseTopicPrompet courseTopicPrompet = new CourseTopicPrompet();
            DialogResult dlgRes = courseTopicPrompet.ShowDialog();
            if (dlgRes == DialogResult.OK)
            {
                CourseTopicReport.Compile();
                CourseTopicReport["@crs_id"] = courseTopicPrompet.CrsId.ToString();
                CourseTopicReport.Show();
                StiReportViewerControl.Report = CourseTopicReport;
            }
        }
        private void GenerateCoursesNamesByInstructorId()
        {
            InstructorCoursesPrompet instructorCoursesPrompet = new InstructorCoursesPrompet();
            DialogResult dlgRes = instructorCoursesPrompet.ShowDialog();
            if (dlgRes == DialogResult.OK)
            {
                InsCrsReport.Compile();
                InsCrsReport["@ins_id"] = instructorCoursesPrompet.InsId.ToString();
                MessageBox.Show(InsCrsReport["@ins_id"].ToString());
                InsCrsReport.Show();
                StiReportViewerControl.Report = InsCrsReport;
            }
        }
        private void GenerateStudentGradesPerCourse()
        {
            StudentCourseGradePrompet studentCourseGradePrompet = new StudentCourseGradePrompet();
            DialogResult dlgRes = studentCourseGradePrompet.ShowDialog();
            if (dlgRes == DialogResult.OK)
            {
                StudentGradePerCourse.Compile();
                StudentGradePerCourse["@std_id"] = studentCourseGradePrompet.StdId.ToString();
                StudentGradePerCourse.Show();
                StiReportViewerControl.Report = StudentGradePerCourse;
            }

        }
        private void GenerateStudentPerDepartment()
        {
            DepartmentPrompetDialog departmentPrompetDlg = new DepartmentPrompetDialog();
            DialogResult dlgRes = departmentPrompetDlg.ShowDialog();
            if (dlgRes == DialogResult.OK)
            {
                StudentperDepartmentReport.Compile();
                StudentperDepartmentReport["@dept_id"] = departmentPrompetDlg.DeptId.ToString();
                StudentperDepartmentReport.Show();
                StiReportViewerControl.Report = StudentperDepartmentReport;
            }
        }


        #endregion

       
    }
}
