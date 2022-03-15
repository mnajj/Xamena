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
        public instructorForm(string username,Form logform)
        {
            InitializeComponent();
            ent = new ExamSystemEntities();            
            ins_username = username;
            this.logform = logform;
            lbl_username.Text = username;
            
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
