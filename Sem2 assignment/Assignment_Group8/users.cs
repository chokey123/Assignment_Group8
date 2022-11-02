using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Group8
{
    internal class users
    {
        private string username;
        private string password;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        public users(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public string login(string user_name, string password)
        {
            string status = null;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand( "select count(*) from users where username = '"+ username + "' and password= '" + password +"'", con);

            int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());

            if (count > 0)
            {
                SqlCommand cmd2 = new SqlCommand("select role from users where username='"+username+"' and password = '"+password + "'",con);
                string Role = cmd2.ExecuteScalar().ToString();

                if (Role == "admin")
                {

                }
                else if (Role == "receptionist")
                {
                    Receptionist_Homepage recep_home = new Receptionist_Homepage(user_name, password);
                    recep_home.ShowDialog();
                }
                else if (Role == "student")
                {

                }
                else if (Role == "tutor")
                {

                }
            }
            else
            {
                status = "Incorrect credentials";
                
            }
            con.Close();
            return status;

        }
    }
}
