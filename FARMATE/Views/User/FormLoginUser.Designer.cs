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
            btnKeluar = new Button();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.DarkOliveGreen;
            txtEmail.Location = new Point(624, 511);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(640, 40);
            txtEmail.TabIndex = 0;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.DarkOliveGreen;
            txtPassword.Location = new Point(624, 618);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(640, 45);
            txtPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.ForeColor = Color.Transparent;
            btnLogin.Image = (Image)resources.GetObject("btnLogin.Image");
            btnLogin.Location = new Point(989, 709);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(275, 76);
            btnLogin.TabIndex = 4;
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
            // btnKeluar
            // 
            btnKeluar.BackColor = Color.Transparent;
            btnKeluar.ForeColor = Color.Transparent;
            btnKeluar.Image = (Image)resources.GetObject("btnKeluar.Image");
            btnKeluar.Location = new Point(624, 709);
            btnKeluar.Name = "btnKeluar";
            btnKeluar.Size = new Size(275, 76);
            btnKeluar.TabIndex = 6;
            btnKeluar.UseVisualStyleBackColor = false;
            btnKeluar.Click += btnKeluar_Click;
            // 
            // FormLoginUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1898, 1024);
            Controls.Add(btnKeluar);
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
        private Button btnKeluar;
    }
}