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
    public partial class Update_Subject_Enrollment : Form
    {
        public Update_Subject_Enrollment()
        {
            InitializeComponent();
        }

        private void Update_Subject_Enrollment_Load(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            subject_select();
            subject_amount = 0;
            Array.Clear(selected_subject, 0, selected_subject.Length);
            Array.Resize(ref selected_subject, 0);
        }

        int subject_amount = 0;
        string[] selected_subject = new string[0];

        private void subject_select()
        {
            if (chkbx_bm.Checked)
            {
                subject_amount += 1;
                selected_subject = selected_subject.Append(chkbx_bm.Text).ToArray();
            }

            if (chkbx_en.Checked)
            {
                subject_amount += 1;
                selected_subject = selected_subject.Append(chkbx_en.Text).ToArray();
            }

            if (chkbx_cn.Checked)
            {
                subject_amount += 1;
                selected_subject = selected_subject.Append(chkbx_cn.Text).ToArray();
            }

            if (chkbx_math.Checked)
            {
                subject_amount += 1;
                selected_subject = selected_subject.Append(chkbx_math.Text).ToArray();
            }

            if (chkbx_sej.Checked)
            {
                subject_amount += 1;
                selected_subject = selected_subject.Append(chkbx_sej.Text).ToArray();
            }

            if (chkbx_sci.Checked)
            {
                subject_amount += 1;
                selected_subject = selected_subject.Append(chkbx_sci.Text).ToArray();
            }

            if (chkbx_geo.Checked)
            {
                subject_amount += 1;
                selected_subject = selected_subject.Append(chkbx_geo.Text).ToArray();
            }

            if (chkbx_acc.Checked)
            {
                subject_amount += 1;
                selected_subject = selected_subject.Append(chkbx_acc.Text).ToArray();
            }

            if (subject_amount > 3)
            {
                MessageBox.Show(subject_amount.ToString() + "\nThe amount of subject selected is only up to 3 !!!!");
            }
            else
            {
                foreach (var i in selected_subject)
                {
                    MessageBox.Show(i);
                }
            }
        }
    }
}
