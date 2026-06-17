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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegisterUser));
            txtUsername = new TextBox();
            txtNama = new TextBox();
            txtAlamat = new TextBox();
            txtEmail = new TextBox();
            txtNoHp = new TextBox();
            txtConfirmPassword = new TextBox();
            txtPassword = new TextBox();
            lblNoHp = new Label();
            btnRegistrasi = new Button();
            btnKeluar = new Button();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.Window;
            txtUsername.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.DarkOliveGreen;
            txtUsername.Location = new Point(664, 373);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(658, 28);
            txtUsername.TabIndex = 0;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtNama
            // 
            txtNama.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNama.ForeColor = Color.DarkOliveGreen;
            txtNama.Location = new Point(664, 438);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(658, 28);
            txtNama.TabIndex = 1;
            // 
            // txtAlamat
            // 
            txtAlamat.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAlamat.ForeColor = Color.DarkOliveGreen;
            txtAlamat.Location = new Point(664, 580);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(658, 28);
            txtAlamat.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.DarkOliveGreen;
            txtEmail.Location = new Point(664, 657);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(658, 28);
            txtEmail.TabIndex = 3;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtNoHp
            // 
            txtNoHp.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNoHp.ForeColor = Color.DarkOliveGreen;
            txtNoHp.Location = new Point(664, 508);
            txtNoHp.Name = "txtNoHp";
            txtNoHp.Size = new Size(658, 28);
            txtNoHp.TabIndex = 4;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmPassword.ForeColor = Color.DarkOliveGreen;
            txtConfirmPassword.Location = new Point(664, 815);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(658, 28);
            txtConfirmPassword.TabIndex = 5;
            txtConfirmPassword.TextChanged += txtConfirmPassword_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.DarkOliveGreen;
            txtPassword.Location = new Point(664, 736);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(658, 28);
            txtPassword.TabIndex = 7;
            // 
            // lblNoHp
            // 
            lblNoHp.AutoSize = true;
            lblNoHp.Location = new Point(70, 223);
            lblNoHp.Name = "lblNoHp";
            lblNoHp.Size = new Size(0, 25);
            lblNoHp.TabIndex = 12;
            // 
            // btnRegistrasi
            // 
            btnRegistrasi.BackColor = Color.Transparent;
            btnRegistrasi.BackgroundImageLayout = ImageLayout.None;
            btnRegistrasi.ForeColor = Color.Transparent;
            btnRegistrasi.Image = (Image)resources.GetObject("btnRegistrasi.Image");
            btnRegistrasi.Location = new Point(1084, 869);
            btnRegistrasi.Name = "btnRegistrasi";
            btnRegistrasi.Size = new Size(238, 65);
            btnRegistrasi.TabIndex = 13;
            btnRegistrasi.UseVisualStyleBackColor = false;
            btnRegistrasi.Click += button1_Click;
            // 
            // btnKeluar
            // 
            btnKeluar.BackColor = Color.Transparent;
            btnKeluar.ForeColor = Color.Transparent;
            btnKeluar.Image = (Image)resources.GetObject("btnKeluar.Image");
            btnKeluar.Location = new Point(664, 869);
            btnKeluar.Name = "btnKeluar";
            btnKeluar.Size = new Size(238, 65);
            btnKeluar.TabIndex = 14;
            btnKeluar.UseVisualStyleBackColor = false;
            btnKeluar.Click += btnKeluar_Click;
            // 
            // FormRegisterUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1898, 1024);
            Controls.Add(btnKeluar);
            Controls.Add(btnRegistrasi);
            Controls.Add(lblNoHp);
            Controls.Add(txtPassword);
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
        private TextBox txtPassword;
        private Label lblNoHp;
        private Button btnRegistrasi;
        private Button btnKeluar;
    }
}