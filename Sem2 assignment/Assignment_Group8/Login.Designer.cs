namespace Assignment_Group8
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.chkbx_showPassword = new System.Windows.Forms.CheckBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkbx_showPassword
            // 
            this.chkbx_showPassword.AutoSize = true;
            this.chkbx_showPassword.BackColor = System.Drawing.Color.Transparent;
            this.chkbx_showPassword.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkbx_showPassword.ForeColor = System.Drawing.Color.Navy;
            this.chkbx_showPassword.Location = new System.Drawing.Point(364, 411);
            this.chkbx_showPassword.Name = "chkbx_showPassword";
            this.chkbx_showPassword.Size = new System.Drawing.Size(190, 27);
            this.chkbx_showPassword.TabIndex = 11;
            this.chkbx_showPassword.Text = "show password";
            this.chkbx_showPassword.UseVisualStyleBackColor = false;
            this.chkbx_showPassword.CheckedChanged += new System.EventHandler(this.chkbx_showPassword_CheckedChanged_1);
            // 
            // btn_Login
            // 
            this.btn_Login.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Login.ForeColor = System.Drawing.Color.Navy;
            this.btn_Login.Location = new System.Drawing.Point(388, 471);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(115, 45);
            this.btn_Login.TabIndex = 10;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Password.Location = new System.Drawing.Point(311, 347);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PlaceholderText = "Password";
            this.txt_Password.Size = new System.Drawing.Size(303, 39);
            this.txt_Password.TabIndex = 9;
            // 
            // txt_Username
            // 
            this.txt_Username.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Username.Location = new System.Drawing.Point(311, 278);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.PlaceholderText = "Username";
            this.txt_Username.Size = new System.Drawing.Size(303, 39);
            this.txt_Username.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(351, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 42);
            this.label2.TabIndex = 7;
            this.label2.Text = "Login Page";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(120, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(736, 54);
            this.label1.TabIndex = 6;
            this.label1.Text = "Excellent Tuition Centre (ETC)";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(963, 567);
            this.Controls.Add(this.chkbx_showPassword);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox chkbx_showPassword;
        private Button btn_Login;
        private TextBox txt_Password;
        private TextBox txt_Username;
        private Label label2;
        private Label label1;
    }
}