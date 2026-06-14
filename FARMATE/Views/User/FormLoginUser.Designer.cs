namespace FARMATE.Views.User
{
    partial class FormLoginUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoginUser));
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lblRegister = new LinkLabel();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(624, 511);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(640, 31);
            txtEmail.TabIndex = 0;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(624, 618);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(640, 31);
            txtPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.ForeColor = Color.Transparent;
            btnLogin.Location = new Point(805, 701);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(325, 102);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblRegister
            // 
            lblRegister.ActiveLinkColor = Color.Transparent;
            lblRegister.AutoSize = true;
            lblRegister.BackColor = Color.Transparent;
            lblRegister.DisabledLinkColor = Color.Transparent;
            lblRegister.ForeColor = Color.Transparent;
            lblRegister.LinkColor = Color.Transparent;
            lblRegister.Location = new Point(836, 851);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(274, 25);
            lblRegister.TabIndex = 5;
            lblRegister.TabStop = true;
            lblRegister.Text = "Belum punya akun? daftar di sini!";
            lblRegister.VisitedLinkColor = Color.Transparent;
            lblRegister.LinkClicked += lblRegister_LinkClicked;
            // 
            // FormLoginUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1898, 1024);
            Controls.Add(lblRegister);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Name = "FormLoginUser";
            Text = "FormLoginUser";
            Load += FormLoginUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnLogin;
        private LinkLabel lblRegister;
    }
}