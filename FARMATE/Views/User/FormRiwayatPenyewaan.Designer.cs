namespace FARMATE.Views.User
{
    partial class FormRiwayatPenyewaan
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
            panel1 = new Panel();
            lblLogout = new Label();
            lblRiwayat = new Label();
            lblDaftarAlat = new Label();
            panel2 = new Panel();
            cmbKategori = new ComboBox();
            lblSubjudul = new Label();
            lblJudul = new Label();
            panelStatistik = new Panel();
            panel6 = new Panel();
            lblTerlambat = new Label();
            label4 = new Label();
            panel5 = new Panel();
            lblSelesai = new Label();
            label3 = new Label();
            panel4 = new Panel();
            lblSedangDisewa = new Label();
            label2 = new Label();
            panel3 = new Panel();
            lblTotalPenyewaan = new Label();
            label1 = new Label();
            panelDaftar = new Panel();
            flowRiwayat = new FlowLayoutPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panelStatistik.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panelDaftar.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblLogout);
            panel1.Controls.Add(lblRiwayat);
            panel1.Controls.Add(lblDaftarAlat);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1251, 71);
            panel1.TabIndex = 0;
            // 
            // lblLogout
            // 
            lblLogout.AutoSize = true;
            lblLogout.Location = new Point(426, 25);
            lblLogout.Name = "lblLogout";
            lblLogout.Size = new Size(69, 25);
            lblLogout.TabIndex = 2;
            lblLogout.Text = "Logout";
            lblLogout.Click += lblLogout_Click;
            // 
            // lblRiwayat
            // 
            lblRiwayat.AutoSize = true;
            lblRiwayat.Location = new Point(265, 28);
            lblRiwayat.Name = "lblRiwayat";
            lblRiwayat.Size = new Size(73, 25);
            lblRiwayat.TabIndex = 1;
            lblRiwayat.Text = "Riwayat";
            lblRiwayat.Click += lblRiwayat_Click;
            // 
            // lblDaftarAlat
            // 
            lblDaftarAlat.AutoSize = true;
            lblDaftarAlat.Location = new Point(62, 24);
            lblDaftarAlat.Name = "lblDaftarAlat";
            lblDaftarAlat.Size = new Size(97, 25);
            lblDaftarAlat.TabIndex = 0;
            lblDaftarAlat.Text = "Daftar Alat";
            lblDaftarAlat.Click += lblDaftarAlat_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(cmbKategori);
            panel2.Controls.Add(lblSubjudul);
            panel2.Controls.Add(lblJudul);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 71);
            panel2.Name = "panel2";
            panel2.Size = new Size(1251, 85);
            panel2.TabIndex = 1;
            // 
            // cmbKategori
            // 
            cmbKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(1047, 33);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(182, 33);
            cmbKategori.TabIndex = 2;
            cmbKategori.SelectedIndexChanged += cmbKategori_SelectedIndexChanged;
            // 
            // lblSubjudul
            // 
            lblSubjudul.AutoSize = true;
            lblSubjudul.Location = new Point(35, 41);
            lblSubjudul.Name = "lblSubjudul";
            lblSubjudul.Size = new Size(172, 25);
            lblSubjudul.TabIndex = 1;
            lblSubjudul.Text = "Lihat seluruh riwayat";
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Location = new Point(28, 8);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(165, 25);
            lblJudul.TabIndex = 0;
            lblJudul.Text = "Riwayat Penyewaan";
            // 
            // panelStatistik
            // 
            panelStatistik.Controls.Add(panel6);
            panelStatistik.Controls.Add(panel5);
            panelStatistik.Controls.Add(panel4);
            panelStatistik.Controls.Add(panel3);
            panelStatistik.Location = new Point(0, 180);
            panelStatistik.Name = "panelStatistik";
            panelStatistik.Size = new Size(1251, 159);
            panelStatistik.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.Controls.Add(lblTerlambat);
            panel6.Controls.Add(label4);
            panel6.Location = new Point(947, 20);
            panel6.Name = "panel6";
            panel6.Size = new Size(252, 117);
            panel6.TabIndex = 1;
            // 
            // lblTerlambat
            // 
            lblTerlambat.AutoSize = true;
            lblTerlambat.Location = new Point(52, 65);
            lblTerlambat.Name = "lblTerlambat";
            lblTerlambat.Size = new Size(59, 25);
            lblTerlambat.TabIndex = 2;
            lblTerlambat.Text = "label5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 23);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 1;
            label4.Text = "Terlambat";
            // 
            // panel5
            // 
            panel5.Controls.Add(lblSelesai);
            panel5.Controls.Add(label3);
            panel5.Location = new Point(627, 20);
            panel5.Name = "panel5";
            panel5.Size = new Size(252, 117);
            panel5.TabIndex = 1;
            // 
            // lblSelesai
            // 
            lblSelesai.AutoSize = true;
            lblSelesai.Location = new Point(34, 65);
            lblSelesai.Name = "lblSelesai";
            lblSelesai.Size = new Size(59, 25);
            lblSelesai.TabIndex = 3;
            lblSelesai.Text = "label5";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 23);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 2;
            label3.Text = "Selesai";
            // 
            // panel4
            // 
            panel4.Controls.Add(lblSedangDisewa);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(316, 20);
            panel4.Name = "panel4";
            panel4.Size = new Size(252, 117);
            panel4.TabIndex = 1;
            // 
            // lblSedangDisewa
            // 
            lblSedangDisewa.AutoSize = true;
            lblSedangDisewa.Location = new Point(18, 65);
            lblSedangDisewa.Name = "lblSedangDisewa";
            lblSedangDisewa.Size = new Size(59, 25);
            lblSedangDisewa.TabIndex = 2;
            lblSedangDisewa.Text = "label5";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ImageAlign = ContentAlignment.MiddleRight;
            label2.Location = new Point(18, 23);
            label2.Name = "label2";
            label2.Size = new Size(133, 25);
            label2.TabIndex = 1;
            label2.Text = "Sedang Disewa";
            // 
            // panel3
            // 
            panel3.Controls.Add(lblTotalPenyewaan);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(27, 20);
            panel3.Name = "panel3";
            panel3.Size = new Size(252, 117);
            panel3.TabIndex = 0;
            // 
            // lblTotalPenyewaan
            // 
            lblTotalPenyewaan.AutoSize = true;
            lblTotalPenyewaan.Location = new Point(43, 65);
            lblTotalPenyewaan.Name = "lblTotalPenyewaan";
            lblTotalPenyewaan.Size = new Size(59, 25);
            lblTotalPenyewaan.TabIndex = 1;
            lblTotalPenyewaan.Text = "label5";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 9);
            label1.Name = "label1";
            label1.Size = new Size(141, 25);
            label1.TabIndex = 0;
            label1.Text = "Total Penyewaan";
            // 
            // panelDaftar
            // 
            panelDaftar.Controls.Add(flowRiwayat);
            panelDaftar.Location = new Point(0, 345);
            panelDaftar.Name = "panelDaftar";
            panelDaftar.Size = new Size(1251, 325);
            panelDaftar.TabIndex = 3;
            panelDaftar.Paint += panelDaftar_Paint;
            // 
            // flowRiwayat
            // 
            flowRiwayat.AutoScroll = true;
            flowRiwayat.Dock = DockStyle.Bottom;
            flowRiwayat.FlowDirection = FlowDirection.TopDown;
            flowRiwayat.Location = new Point(0, 43);
            flowRiwayat.Name = "flowRiwayat";
            flowRiwayat.Size = new Size(1251, 282);
            flowRiwayat.TabIndex = 0;
            flowRiwayat.WrapContents = false;
            // 
            // FormRiwayatPenyewaan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1251, 669);
            Controls.Add(panelDaftar);
            Controls.Add(panelStatistik);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormRiwayatPenyewaan";
            Text = "FormRiwayat";
            Load += FormRiwayatPenyewaan_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelStatistik.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panelDaftar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblLogout;
        private Label lblRiwayat;
        private Label lblDaftarAlat;
        private Panel panel2;
        private ComboBox cmbKategori;
        private Label lblSubjudul;
        private Label lblJudul;
        private Panel panelStatistik;
        private Panel panelDaftar;
        private FlowLayoutPanel flowRiwayat;
        private Panel panel6;
        private Label label4;
        private Panel panel5;
        private Label lblSelesai;
        private Label label3;
        private Panel panel4;
        private Label lblSedangDisewa;
        private Label label2;
        private Panel panel3;
        private Label lblTotalPenyewaan;
        private Label label1;
        private Label lblTerlambat;
    }
}