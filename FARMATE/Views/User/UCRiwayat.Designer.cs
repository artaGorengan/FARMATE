namespace FARMATE.Views.User
{
    partial class UCRiwayat
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
            lblAlat = new Label();
            lblKategori = new Label();
            lblDurasi = new Label();
            lblTanggalPinjam = new Label();
            lblTanggalKembali = new Label();
            lblDenda = new Label();
            lblStatus = new Label();
            SuspendLayout();
            // 
            // lblAlat
            // 
            lblAlat.AutoSize = true;
            lblAlat.Location = new Point(26, 5);
            lblAlat.Name = "lblAlat";
            lblAlat.Size = new Size(43, 25);
            lblAlat.TabIndex = 0;
            lblAlat.Text = "Alat";
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.Location = new Point(127, 5);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(78, 25);
            lblKategori.TabIndex = 1;
            lblKategori.Text = "Kategori";
            // 
            // lblDurasi
            // 
            lblDurasi.AutoSize = true;
            lblDurasi.Location = new Point(262, 9);
            lblDurasi.Name = "lblDurasi";
            lblDurasi.Size = new Size(62, 25);
            lblDurasi.TabIndex = 2;
            lblDurasi.Text = "Durasi";
            // 
            // lblTanggalPinjam
            // 
            lblTanggalPinjam.AutoSize = true;
            lblTanggalPinjam.Location = new Point(378, 9);
            lblTanggalPinjam.Name = "lblTanggalPinjam";
            lblTanggalPinjam.Size = new Size(131, 25);
            lblTanggalPinjam.TabIndex = 3;
            lblTanggalPinjam.Text = "Tanggal Pinjam";
            // 
            // lblTanggalKembali
            // 
            lblTanggalKembali.AutoSize = true;
            lblTanggalKembali.Location = new Point(596, 9);
            lblTanggalKembali.Name = "lblTanggalKembali";
            lblTanggalKembali.Size = new Size(141, 25);
            lblTanggalKembali.TabIndex = 4;
            lblTanggalKembali.Text = "Tanggal Kembali";
            // 
            // lblDenda
            // 
            lblDenda.AutoSize = true;
            lblDenda.Location = new Point(792, 6);
            lblDenda.Name = "lblDenda";
            lblDenda.Size = new Size(64, 25);
            lblDenda.TabIndex = 5;
            lblDenda.Text = "Denda";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(949, 5);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(60, 25);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "Status";
            // 
            // UCRiwayat
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lblStatus);
            Controls.Add(lblDenda);
            Controls.Add(lblTanggalKembali);
            Controls.Add(lblTanggalPinjam);
            Controls.Add(lblDurasi);
            Controls.Add(lblKategori);
            Controls.Add(lblAlat);
            Name = "UCRiwayat";
            Size = new Size(1079, 42);
            Load += UCRiwayat_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAlat;
        private Label lblKategori;
        private Label lblDurasi;
        private Label lblTanggalPinjam;
        private Label lblTanggalKembali;
        private Label lblDenda;
        private Label lblStatus;
    }
}
