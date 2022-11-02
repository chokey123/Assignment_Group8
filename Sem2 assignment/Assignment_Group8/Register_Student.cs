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
    public partial class Register_Student : Form
    {
        public Register_Student()
        {
            InitializeComponent();
            
        }

        private bool success =true;

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        private void button1_Click(object sender, EventArgs e)
        {
            get_input();
            if (success)
            {
                subject1 = selected_subject[0];
                subject2 = selected_subject[1];
                subject3 = selected_subject[2];
                student std1 = new student(student_id,
                                          name,
                                          gender,
                                          ic_passport,
                                          address,
                                          level,
                                          contact_no,
                                          email,
                                          month_of_enrollment,
                                          birthday,
                                          emergency_contact_no,
                                          religious,
                                          subject1,
                                          subject2,
                                          subject3);

                MessageBox.Show(std1.addStudent_allSubject());

                reset_all();
            }
            else
            {
                reset_value();
                MessageBox.Show(student_id + "\n" +
                           name + "\n" +
                           gender + "\n" +
                           ic_passport + "\n" +
                           address + "\n" +
                           level + "\n" +
                           contact_no + "\n" +
                           email + "\n" +
                           birthday + "\n" +
                           month_of_enrollment);
            }
           
        }

        int subject_amount = 0;
        string[] selected_subject = new string[0];

        

        string student_id,
               name,
               gender,
               ic_passport,
               address,
               level,
               contact_no,
               emergency_contact_no,
               email,
               religious,
               month_of_enrollment,
               subject1,
               subject2,
               subject3,
               birthday;

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void Register_Student_Load(object sender, EventArgs e)
        {

        }

        

        //get all the input 
        private void get_input()
        {

            //get textbox input value
            get_textbox();

            //get combobox value
            get_combobox();

            // get gender value
            get_gender();

            //get subject value
            subject_select();

            //get birthday
            birthday = datepicker_birth.Value.ToString("yyyy-MM-dd");

        }

        private void get_textbox()
        {
            if (!String.IsNullOrEmpty(txt_id.Text)
                && !String.IsNullOrEmpty(txt_name.Text)
                && !String.IsNullOrEmpty(txt_ic_passport.Text)
                && !String.IsNullOrEmpty(txt_address.Text)
                && !String.IsNullOrEmpty(txt_contact_no.Text)
                && !String.IsNullOrEmpty(txt_Email.Text)
                && !String.IsNullOrEmpty(txt_religious.Text)
                && !String.IsNullOrEmpty(txt_emergencycontact.Text)
                )
            {
                student_id = txt_id.Text;
                name = txt_name.Text;
                ic_passport = txt_ic_passport.Text;
                address = txt_address.Text;
                contact_no = txt_contact_no.Text;
                email = txt_Email.Text;
                religious = txt_religious.Text;
                emergency_contact_no = txt_emergencycontact.Text;
            }
            else
            {
                MessageBox.Show("Please input all the information properly.");
                success = false;
                return;
            }
        }

        private void get_gender()
        {
            //get radiobutton value
            if (radbtn_male.Checked)
            {
                gender = radbtn_male.Text;
            }
            else if (radbtn_female.Checked)
            {
                gender = radbtn_female.Text;
            }
            else
            {
                MessageBox.Show("Please select your gender.");
                success = false;
                return;
            }
        }

        
      
        private void get_combobox()
        {
            if (cmbbx_level.SelectedIndex != -1)
            {
                level = cmbbx_level.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Please select student's level");
                success = false;
                return;
            }

            if (cmbbx_month.SelectedIndex != -1)
            {
                month_of_enrollment = cmbbx_month.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Please select month of enrollment");
                success = false;
                return;
            }
        }

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
                success = false;
                return;
            }
          

        }

        private void reset_all()
        {
            reset_value();

            //reset textbox
            txt_id.Text = String.Empty;
            txt_name.Text = String.Empty;
            txt_contact_no.Text = String.Empty;
            txt_ic_passport.Text = String.Empty;
            txt_address.Text = String.Empty;
            txt_Email.Text = String.Empty;
            
            //reset combobox
            cmbbx_level.SelectedIndex = -1;
            cmbbx_month.SelectedIndex = -1;

            //reset radiobutton
            radbtn_female.Checked = false;
            radbtn_male.Checked = false;

            //reset checkbox value
            chkbx_bm.Checked = false;
            chkbx_cn.Checked = false;
            chkbx_en.Checked = false;
            chkbx_sci.Checked = false;
            chkbx_geo.Checked = false;
            chkbx_acc.Checked = false;
            chkbx_sej.Checked = false;
            chkbx_math.Checked = false;
        }

        private void reset_value()
        {
            //reset variable
            student_id = "";
            name = "";
            gender = "";
            ic_passport = "";
            address = "";
            email = "";
            level = "";
            religious = "";
            month_of_enrollment = "";
            contact_no = "";
            emergency_contact_no = "";
            birthday = "";

            //reset arrays value
            subject_amount = 0;
            Array.Clear(selected_subject, 0, selected_subject.Length);
            Array.Resize(ref selected_subject, 0);
        }
        
    }
}
