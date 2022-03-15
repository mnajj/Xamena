using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Examination_system.Forms;


namespace Examination_system
{
    public partial class LogIn : Form
    {
        ExamSystemEntities ent;
        public LogIn()
        {
            InitializeComponent();
            ent = new ExamSystemEntities();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username, password;
            if (txt_username.Text != "" && txt_password.Text != "")
            {
                username = txt_username.Text;
                password = txt_password.Text;

                var result = ent.Users.Where(u => u.U_UserName == username
                && u.U_Password == password).ToList();
                if (result.Count > 0)
                {
                    if (result[0].U_IsStd)
                    {
                       
                    }
                    if (result[0].U_IsStd!=true)
                    {
                        instructorForm insForm = new instructorForm(username,this);
                         this.Hide();
                        insForm.Show();
                        
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect user name or password");
                }


            }
            else
            {
                MessageBox.Show("Enter missing field data");
            }

        }
    }
}
