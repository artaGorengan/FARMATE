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
            lblNama.Font = new Font("Bookman Old Style", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNama.ForeColor = Color.Ivory;
            lblNama.Location = new Point(98, 10);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(61, 21);
            lblNama.TabIndex = 0;
            lblNama.Text = "Nama";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Bookman Old Style", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.Ivory;
            lblUsername.Location = new Point(408, 10);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(100, 21);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Bookman Old Style", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.Ivory;
            lblEmail.Location = new Point(620, 10);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(64, 21);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email";
            // 
            // lblNoHp
            // 
            lblNoHp.AutoSize = true;
            lblNoHp.Font = new Font("Bookman Old Style", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNoHp.ForeColor = Color.Ivory;
            lblNoHp.Location = new Point(903, 10);
            lblNoHp.Name = "lblNoHp";
            lblNoHp.Size = new Size(60, 21);
            lblNoHp.TabIndex = 3;
            lblNoHp.Text = "NoHp";
            // 
            // lblAlamat
            // 
            lblAlamat.AutoSize = true;
            lblAlamat.Font = new Font("Bookman Old Style", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAlamat.ForeColor = Color.Ivory;
            lblAlamat.Location = new Point(1239, 10);
            lblAlamat.Name = "lblAlamat";
            lblAlamat.Size = new Size(75, 21);
            lblAlamat.TabIndex = 4;
            lblAlamat.Text = "Alamat";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Bookman Old Style", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.Ivory;
            lblTotal.Location = new Point(1564, 10);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(58, 21);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Total";
            // 
            // UCDataUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(lblTotal);
            Controls.Add(lblAlamat);
            Controls.Add(lblNoHp);
            Controls.Add(lblEmail);
            Controls.Add(lblUsername);
            Controls.Add(lblNama);
            Name = "UCDataUser";
            Size = new Size(1676, 50);
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
