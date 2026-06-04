namespace FARMATE.Views.Auth
{
    partial class FormRegisterUser
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
            txtUsername = new TextBox();
            txtNama = new TextBox();
            txtAlamat = new TextBox();
            txtEmail = new TextBox();
            txtNoHp = new TextBox();
            txtConfirmPassword = new TextBox();
            btnRegister = new Button();
            txtPassword = new TextBox();
            lblUsername = new Label();
            lblNama = new Label();
            lblAlamat = new Label();
            lblEmail = new Label();
            lblNoHp = new Label();
            lblPassword = new Label();
            lblConfirm = new Label();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(70, 59);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(150, 31);
            txtUsername.TabIndex = 0;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(269, 59);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(150, 31);
            txtNama.TabIndex = 1;
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(70, 153);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(150, 31);
            txtAlamat.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(300, 153);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 31);
            txtEmail.TabIndex = 3;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtNoHp
            // 
            txtNoHp.Location = new Point(70, 251);
            txtNoHp.Name = "txtNoHp";
            txtNoHp.Size = new Size(150, 31);
            txtNoHp.TabIndex = 4;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(300, 319);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(150, 31);
            txtConfirmPassword.TabIndex = 5;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(230, 385);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(112, 34);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Registrasi";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(300, 251);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(150, 31);
            txtPassword.TabIndex = 7;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(70, 31);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(91, 25);
            lblUsername.TabIndex = 8;
            lblUsername.Text = "Username";
            lblUsername.Click += lblUsername_Click;
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Location = new Point(283, 31);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(59, 25);
            lblNama.TabIndex = 9;
            lblNama.Text = "Nama";
            lblNama.Click += lblNama_Click;
            // 
            // lblAlamat
            // 
            lblAlamat.AutoSize = true;
            lblAlamat.Location = new Point(79, 125);
            lblAlamat.Name = "lblAlamat";
            lblAlamat.Size = new Size(68, 25);
            lblAlamat.TabIndex = 10;
            lblAlamat.Text = "Alamat";
            lblAlamat.Click += lblAlamat_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(300, 125);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 25);
            lblEmail.TabIndex = 11;
            lblEmail.Text = "Email";
            lblEmail.Click += label1_Click;
            // 
            // lblNoHp
            // 
            lblNoHp.AutoSize = true;
            lblNoHp.Location = new Point(70, 223);
            lblNoHp.Name = "lblNoHp";
            lblNoHp.Size = new Size(65, 25);
            lblNoHp.TabIndex = 12;
            lblNoHp.Text = "No Hp";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(286, 220);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(87, 25);
            lblPassword.TabIndex = 13;
            lblPassword.Text = "Password";
            // 
            // lblConfirm
            // 
            lblConfirm.AutoSize = true;
            lblConfirm.Location = new Point(138, 325);
            lblConfirm.Name = "lblConfirm";
            lblConfirm.Size = new Size(156, 25);
            lblConfirm.TabIndex = 14;
            lblConfirm.Text = "Confirm Password";
            // 
            // FormRegisterUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblConfirm);
            Controls.Add(lblPassword);
            Controls.Add(lblNoHp);
            Controls.Add(lblEmail);
            Controls.Add(lblAlamat);
            Controls.Add(lblNama);
            Controls.Add(lblUsername);
            Controls.Add(txtPassword);
            Controls.Add(btnRegister);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtNoHp);
            Controls.Add(txtEmail);
            Controls.Add(txtAlamat);
            Controls.Add(txtNama);
            Controls.Add(txtUsername);
            Name = "FormRegisterUser";
            Text = "FormRegister";
            Load += FormRegisterUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtNama;
        private TextBox txtAlamat;
        private TextBox txtEmail;
        private TextBox txtNoHp;
        private TextBox txtConfirmPassword;
        private Button btnRegister;
        private TextBox txtPassword;
        private Label lblUsername;
        private Label lblNama;
        private Label lblAlamat;
        private Label lblEmail;
        private Label lblNoHp;
        private Label lblPassword;
        private Label lblConfirm;
    }
}