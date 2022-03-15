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
        User usr = null;         
        public LogIn()
        {
            InitializeComponent();
            usr = new User();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username, password;
            if (txt_username.Text != "" && txt_password.Text != "")
            {
                username = txt_username.Text;
                password = txt_password.Text;
                if (rad_instructor.Checked)
                {
                    //var result = (usr=>)
                }

            }
            else {
                MessageBox.Show("Enter missing field data");
            }

        }
    }
}
