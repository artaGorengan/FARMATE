namespace FARMATE.Views.Admin
{
    partial class UCDataUser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNama = new Label();
            lblUsername = new Label();
            lblEmail = new Label();
            lblNoHp = new Label();
            lblAlamat = new Label();
            lblTotal = new Label();
            SuspendLayout();
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Location = new Point(30, 15);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(59, 25);
            lblNama.TabIndex = 0;
            lblNama.Text = "Nama";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(147, 15);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(91, 25);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(285, 14);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 25);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email";
            // 
            // lblNoHp
            // 
            lblNoHp.AutoSize = true;
            lblNoHp.Location = new Point(379, 10);
            lblNoHp.Name = "lblNoHp";
            lblNoHp.Size = new Size(60, 25);
            lblNoHp.TabIndex = 3;
            lblNoHp.Text = "NoHp";
            // 
            // lblAlamat
            // 
            lblAlamat.AutoSize = true;
            lblAlamat.Location = new Point(529, 13);
            lblAlamat.Name = "lblAlamat";
            lblAlamat.Size = new Size(68, 25);
            lblAlamat.TabIndex = 4;
            lblAlamat.Text = "Alamat";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(689, 11);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(49, 25);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Total";
            // 
            // UCDataUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblTotal);
            Controls.Add(lblAlamat);
            Controls.Add(lblNoHp);
            Controls.Add(lblEmail);
            Controls.Add(lblUsername);
            Controls.Add(lblNama);
            Name = "UCDataUser";
            Size = new Size(1191, 50);
            Load += UCDataUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNama;
        private Label lblUsername;
        private Label lblEmail;
        private Label lblNoHp;
        private Label lblAlamat;
        private Label lblTotal;
    }
}
