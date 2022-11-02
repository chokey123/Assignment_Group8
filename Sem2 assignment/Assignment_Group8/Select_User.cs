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
    public partial class Select_User : Form
    {
        public Select_User()
        {
            InitializeComponent();
        }

        private void pic_receptionist_Click(object sender, EventArgs e)
        {
            Form1 loginpage = new Form1();
            loginpage.ShowDialog();
        }
    }
}
