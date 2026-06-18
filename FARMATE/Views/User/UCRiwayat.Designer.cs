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
            lblAlat.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAlat.Location = new Point(26, 8);
            lblAlat.Name = "lblAlat";
            lblAlat.Size = new Size(45, 21);
            lblAlat.TabIndex = 0;
            lblAlat.Text = "Alat";
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKategori.Location = new Point(304, 7);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(86, 21);
            lblKategori.TabIndex = 1;
            lblKategori.Text = "Kategori";
            // 
            // lblDurasi
            // 
            lblDurasi.AutoSize = true;
            lblDurasi.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDurasi.Location = new Point(538, 8);
            lblDurasi.Name = "lblDurasi";
            lblDurasi.Size = new Size(68, 21);
            lblDurasi.TabIndex = 2;
            lblDurasi.Text = "Durasi";
            // 
            // lblTanggalPinjam
            // 
            lblTanggalPinjam.AutoSize = true;
            lblTanggalPinjam.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTanggalPinjam.Location = new Point(861, 8);
            lblTanggalPinjam.Name = "lblTanggalPinjam";
            lblTanggalPinjam.Size = new Size(146, 21);
            lblTanggalPinjam.TabIndex = 3;
            lblTanggalPinjam.Text = "Tanggal Pinjam";
            // 
            // lblTanggalKembali
            // 
            lblTanggalKembali.AutoSize = true;
            lblTanggalKembali.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTanggalKembali.Location = new Point(1139, 8);
            lblTanggalKembali.Name = "lblTanggalKembali";
            lblTanggalKembali.Size = new Size(158, 21);
            lblTanggalKembali.TabIndex = 4;
            lblTanggalKembali.Text = "Tanggal Kembali";
            // 
            // lblDenda
            // 
            lblDenda.AutoSize = true;
            lblDenda.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDenda.Location = new Point(1411, 11);
            lblDenda.Name = "lblDenda";
            lblDenda.Size = new Size(67, 21);
            lblDenda.TabIndex = 5;
            lblDenda.Text = "Denda";
            lblDenda.Click += lblDenda_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(1570, 7);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(66, 21);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "Status";
            // 
            // UCRiwayat
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(lblStatus);
            Controls.Add(lblDenda);
            Controls.Add(lblTanggalKembali);
            Controls.Add(lblTanggalPinjam);
            Controls.Add(lblDurasi);
            Controls.Add(lblKategori);
            Controls.Add(lblAlat);
            Name = "UCRiwayat";
            Size = new Size(1749, 42);
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
