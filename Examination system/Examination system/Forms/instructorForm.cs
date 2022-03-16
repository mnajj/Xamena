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
        public instructorForm(string username,Form logform)
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
                if (int.TryParse(txt_mcq.Text, out mcq) && int.TryParse(txt_tfq.Text, out tfq))
                {
                    var course = ent.Courses.Where(c => c.Crs_Name == cmbo_crsname.Text).ToList().First();
                    int crsId = course.Crs_Id;

                    SqlParameter param1 = new SqlParameter("@mcq", mcq);
                    SqlParameter param2 = new SqlParameter("@tfq", tfq);
                    SqlParameter param3 = new SqlParameter("@crs_id", crsId);
                    SqlParameter param4 = new SqlParameter("@ins_id", insData.Ins_Id);

                    //I change this line from SqlQuery to ExecuteSqlCommand
                    var remove = ent.Database.ExecuteSqlCommand(" exec sp_GenerateExam @mcq, @tfq,@crs_id,@ins_id", param1, param2,param3,param4);

                    //ent.sp_GenerateExam(mcq, tfq, crsId, insData.Ins_Id);
                }
                else {
                    MessageBox.Show("Enter data in invalid format");
                }
                
            }
            else {
                MessageBox.Show("Enter the missing field");
            }
           
            ent.SaveChanges();
        }

        private void cmbo_crsname_DropDown(object sender, EventArgs e)
        {
            cmbo_crsname.Items.Clear();
            var result = ent.Courses.Select(c=>c).ToList();
            foreach (var item in result)
            {
                
                cmbo_crsname.Items.Add(item.Crs_Name);
            }
        }
    }
}
