using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_Group8
{
    public partial class Receptionist_Homepage : Form
    {

        public static string name;
        public static string password;

        public Receptionist_Homepage()
        {
            InitializeComponent();
        }

        public Receptionist_Homepage(string n, string p)
        {
            InitializeComponent();
            name = n;
            password = p;
        }

        private void Receptionist_Homepage_Load(object sender, EventArgs e)
        {
            lblwelcome.Text = "Welcome, " + name;
        }

        private void btn_regstudent_Click(object sender, EventArgs e)
        {
            Register_Student register_Student = new Register_Student();
            register_Student.ShowDialog();
        }

        private void btn_updSubjectEnroll_Click(object sender, EventArgs e)
        {
            Update_Subject_Enrollment update_Subject_Enrollment = new Update_Subject_Enrollment();
            update_Subject_Enrollment.ShowDialog(); 
        }

        private void btn_genReceipt_Click(object sender, EventArgs e)
        {
            Generate_Receipt generate_Receipt = new Generate_Receipt();
            generate_Receipt.ShowDialog();
        }

        private void btn_delStudent_Click(object sender, EventArgs e)
        {
            Delete_Student delete_Student = new Delete_Student();
            delete_Student.ShowDialog();
        }

        private void btn_updProfile_Click(object sender, EventArgs e)
        {
            Update_Receptionist_Profile update_Receptionist_Profile = new Update_Receptionist_Profile(name,password);
            update_Receptionist_Profile.ShowDialog();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
           
        }

        private void lblwelcome_Click(object sender, EventArgs e)
        {

        }
    }
}
