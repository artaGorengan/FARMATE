namespace FARMATE.Views.Admin
{
    partial class FormRiwayatPengembalian
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
            label6 = new Label();
            label5 = new Label();
            panelStatistik = new Panel();
            panelTerlambat = new Panel();
            lblTerlambat = new Label();
            label3 = new Label();
            panelSelesai = new Panel();
            lblSelesai = new Label();
            label2 = new Label();
            panelAktif = new Panel();
            lblSedangDisewa = new Label();
            label1 = new Label();
            panelTotal = new Panel();
            lblPenyewaan = new Label();
            label4 = new Label();
            panelContent = new Panel();
            flowRiwayat = new FlowLayoutPanel();
            panelHeaderTabel = new Panel();
            lblStatus = new Label();
            lblDenda = new Label();
            lblTglKembali = new Label();
            lblTglPinjam = new Label();
            lblDurasi = new Label();
            lblAlat = new Label();
            lblNama = new Label();
            panelNavbar.SuspendLayout();
            panelHeader.SuspendLayout();
            panelStatistik.SuspendLayout();
            panelTerlambat.SuspendLayout();
            panelSelesai.SuspendLayout();
            panelAktif.SuspendLayout();
            panelTotal.SuspendLayout();
            panelContent.SuspendLayout();
            panelHeaderTabel.SuspendLayout();
            SuspendLayout();
            // 
            // panelNavbar
            // 
            panelNavbar.BackColor = Color.Green;
            panelNavbar.Controls.Add(btnLogout);
            panelNavbar.Controls.Add(btnDataUser);
            panelNavbar.Controls.Add(btnRiwayat);
            panelNavbar.Controls.Add(btnKelolaAlat);
            panelNavbar.Location = new Point(0, 0);
            panelNavbar.Name = "panelNavbar";
            panelNavbar.Size = new Size(1233, 61);
            panelNavbar.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(1071, 12);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(112, 34);
            btnLogout.TabIndex = 10;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnDataUser
            // 
            btnDataUser.Location = new Point(753, 12);
            btnDataUser.Name = "btnDataUser";
            btnDataUser.Size = new Size(112, 34);
            btnDataUser.TabIndex = 9;
            btnDataUser.Text = "Data User";
            btnDataUser.UseVisualStyleBackColor = true;
            btnDataUser.Click += btnDataUser_Click;
            // 
            // btnRiwayat
            // 
            btnRiwayat.Location = new Point(439, 12);
            btnRiwayat.Name = "btnRiwayat";
            btnRiwayat.Size = new Size(112, 34);
            btnRiwayat.TabIndex = 8;
            btnRiwayat.Text = "Riwayat";
            btnRiwayat.UseVisualStyleBackColor = true;
            btnRiwayat.Click += btnRiwayat_Click;
            // 
            // btnKelolaAlat
            // 
            btnKelolaAlat.BackColor = Color.White;
            btnKelolaAlat.Location = new Point(125, 12);
            btnKelolaAlat.Name = "btnKelolaAlat";
            btnKelolaAlat.Size = new Size(112, 34);
            btnKelolaAlat.TabIndex = 7;
            btnKelolaAlat.Text = "Kelola Alat";
            btnKelolaAlat.UseVisualStyleBackColor = false;
            btnKelolaAlat.Click += btnKelolaAlat_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.Moccasin;
            panelHeader.Controls.Add(label6);
            panelHeader.Controls.Add(label5);
            panelHeader.Location = new Point(0, 59);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1233, 77);
            panelHeader.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 30);
            label6.Name = "label6";
            label6.Size = new Size(515, 25);
            label6.TabIndex = 1;
            label6.Text = "Lihat seluruh riwayat penyewaan alat yang pernah Anda lakukan";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 5);
            label5.Name = "label5";
            label5.Size = new Size(189, 25);
            label5.TabIndex = 0;
            label5.Text = "Riwayat Pengembalian";
            // 
            // panelStatistik
            // 
            panelStatistik.Controls.Add(panelTerlambat);
            panelStatistik.Controls.Add(panelSelesai);
            panelStatistik.Controls.Add(panelAktif);
            panelStatistik.Controls.Add(panelTotal);
            panelStatistik.Location = new Point(0, 133);
            panelStatistik.Name = "panelStatistik";
            panelStatistik.Size = new Size(1233, 142);
            panelStatistik.TabIndex = 2;
            panelStatistik.Paint += panelStatistik_Paint;
            // 
            // panelTerlambat
            // 
            panelTerlambat.Controls.Add(lblTerlambat);
            panelTerlambat.Controls.Add(label3);
            panelTerlambat.Location = new Point(1017, 9);
            panelTerlambat.Name = "panelTerlambat";
            panelTerlambat.Size = new Size(166, 126);
            panelTerlambat.TabIndex = 7;
            // 
            // lblTerlambat
            // 
            lblTerlambat.AutoSize = true;
            lblTerlambat.Location = new Point(60, 71);
            lblTerlambat.Name = "lblTerlambat";
            lblTerlambat.Size = new Size(22, 25);
            lblTerlambat.TabIndex = 1;
            lblTerlambat.Text = "0";
            lblTerlambat.Click += lblTerlambat_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 12);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 0;
            label3.Text = "Terlambat";
            // 
            // panelSelesai
            // 
            panelSelesai.Controls.Add(lblSelesai);
            panelSelesai.Controls.Add(label2);
            panelSelesai.Location = new Point(723, 9);
            panelSelesai.Name = "panelSelesai";
            panelSelesai.Size = new Size(166, 126);
            panelSelesai.TabIndex = 6;
            // 
            // lblSelesai
            // 
            lblSelesai.AutoSize = true;
            lblSelesai.Location = new Point(67, 71);
            lblSelesai.Name = "lblSelesai";
            lblSelesai.Size = new Size(22, 25);
            lblSelesai.TabIndex = 1;
            lblSelesai.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 12);
            label2.Name = "label2";
            label2.Size = new Size(65, 25);
            label2.TabIndex = 0;
            label2.Text = "Selesai";
            // 
            // panelAktif
            // 
            panelAktif.Controls.Add(lblSedangDisewa);
            panelAktif.Controls.Add(label1);
            panelAktif.Location = new Point(384, 9);
            panelAktif.Name = "panelAktif";
            panelAktif.Size = new Size(166, 126);
            panelAktif.TabIndex = 5;
            // 
            // lblSedangDisewa
            // 
            lblSedangDisewa.AutoSize = true;
            lblSedangDisewa.Location = new Point(78, 71);
            lblSedangDisewa.Name = "lblSedangDisewa";
            lblSedangDisewa.Size = new Size(22, 25);
            lblSedangDisewa.TabIndex = 1;
            lblSedangDisewa.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 12);
            label1.Name = "label1";
            label1.Size = new Size(133, 25);
            label1.TabIndex = 0;
            label1.Text = "Sedang Disewa";
            // 
            // panelTotal
            // 
            panelTotal.Controls.Add(lblPenyewaan);
            panelTotal.Controls.Add(label4);
            panelTotal.Location = new Point(71, 9);
            panelTotal.Name = "panelTotal";
            panelTotal.Size = new Size(166, 126);
            panelTotal.TabIndex = 4;
            // 
            // lblPenyewaan
            // 
            lblPenyewaan.AutoSize = true;
            lblPenyewaan.Location = new Point(68, 71);
            lblPenyewaan.Name = "lblPenyewaan";
            lblPenyewaan.Size = new Size(22, 25);
            lblPenyewaan.TabIndex = 1;
            lblPenyewaan.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 12);
            label4.Name = "label4";
            label4.Size = new Size(141, 25);
            label4.TabIndex = 0;
            label4.Text = "Total Penyewaan";
            // 
            // panelContent
            // 
            panelContent.BackColor = SystemColors.Window;
            panelContent.Controls.Add(flowRiwayat);
            panelContent.Controls.Add(panelHeaderTabel);
            panelContent.Controls.Add(panelStatistik);
            panelContent.Controls.Add(panelHeader);
            panelContent.Controls.Add(panelNavbar);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1233, 683);
            panelContent.TabIndex = 1;
            // 
            // flowRiwayat
            // 
            flowRiwayat.AutoScroll = true;
            flowRiwayat.FlowDirection = FlowDirection.TopDown;
            flowRiwayat.Location = new Point(0, 314);
            flowRiwayat.Name = "flowRiwayat";
            flowRiwayat.Size = new Size(1233, 369);
            flowRiwayat.TabIndex = 4;
            flowRiwayat.WrapContents = false;
            flowRiwayat.Paint += flowRiwayat_Paint;
            // 
            // panelHeaderTabel
            // 
            panelHeaderTabel.BackColor = SystemColors.InactiveBorder;
            panelHeaderTabel.Controls.Add(lblStatus);
            panelHeaderTabel.Controls.Add(lblDenda);
            panelHeaderTabel.Controls.Add(lblTglKembali);
            panelHeaderTabel.Controls.Add(lblTglPinjam);
            panelHeaderTabel.Controls.Add(lblDurasi);
            panelHeaderTabel.Controls.Add(lblAlat);
            panelHeaderTabel.Controls.Add(lblNama);
            panelHeaderTabel.Location = new Point(0, 274);
            panelHeaderTabel.Name = "panelHeaderTabel";
            panelHeaderTabel.Size = new Size(1233, 44);
            panelHeaderTabel.TabIndex = 3;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(1048, 8);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(60, 25);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "Status";
            // 
            // lblDenda
            // 
            lblDenda.AutoSize = true;
            lblDenda.Location = new Point(847, 8);
            lblDenda.Name = "lblDenda";
            lblDenda.Size = new Size(64, 25);
            lblDenda.TabIndex = 5;
            lblDenda.Text = "Denda";
            // 
            // lblTglKembali
            // 
            lblTglKembali.AutoSize = true;
            lblTglKembali.Location = new Point(638, 4);
            lblTglKembali.Name = "lblTglKembali";
            lblTglKembali.Size = new Size(141, 25);
            lblTglKembali.TabIndex = 4;
            lblTglKembali.Text = "Tanggal Kembali";
            // 
            // lblTglPinjam
            // 
            lblTglPinjam.AutoSize = true;
            lblTglPinjam.Location = new Point(439, 9);
            lblTglPinjam.Name = "lblTglPinjam";
            lblTglPinjam.Size = new Size(131, 25);
            lblTglPinjam.TabIndex = 3;
            lblTglPinjam.Text = "Tanggal Pinjam";
            // 
            // lblDurasi
            // 
            lblDurasi.AutoSize = true;
            lblDurasi.Location = new Point(296, 10);
            lblDurasi.Name = "lblDurasi";
            lblDurasi.Size = new Size(62, 25);
            lblDurasi.TabIndex = 2;
            lblDurasi.Text = "Durasi";
            // 
            // lblAlat
            // 
            lblAlat.AutoSize = true;
            lblAlat.Location = new Point(171, 8);
            lblAlat.Name = "lblAlat";
            lblAlat.Size = new Size(43, 25);
            lblAlat.TabIndex = 1;
            lblAlat.Text = "Alat";
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Location = new Point(31, 8);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(59, 25);
            lblNama.TabIndex = 0;
            lblNama.Text = "Nama";
            // 
            // FormRiwayatPengembalian
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1233, 683);
            Controls.Add(panelContent);
            Name = "FormRiwayatPengembalian";
            Text = "FormRiwayatPengembalian";
            Load += FormRiwayatPengembalian_Load;
            panelNavbar.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelStatistik.ResumeLayout(false);
            panelTerlambat.ResumeLayout(false);
            panelTerlambat.PerformLayout();
            panelSelesai.ResumeLayout(false);
            panelSelesai.PerformLayout();
            panelAktif.ResumeLayout(false);
            panelAktif.PerformLayout();
            panelTotal.ResumeLayout(false);
            panelTotal.PerformLayout();
            panelContent.ResumeLayout(false);
            panelHeaderTabel.ResumeLayout(false);
            panelHeaderTabel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNavbar;
        private Panel panelHeader;
        private Panel panelStatistik;
        private Panel panelContent;
        private Panel panelHeaderTabel;
        private Label lblTglPinjam;
        private Label lblDurasi;
        private Label lblAlat;
        private Label lblNama;
        private Label lblStatus;
        private Label lblDenda;
        private Label lblTglKembali;
        private FlowLayoutPanel flowRiwayat;
        private Panel panelTerlambat;
        private Panel panelSelesai;
        private Panel panelAktif;
        private Panel panelTotal;
        private Label label4;
        private Label label1;
        private Label lblPenyewaan;
        private Label lblTerlambat;
        private Label label3;
        private Label lblSelesai;
        private Label label2;
        private Label lblSedangDisewa;
        private Button btnDataUser;
        private Button btnRiwayat;
        private Button btnKelolaAlat;
        private Button btnLogout;
        private Label label5;
        private Label label6;
    }
}