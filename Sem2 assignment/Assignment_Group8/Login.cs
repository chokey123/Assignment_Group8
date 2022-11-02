using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Assignment_Group8
{
    public partial class Login : Form
    {

        Thread th;

        public Login()
        {
            InitializeComponent();
            
        }

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string stat;
            users user = new users(txt_Username.Text,txt_Password.Text);
            stat = user.login(txt_Username.Text,txt_Password.Text);
            if (stat != null)
            {
                MessageBox.Show(stat);
            }
            txt_Username.Text = String.Empty;
            txt_Password.Text = String.Empty;
        }

        private void openhomepage(object obj)
        {
            
        }

      

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void chkbx_showPassword_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkbx_showPassword.Checked)
            {
                txt_Password.UseSystemPasswordChar = false;
            }
            else
            {
                txt_Password.UseSystemPasswordChar = true;
            }
        }
    }
}
