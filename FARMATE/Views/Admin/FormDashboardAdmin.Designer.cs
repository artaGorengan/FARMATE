namespace FARMATE.Views.Admin
{
    partial class FormDashboardAdmin
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
            btnKelolaAlat = new Button();
            btnDataUser = new Button();
            btnRiwayatPengembalian = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // btnKelolaAlat
            // 
            btnKelolaAlat.Location = new Point(159, 239);
            btnKelolaAlat.Name = "btnKelolaAlat";
            btnKelolaAlat.Size = new Size(112, 34);
            btnKelolaAlat.TabIndex = 0;
            btnKelolaAlat.Text = "Kelola Alat";
            btnKelolaAlat.UseVisualStyleBackColor = true;
            btnKelolaAlat.Click += btnKelolaAlat_Click;
            // 
            // btnDataUser
            // 
            btnDataUser.Location = new Point(432, 249);
            btnDataUser.Name = "btnDataUser";
            btnDataUser.Size = new Size(112, 34);
            btnDataUser.TabIndex = 1;
            btnDataUser.Text = "Data User";
            btnDataUser.UseVisualStyleBackColor = true;
            btnDataUser.Click += btnDataUser_Click;
            // 
            // btnRiwayatPengembalian
            // 
            btnRiwayatPengembalian.Location = new Point(245, 304);
            btnRiwayatPengembalian.Name = "btnRiwayatPengembalian";
            btnRiwayatPengembalian.Size = new Size(197, 34);
            btnRiwayatPengembalian.TabIndex = 2;
            btnRiwayatPengembalian.Text = "Riwayat Pengembalian";
            btnRiwayatPengembalian.UseVisualStyleBackColor = true;
            btnRiwayatPengembalian.Click += btnRiwayatPengembalian_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(294, 365);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(112, 34);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // FormDashboardAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogout);
            Controls.Add(btnRiwayatPengembalian);
            Controls.Add(btnDataUser);
            Controls.Add(btnKelolaAlat);
            Name = "FormDashboardAdmin";
            Text = "FormDashboardAdmin";
            ResumeLayout(false);
        }

        #endregion

        private Button btnKelolaAlat;
        private Button btnDataUser;
        private Button btnRiwayatPengembalian;
        private Button btnLogout;
    }
}