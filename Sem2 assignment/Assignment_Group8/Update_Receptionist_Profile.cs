using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_Group8
{
    public partial class Update_Receptionist_Profile : Form
    {
        public static string name;
        public static string password;

        public Update_Receptionist_Profile()
        {
            InitializeComponent();
        }

        public Update_Receptionist_Profile(string n,string p)
        {
            InitializeComponent();
            name = n;
            password = p;
        }



        private void btn_updUsername_Click(object sender, EventArgs e)
        {
            if(resetPassword(reset_password, confirm_password))
            {
                MessageBox.Show("oh yeah.");
            }
            else
            {
                MessageBox.Show("oh no.");
            }
        }

        string reset_username,
               reset_password,
               confirm_password;

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txt_resetUsername_TextChanged(object sender, EventArgs e)
        {
          
        }

      
        

        private void Update_Receptionist_Profile_Load(object sender, EventArgs e)
        {
            label3.Text = name;
            txt_resetPassword.Text = password;
            txt_resetPassword.Enabled = false;
            txt_confPassword.Enabled = false;
        }

        private void chkbx_changepw_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbx_changepw.Checked)
            {
                DialogResult dresult;
                dresult = MessageBox.Show("Are you sure to reset password ? \nIf yes, please remember your new password for next login.", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dresult == DialogResult.Yes)
                {
                    txt_resetPassword.Enabled = true;
                    txt_confPassword.Enabled = true;
                }
                else
                {
                    txt_resetPassword.Enabled = false;
                    txt_confPassword.Enabled = false;
                    chkbx_changepw.Checked = false;
                }
            }
            else
            {
                txt_resetPassword.Text = password;
                txt_resetPassword.Enabled = false;
                txt_confPassword.Enabled = false;
            }
        }

        private void update_username()
        {
           
            
        }

        private bool resetPassword(string resetPassword, string confirmPassword)
        {
            resetPassword = txt_resetPassword.Text;
            confirmPassword = txt_confPassword.Text;

            return resetPassword == confirmPassword;
        }

        

    }
}
