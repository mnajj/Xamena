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

            if (txt_mcq.Text != "" && txt_tfq.Text != "" && cmbo_crs_id.Text != "")
            {
                mcq = Convert.ToInt32(txt_mcq.Text);
                tfq = Convert.ToInt32(txt_tfq.Text);
                crs_id = Convert.ToInt32(cmbo_crs_id.Text);
                ins_id = instructorForm.InstructorDataProp;
                ent.sp_GenerateExam(mcq, tfq, crs_id, ins_id);
                ent.SaveChanges();
            }
            else {
                MessageBox.Show("Enter missing field data");
            }
            
        }

        private void generateExam_Load(object sender, EventArgs e)
        {
            var result = ent.Courses.Select(c=>c).ToList();
            foreach (var item in result)
            {
                cmbo_crs_id.Items.Add(item.Crs_Name);
            }
        }
    }
}
