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
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(209, 81);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(150, 31);
            txtUsername.TabIndex = 0;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(209, 142);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(150, 31);
            txtNama.TabIndex = 1;
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(209, 195);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(150, 31);
            txtAlamat.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(209, 250);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 31);
            txtEmail.TabIndex = 3;
            // 
            // txtNoHp
            // 
            txtNoHp.Location = new Point(209, 302);
            txtNoHp.Name = "txtNoHp";
            txtNoHp.Size = new Size(150, 31);
            txtNoHp.TabIndex = 4;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(209, 348);
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
            txtPassword.Location = new Point(452, 173);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(150, 31);
            txtPassword.TabIndex = 7;
            // 
            // FormRegisterUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}