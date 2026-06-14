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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRiwayatPenyewaan));
            panel2 = new Panel();
            cmbKategori = new ComboBox();
            panelStatistik = new Panel();
            lblTerlambat = new Label();
            lblSelesai = new Label();
            lblSedangDisewa = new Label();
            lblTotalPenyewaan = new Label();
            panelDaftar = new Panel();
            flowRiwayat = new FlowLayoutPanel();
            lblDaftarAlat = new Label();
            lblRiwayat = new Label();
            lblLogout = new Label();
            panel1 = new Panel();
            panel2.SuspendLayout();
            panelStatistik.SuspendLayout();
            panelDaftar.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSeaGreen;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Center;
            panel2.Controls.Add(cmbKategori);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 117);
            panel2.Name = "panel2";
            panel2.Size = new Size(1898, 113);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // cmbKategori
            // 
            cmbKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(1498, 40);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(283, 33);
            cmbKategori.TabIndex = 2;
            cmbKategori.SelectedIndexChanged += cmbKategori_SelectedIndexChanged;
            // 
            // panelStatistik
            // 
            panelStatistik.BackColor = Color.DarkSeaGreen;
            panelStatistik.BackgroundImage = (Image)resources.GetObject("panelStatistik.BackgroundImage");
            panelStatistik.BackgroundImageLayout = ImageLayout.Center;
            panelStatistik.Controls.Add(lblTotalPenyewaan);
            panelStatistik.Controls.Add(lblSedangDisewa);
            panelStatistik.Controls.Add(lblSelesai);
            panelStatistik.Controls.Add(lblTerlambat);
            panelStatistik.Location = new Point(0, 228);
            panelStatistik.Name = "panelStatistik";
            panelStatistik.Size = new Size(1898, 159);
            panelStatistik.TabIndex = 2;
            // 
            // lblTerlambat
            // 
            lblTerlambat.AutoSize = true;
            lblTerlambat.Location = new Point(1487, 67);
            lblTerlambat.Name = "lblTerlambat";
            lblTerlambat.Size = new Size(59, 25);
            lblTerlambat.TabIndex = 2;
            lblTerlambat.Text = "label5";
            // 
            // lblSelesai
            // 
            lblSelesai.AutoSize = true;
            lblSelesai.Location = new Point(1109, 67);
            lblSelesai.Name = "lblSelesai";
            lblSelesai.Size = new Size(59, 25);
            lblSelesai.TabIndex = 3;
            lblSelesai.Text = "label5";
            // 
            // lblSedangDisewa
            // 
            lblSedangDisewa.AutoSize = true;
            lblSedangDisewa.Location = new Point(712, 67);
            lblSedangDisewa.Name = "lblSedangDisewa";
            lblSedangDisewa.Size = new Size(59, 25);
            lblSedangDisewa.TabIndex = 2;
            lblSedangDisewa.Text = "label5";
            // 
            // lblTotalPenyewaan
            // 
            lblTotalPenyewaan.AutoSize = true;
            lblTotalPenyewaan.Location = new Point(323, 67);
            lblTotalPenyewaan.Name = "lblTotalPenyewaan";
            lblTotalPenyewaan.Size = new Size(59, 25);
            lblTotalPenyewaan.TabIndex = 1;
            lblTotalPenyewaan.Text = "label5";
            lblTotalPenyewaan.Click += lblTotalPenyewaan_Click;
            // 
            // panelDaftar
            // 
            panelDaftar.BackColor = Color.DarkSeaGreen;
            panelDaftar.BackgroundImage = (Image)resources.GetObject("panelDaftar.BackgroundImage");
            panelDaftar.BackgroundImageLayout = ImageLayout.Center;
            panelDaftar.Controls.Add(flowRiwayat);
            panelDaftar.Location = new Point(0, 388);
            panelDaftar.Name = "panelDaftar";
            panelDaftar.Size = new Size(1898, 642);
            panelDaftar.TabIndex = 3;
            panelDaftar.Paint += panelDaftar_Paint;
            // 
            // flowRiwayat
            // 
            flowRiwayat.AutoScroll = true;
            flowRiwayat.BackColor = Color.Transparent;
            flowRiwayat.BackgroundImage = (Image)resources.GetObject("flowRiwayat.BackgroundImage");
            flowRiwayat.FlowDirection = FlowDirection.TopDown;
            flowRiwayat.Location = new Point(74, 133);
            flowRiwayat.Name = "flowRiwayat";
            flowRiwayat.Size = new Size(1749, 460);
            flowRiwayat.TabIndex = 0;
            flowRiwayat.WrapContents = false;
            flowRiwayat.Paint += flowRiwayat_Paint;
            // 
            // lblDaftarAlat
            // 
            lblDaftarAlat.AutoSize = true;
            lblDaftarAlat.BackColor = Color.LightGray;
            lblDaftarAlat.ForeColor = Color.Black;
            lblDaftarAlat.Location = new Point(807, 47);
            lblDaftarAlat.Name = "lblDaftarAlat";
            lblDaftarAlat.Size = new Size(127, 25);
            lblDaftarAlat.TabIndex = 0;
            lblDaftarAlat.Text = "Daftar Alat      ";
            lblDaftarAlat.Click += lblDaftarAlat_Click;
            // 
            // lblRiwayat
            // 
            lblRiwayat.AutoSize = true;
            lblRiwayat.Location = new Point(1021, 47);
            lblRiwayat.Name = "lblRiwayat";
            lblRiwayat.Size = new Size(88, 25);
            lblRiwayat.TabIndex = 1;
            lblRiwayat.Text = "Riwayat   ";
            lblRiwayat.Click += lblRiwayat_Click;
            // 
            // lblLogout
            // 
            lblLogout.AutoSize = true;
            lblLogout.Location = new Point(1658, 47);
            lblLogout.Name = "lblLogout";
            lblLogout.Size = new Size(184, 25);
            lblLogout.TabIndex = 2;
            lblLogout.Text = "Logout                       ";
            lblLogout.Click += lblLogout_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(lblLogout);
            panel1.Controls.Add(lblRiwayat);
            panel1.Controls.Add(lblDaftarAlat);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1898, 117);
            panel1.TabIndex = 0;
            // 
            // FormRiwayatPenyewaan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1898, 1024);
            Controls.Add(panelDaftar);
            Controls.Add(panelStatistik);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormRiwayatPenyewaan";
            Text = "FormRiwayat";
            Load += FormRiwayatPenyewaan_Load;
            panel2.ResumeLayout(false);
            panelStatistik.ResumeLayout(false);
            panelStatistik.PerformLayout();
            panelDaftar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private ComboBox cmbKategori;
        private Panel panelStatistik;
        private Panel panelDaftar;
        private FlowLayoutPanel flowRiwayat;
        private Label lblSelesai;
        private Label lblSedangDisewa;
        private Label lblTotalPenyewaan;
        private Label lblTerlambat;
        private Label lblDaftarAlat;
        private Label lblRiwayat;
        private Label lblLogout;
        private Panel panel1;
    }
}