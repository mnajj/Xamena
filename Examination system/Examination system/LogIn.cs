using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Examination_system
{
    public partial class LogIn : Form
    {
        ExaminationSystemEntity ent;
        public LogIn()
        {
            InitializeComponent();
            ent = new ExaminationSystemEntity();
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

                    }
                }
                else {
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
