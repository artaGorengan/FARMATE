namespace FARMATE.Views.Admin
{
    partial class FormDataUser
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
            panelNavbar = new Panel();
            btnLogout = new Button();
            btnDataUser = new Button();
            btnRiwayat = new Button();
            btnKelolaAlat = new Button();
            panelHeader = new Panel();
            lblsubjudul = new Label();
            lblUIser = new Label();
            panelContainer = new Panel();
            flowUser = new FlowLayoutPanel();
            panelKolom = new Panel();
            lblTotalSewa = new Label();
            lblAlamat = new Label();
            lblNoHp = new Label();
            lblEmail = new Label();
            lblUsername = new Label();
            lblNama = new Label();
            panelNavbar.SuspendLayout();
            panelHeader.SuspendLayout();
            panelContainer.SuspendLayout();
            panelKolom.SuspendLayout();
            SuspendLayout();
            // 
            // panelNavbar
            // 
            panelNavbar.BackColor = Color.Green;
            panelNavbar.Controls.Add(btnLogout);
            panelNavbar.Controls.Add(btnDataUser);
            panelNavbar.Controls.Add(btnRiwayat);
            panelNavbar.Controls.Add(btnKelolaAlat);
            panelNavbar.Location = new Point(0, -1);
            panelNavbar.Name = "panelNavbar";
            panelNavbar.Size = new Size(800, 58);
            panelNavbar.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(658, 15);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(112, 34);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout\r\n";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnDataUser
            // 
            btnDataUser.Location = new Point(466, 13);
            btnDataUser.Name = "btnDataUser";
            btnDataUser.Size = new Size(112, 34);
            btnDataUser.TabIndex = 2;
            btnDataUser.Text = "Data User\r\n";
            btnDataUser.UseVisualStyleBackColor = true;
            btnDataUser.Click += btnDataUser_Click;
            // 
            // btnRiwayat
            // 
            btnRiwayat.Location = new Point(256, 13);
            btnRiwayat.Name = "btnRiwayat";
            btnRiwayat.Size = new Size(112, 34);
            btnRiwayat.TabIndex = 1;
            btnRiwayat.Text = "Riwayat";
            btnRiwayat.UseVisualStyleBackColor = true;
            btnRiwayat.Click += btnRiwayat_Click;
            // 
            // btnKelolaAlat
            // 
            btnKelolaAlat.Location = new Point(44, 13);
            btnKelolaAlat.Name = "btnKelolaAlat";
            btnKelolaAlat.Size = new Size(112, 34);
            btnKelolaAlat.TabIndex = 0;
            btnKelolaAlat.Text = "Kelola Alat\r\n";
            btnKelolaAlat.UseVisualStyleBackColor = true;
            btnKelolaAlat.Click += btnKelolaAlat_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.Bisque;
            panelHeader.Controls.Add(lblsubjudul);
            panelHeader.Controls.Add(lblUIser);
            panelHeader.Location = new Point(0, 56);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(800, 57);
            panelHeader.TabIndex = 1;
            // 
            // lblsubjudul
            // 
            lblsubjudul.AutoSize = true;
            lblsubjudul.Location = new Point(12, 26);
            lblsubjudul.Name = "lblsubjudul";
            lblsubjudul.Size = new Size(241, 25);
            lblsubjudul.TabIndex = 1;
            lblsubjudul.Text = "Lihat Data Customer Farmate";
            // 
            // lblUIser
            // 
            lblUIser.AutoSize = true;
            lblUIser.Location = new Point(12, 4);
            lblUIser.Name = "lblUIser";
            lblUIser.Size = new Size(89, 25);
            lblUIser.TabIndex = 0;
            lblUIser.Text = "Data User";
            // 
            // panelContainer
            // 
            panelContainer.Controls.Add(flowUser);
            panelContainer.Controls.Add(panelKolom);
            panelContainer.Location = new Point(0, 110);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(800, 339);
            panelContainer.TabIndex = 2;
            // 
            // flowUser
            // 
            flowUser.AutoScroll = true;
            flowUser.FlowDirection = FlowDirection.TopDown;
            flowUser.Location = new Point(0, 47);
            flowUser.Name = "flowUser";
            flowUser.Size = new Size(800, 292);
            flowUser.TabIndex = 1;
            flowUser.WrapContents = false;
            // 
            // panelKolom
            // 
            panelKolom.BackColor = SystemColors.ActiveCaption;
            panelKolom.Controls.Add(lblTotalSewa);
            panelKolom.Controls.Add(lblAlamat);
            panelKolom.Controls.Add(lblNoHp);
            panelKolom.Controls.Add(lblEmail);
            panelKolom.Controls.Add(lblUsername);
            panelKolom.Controls.Add(lblNama);
            panelKolom.Location = new Point(0, 0);
            panelKolom.Name = "panelKolom";
            panelKolom.Size = new Size(800, 50);
            panelKolom.TabIndex = 0;
            // 
            // lblTotalSewa
            // 
            lblTotalSewa.AutoSize = true;
            lblTotalSewa.Location = new Point(674, 11);
            lblTotalSewa.Name = "lblTotalSewa";
            lblTotalSewa.Size = new Size(95, 25);
            lblTotalSewa.TabIndex = 5;
            lblTotalSewa.Text = "Total Sewa";
            // 
            // lblAlamat
            // 
            lblAlamat.AutoSize = true;
            lblAlamat.Location = new Point(540, 13);
            lblAlamat.Name = "lblAlamat";
            lblAlamat.Size = new Size(68, 25);
            lblAlamat.TabIndex = 4;
            lblAlamat.Text = "Alamat";
            // 
            // lblNoHp
            // 
            lblNoHp.AutoSize = true;
            lblNoHp.Location = new Point(416, 11);
            lblNoHp.Name = "lblNoHp";
            lblNoHp.Size = new Size(64, 25);
            lblNoHp.TabIndex = 3;
            lblNoHp.Text = "No HP";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(296, 11);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 25);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(141, 13);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(91, 25);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Location = new Point(25, 13);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(59, 25);
            lblNama.TabIndex = 0;
            lblNama.Text = "Nama";
            // 
            // FormDataUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelContainer);
            Controls.Add(panelHeader);
            Controls.Add(panelNavbar);
            Name = "FormDataUser";
            Text = "FormDataUser";
            Load += FormDataUser_Load;
            panelNavbar.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelContainer.ResumeLayout(false);
            panelKolom.ResumeLayout(false);
            panelKolom.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNavbar;
        private Panel panelHeader;
        private Panel panelContainer;
        private FlowLayoutPanel flowUser;
        private Panel panelKolom;
        private Label lblNama;
        private Label lblUIser;
        private Label lblTotalSewa;
        private Label lblAlamat;
        private Label lblNoHp;
        private Label lblEmail;
        private Label lblUsername;
        private Label lblsubjudul;
        private Button btnKelolaAlat;
        private Button btnDataUser;
        private Button btnRiwayat;
        private Button btnLogout;
    }
}