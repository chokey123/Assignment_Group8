using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Group8
{
    internal class student
    {
        private string id;
        private string name;
        private string gender;
        private string ic_passport;
        private string address;
        private string level;
        private string contact_no;
        private string emergency_contact_no;
        private string religious;
        private string email;
        private string month_of_enrollment;
        private string birthday;
        private string subject1;
        private string subject2;
        private string subject3;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Ic_passport { get => ic_passport; set => ic_passport = value; }
        public string Address { get => address; set => address = value; }
        public string Level { get => level; set => level = value; }
        public string Contact_no { get => contact_no; set => contact_no = value; }
        public string Email { get => email; set => email = value; }
        public string Month_of_enrollment { get => month_of_enrollment; set => month_of_enrollment = value; }
        public string Birthday { get => birthday; set => birthday = value; }
        public string Subject1 { get => subject1; set => subject1 = value; }
        public string Subject2 { get => subject2; set => subject2 = value; }
        public string Subject3 { get => subject3; set => subject3 = value; }
        public string Emergency_contact_no { get => emergency_contact_no; set => emergency_contact_no = value; }
        public string Religious { get => religious; set => religious = value; }

        //constructor for all details
        public student(string id,
                        string name,
                        string gender, 
                        string ic_passport, 
                        string address, 
                        string level, 
                        string contact_no, 
                        string email, 
                        string month_of_enrollment, 
                        string birthday, 
                        string emrgency_contact_no,
                        string religious,
                        string subject1, 
                        string subject2, 
                        string subject3)
        {
            this.id = id;
            this.name = name;
            this.gender = gender;
            this.ic_passport = ic_passport;
            this.address = address;
            this.level = level;
            this.contact_no = contact_no;
            this.emergency_contact_no = emrgency_contact_no;
            this.religious = religious;
            this.email = email;
            this.month_of_enrollment = month_of_enrollment;
            this.birthday = birthday;
            this.subject1 = subject1;
            this.subject2 = subject2;
            this.subject3 = subject3;
        }

        // constructor with 2 subejcts
        public student(string id,
                        string name,
                        string gender,
                        string ic_passport,
                        string address,
                        string level,
                        string contact_no,
                        string email,
                        string month_of_enrollment,
                        string birthday,
                        string subject1,
                        string subject2
                        )
        {
            this.id = id;
            this.name = name;
            this.gender = gender;
            this.ic_passport = ic_passport;
            this.address = address;
            this.level = level;
            this.contact_no = contact_no;
            this.email = email;
            this.month_of_enrollment = month_of_enrollment;
            this.birthday = birthday;
            this.subject1 = subject1;
            this.subject2 = subject2;
            subject3 = "";
            
        }

        //contsructor with 1 subjects
        public student(string id,
                       string name,
                       string gender,
                       string ic_passport,
                       string address,
                       string level,
                       string contact_no,
                       string email,
                       string month_of_enrollment,
                       string birthday,
                       string subject1
                       )
        {
            this.id = id;
            this.name = name;
            this.gender = gender;
            this.ic_passport = ic_passport;
            this.address = address;
            this.level = level;
            this.contact_no = contact_no;
            this.email = email;
            this.month_of_enrollment = month_of_enrollment;
            this.birthday = birthday;
            this.subject1 = subject1;
            subject2 = "";
            subject3 = "";
        }

        //constructor with no subject
        public student(string id,
                      string name,
                      string gender,
                      string ic_passport,
                      string address,
                      string level,
                      string contact_no,
                      string email,
                      string month_of_enrollment,
                      string birthday
                      )
        {
            this.id = id;
            this.name = name;
            this.gender = gender;
            this.ic_passport = ic_passport;
            this.address = address;
            this.level = level;
            this.contact_no = contact_no;
            this.email = email;
            this.month_of_enrollment = month_of_enrollment;
            this.birthday = birthday;
            subject1 = "";
            subject2 = "";
            subject3 = "";
        }

        public string addStudent_allSubject()
        {
            string status;
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into users(username, password, role) values (@name, '123', 'student')",con);
            SqlCommand cmd2 = new SqlCommand("insert into student" +
                                                "(ID, " +
                                                "name, " +
                                                "gender, " +
                                                "email, " +
                                                "contact_no, " +
                                                "emergency_contact_no, " +
                                                "ic_passport, " +
                                                "address, " +
                                                "religious, " +
                                                "birthday, " +
                                                "enroll_month, " +
                                                "level, " +
                                                "subject1, " +
                                                "subject2, " +
                                                "subject3) values " +
                                                        "(@ID, " +
                                                        "@name, " +
                                                        "@gender, " +
                                                        "@email, " +
                                                        "@contact_no, " +
                                                        "@emergency_contact_no, " +
                                                        "@ic_passport, " +
                                                        "@address, " +
                                                        "@religious, " +
                                                        "@birthday, " +
                                                        "@enroll_month, " +
                                                        "@level, " +
                                                        "@subject1, " +
                                                        "@subject2, " +
                                                        "@subject3)", con);
            SqlCommand cmd3 = new SqlCommand("select count(*) from users where username = @name", con);

            cmd.Parameters.AddWithValue("@name", name);

            cmd2.Parameters.AddWithValue("@ID",id);
            cmd2.Parameters.AddWithValue("@name",name);
            cmd2.Parameters.AddWithValue("@gender",gender);
            cmd2.Parameters.AddWithValue("@email",email);
            cmd2.Parameters.AddWithValue("@contact_no",contact_no);
            cmd2.Parameters.AddWithValue("@emergency_contact_no",emergency_contact_no);
            cmd2.Parameters.AddWithValue("@ic_passport",ic_passport);
            cmd2.Parameters.AddWithValue("@address",address);
            cmd2.Parameters.AddWithValue("@religious",religious);
            cmd2.Parameters.AddWithValue("@birthday",birthday);
            cmd2.Parameters.AddWithValue("@enroll_month",month_of_enrollment);
            cmd2.Parameters.AddWithValue("@level",level);
            cmd2.Parameters.AddWithValue("@subject1",subject1);
            cmd2.Parameters.AddWithValue("@subject2",subject2);
            cmd2.Parameters.AddWithValue("@subject3",subject3);

            cmd3.Parameters.AddWithValue("@name",name);
           

            int count = Convert.ToInt32(cmd3.ExecuteScalar().ToString());

            if (count > 0)
            {
                status = "Duplicated Username";
            }
            else
            {
                cmd2.ExecuteNonQuery();
                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                {
                    status = "Registration Successful";
                }
                else
                {
                    status = "Unable to register";
                }
            }
            con.Close();
            return status;

        }
    }
}
