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

        private void btn_generate_Click(object sender, EventArgs e)
        {
            if (txt_mcq.Text != "" && txt_tfq.Text != "" && cmbo_crsname.Text != "")
            {
                int mcq;
                int tfq;
                int grade;
                if (int.TryParse(txt_mcq.Text, out mcq) && int.TryParse(txt_tfq.Text, out tfq) && int.TryParse(txt_examGrade.Text, out grade))
                {
                    if ((mcq + tfq) <= 10)
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
                        MessageBox.Show("Sum of question number must not exceed 10");
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
                    if (result.Count>0) {
                        var exam= result[0];
                        txt_ex_id.Text = exam.Exm_Id.ToString();
                        txt_course.Text = exam.Course.Crs_Name;
                        txt_generator.Text = exam.Instructor.Ins_Fname;
                        txt_grade.Text = exam.Exm_Grade.ToString();
                    }
                    else {
                        txt_ex_id.Text = txt_course.Text = txt_generator.Text = txt_grade.Text=String.Empty;
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
            else {
                MessageBox.Show("Enter missing field data");
            }
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            var result = ent.Exams.Select(ex => ex).ToList();
            
            foreach (var item in result)
            {              
               ListViewItem lsv = new ListViewItem();
                lsv.SubItems.Add(item.Exm_Id.ToString());
                lsv.SubItems.Add(item.Exm_Id.ToString());


            }
        }
    }
}
