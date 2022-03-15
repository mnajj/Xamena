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
    public partial class instructorForm : Form
    {
        string ins_username;
        Form logform;
        ExamSystemEntities ent;
       static Dictionary<string,int> instructorData = new Dictionary<string, int>();
        public static int InstructorDataProp
        {
            get { return instructorData["id"]; }
        }
        public instructorForm(string username,Form logform)
        {
            InitializeComponent();
            ent = new ExamSystemEntities();            
            ins_username = username;
            this.logform = logform;
            var result = ent.Instructors.Where(i => i.User.U_UserName == username).ToList();
            lbl_username.Text = result[0].Ins_Fname +" "+ result[0].Ins_Lname;
            instructorData.Add("id", result[0].Ins_Id);


        }

        private void instructorForm_FormClosing(object sender, FormClosingEventArgs e)
        {            
            logform.Close();            
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            Reports repofrm =new Reports();
            repofrm.Show();
        }

        private void btn_generateexam_Click(object sender, EventArgs e)
        {
            generateExam genexm = new generateExam();
            genexm.Show();
        }
    }
}
