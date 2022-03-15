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
    public partial class generateExam : Form
    {
        ExamSystemEntities ent;
        public generateExam()
        {
            InitializeComponent();
            ent = new ExamSystemEntities();
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            int mcq;
            int tfq;
            int crs_id;
            int ins_id;

            ent.sp_GenerateExam();
        }
    }
}
