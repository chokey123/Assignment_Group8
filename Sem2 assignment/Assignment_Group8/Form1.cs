namespace Assignment_Group8
{
    public partial class Form1 : Form
    {

        Thread th;

        public Form1()
        {
            
            InitializeComponent();
            txt_Password.UseSystemPasswordChar = true;
             
        }

      

        private void btn_Login_Click(object sender, EventArgs e)
        {
           this.Close();
           th = new Thread(openhomepage);
           th.SetApartmentState(ApartmentState.STA);
           th.Start();
        }

        private void openhomepage(object obj)
        {
            Application.Run(new Receptionist_Homepage());
        }

        private void chkbx_showPassword_CheckedChanged(object sender, EventArgs e)
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}