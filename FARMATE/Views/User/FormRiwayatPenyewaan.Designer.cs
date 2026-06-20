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
            panelStatistik = new Panel();
            lblTotalPenyewaan = new Label();
            lblSedangDisewa = new Label();
            lblSelesai = new Label();
            lblTerlambat = new Label();
            panelDaftar = new Panel();
            flowRiwayat = new FlowLayoutPanel();
            lblDaftarAlat = new Label();
            lblRiwayat = new Label();
            lblLogout = new Label();
            panel1 = new Panel();
            cmbKategori = new ComboBox();
            panelStatistik.SuspendLayout();
            panelDaftar.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelStatistik
            // 
            panelStatistik.BackColor = Color.Transparent;
            panelStatistik.BackgroundImageLayout = ImageLayout.Center;
            panelStatistik.Controls.Add(lblTotalPenyewaan);
            panelStatistik.Controls.Add(lblSedangDisewa);
            panelStatistik.Controls.Add(lblSelesai);
            panelStatistik.Controls.Add(lblTerlambat);
            panelStatistik.Location = new Point(12, 292);
            panelStatistik.Name = "panelStatistik";
            panelStatistik.Size = new Size(1898, 159);
            panelStatistik.TabIndex = 2;
            // 
            // lblTotalPenyewaan
            // 
            lblTotalPenyewaan.AutoSize = true;
            lblTotalPenyewaan.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalPenyewaan.Location = new Point(294, 91);
            lblTotalPenyewaan.Name = "lblTotalPenyewaan";
            lblTotalPenyewaan.Size = new Size(64, 21);
            lblTotalPenyewaan.TabIndex = 1;
            lblTotalPenyewaan.Text = "label5";
            lblTotalPenyewaan.Click += lblTotalPenyewaan_Click;
            // 
            // lblSedangDisewa
            // 
            lblSedangDisewa.AutoSize = true;
            lblSedangDisewa.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSedangDisewa.Location = new Point(686, 86);
            lblSedangDisewa.Name = "lblSedangDisewa";
            lblSedangDisewa.Size = new Size(64, 21);
            lblSedangDisewa.TabIndex = 2;
            lblSedangDisewa.Text = "label5";
            // 
            // lblSelesai
            // 
            lblSelesai.AutoSize = true;
            lblSelesai.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSelesai.Location = new Point(1084, 85);
            lblSelesai.Name = "lblSelesai";
            lblSelesai.Size = new Size(64, 21);
            lblSelesai.TabIndex = 3;
            lblSelesai.Text = "label5";
            // 
            // lblTerlambat
            // 
            lblTerlambat.AutoSize = true;
            lblTerlambat.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTerlambat.Location = new Point(1463, 86);
            lblTerlambat.Name = "lblTerlambat";
            lblTerlambat.Size = new Size(64, 21);
            lblTerlambat.TabIndex = 2;
            lblTerlambat.Text = "label5";
            // 
            // panelDaftar
            // 
            panelDaftar.BackColor = Color.Transparent;
            panelDaftar.BackgroundImageLayout = ImageLayout.Center;
            panelDaftar.Controls.Add(flowRiwayat);
            panelDaftar.Location = new Point(0, 424);
            panelDaftar.Name = "panelDaftar";
            panelDaftar.Size = new Size(1898, 648);
            panelDaftar.TabIndex = 3;
            panelDaftar.Paint += panelDaftar_Paint;
            // 
            // flowRiwayat
            // 
            flowRiwayat.AutoScroll = true;
            flowRiwayat.BackColor = Color.Transparent;
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
            lblDaftarAlat.BackColor = Color.Transparent;
            lblDaftarAlat.ForeColor = Color.Black;
            lblDaftarAlat.Location = new Point(807, 47);
            lblDaftarAlat.Name = "lblDaftarAlat";
            lblDaftarAlat.Size = new Size(132, 25);
            lblDaftarAlat.TabIndex = 0;
            lblDaftarAlat.Text = "                        ";
            lblDaftarAlat.Click += lblDaftarAlat_Click;
            // 
            // lblRiwayat
            // 
            lblRiwayat.AutoSize = true;
            lblRiwayat.BackColor = Color.Transparent;
            lblRiwayat.Location = new Point(1021, 47);
            lblRiwayat.Name = "lblRiwayat";
            lblRiwayat.Size = new Size(102, 25);
            lblRiwayat.TabIndex = 1;
            lblRiwayat.Text = "                  ";
            lblRiwayat.Click += lblRiwayat_Click;
            // 
            // lblLogout
            // 
            lblLogout.AutoSize = true;
            lblLogout.BackColor = Color.Transparent;
            lblLogout.Location = new Point(1617, 21);
            lblLogout.Name = "lblLogout";
            lblLogout.Size = new Size(252, 75);
            lblLogout.TabIndex = 2;
            lblLogout.Text = "                                                \r\n\r\n\r\n";
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
            // cmbKategori
            // 
            cmbKategori.BackColor = Color.White;
            cmbKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKategori.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbKategori.ForeColor = Color.DarkOliveGreen;
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(1489, 185);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(272, 29);
            cmbKategori.TabIndex = 4;
            // 
            // FormRiwayatPenyewaan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1898, 1024);
            Controls.Add(cmbKategori);
            Controls.Add(panelDaftar);
            Controls.Add(panelStatistik);
            Controls.Add(panel1);
            Name = "FormRiwayatPenyewaan";
            Text = "FormRiwayat";
            Load += FormRiwayatPenyewaan_Load;
            panelStatistik.ResumeLayout(false);
            panelStatistik.PerformLayout();
            panelDaftar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
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
        private ComboBox cmbKategori;
    }
}