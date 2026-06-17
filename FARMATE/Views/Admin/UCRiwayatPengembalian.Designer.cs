namespace FARMATE.Views.Admin
{
    partial class UCRiwayatPengembalian
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
            lblAlat = new Label();
            lblDurasi = new Label();
            lblTanggalPinjam = new Label();
            lblTanggalKembali = new Label();
            lblDenda = new Label();
            lblStatus = new Label();
            btnKonfirmasi = new Button();
            SuspendLayout();
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNama.ForeColor = Color.Ivory;
            lblNama.Location = new Point(23, 15);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(63, 25);
            lblNama.TabIndex = 0;
            lblNama.Text = "label1";
            // 
            // lblAlat
            // 
            lblAlat.AutoSize = true;
            lblAlat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAlat.ForeColor = Color.Ivory;
            lblAlat.Location = new Point(214, 15);
            lblAlat.Name = "lblAlat";
            lblAlat.Size = new Size(63, 25);
            lblAlat.TabIndex = 1;
            lblAlat.Text = "label1";
            // 
            // lblDurasi
            // 
            lblDurasi.AutoSize = true;
            lblDurasi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDurasi.ForeColor = Color.Ivory;
            lblDurasi.Location = new Point(482, 15);
            lblDurasi.Name = "lblDurasi";
            lblDurasi.Size = new Size(63, 25);
            lblDurasi.TabIndex = 2;
            lblDurasi.Text = "label1";
            // 
            // lblTanggalPinjam
            // 
            lblTanggalPinjam.AutoSize = true;
            lblTanggalPinjam.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTanggalPinjam.ForeColor = Color.Ivory;
            lblTanggalPinjam.Location = new Point(664, 15);
            lblTanggalPinjam.Name = "lblTanggalPinjam";
            lblTanggalPinjam.Size = new Size(63, 25);
            lblTanggalPinjam.TabIndex = 3;
            lblTanggalPinjam.Text = "label1";
            lblTanggalPinjam.Click += lblTanggalPinjam_Click;
            // 
            // lblTanggalKembali
            // 
            lblTanggalKembali.AutoSize = true;
            lblTanggalKembali.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTanggalKembali.ForeColor = Color.Ivory;
            lblTanggalKembali.Location = new Point(883, 15);
            lblTanggalKembali.Name = "lblTanggalKembali";
            lblTanggalKembali.Size = new Size(63, 25);
            lblTanggalKembali.TabIndex = 4;
            lblTanggalKembali.Text = "label1";
            // 
            // lblDenda
            // 
            lblDenda.AutoSize = true;
            lblDenda.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDenda.ForeColor = Color.Ivory;
            lblDenda.Location = new Point(1121, 15);
            lblDenda.Name = "lblDenda";
            lblDenda.Size = new Size(63, 25);
            lblDenda.TabIndex = 5;
            lblDenda.Text = "label1";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.Ivory;
            lblStatus.Location = new Point(1539, 15);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(63, 25);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "label1";
            // 
            // btnKonfirmasi
            // 
            btnKonfirmasi.BackColor = Color.Transparent;
            btnKonfirmasi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKonfirmasi.ForeColor = Color.DarkOliveGreen;
            btnKonfirmasi.Location = new Point(1296, 10);
            btnKonfirmasi.Name = "btnKonfirmasi";
            btnKonfirmasi.Size = new Size(112, 34);
            btnKonfirmasi.TabIndex = 8;
            btnKonfirmasi.Text = "Konfirmasi";
            btnKonfirmasi.UseVisualStyleBackColor = false;
            btnKonfirmasi.Click += btnKonfirmasi_Click;
            // 
            // UCRiwayatPengembalian
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(btnKonfirmasi);
            Controls.Add(lblStatus);
            Controls.Add(lblDenda);
            Controls.Add(lblTanggalKembali);
            Controls.Add(lblTanggalPinjam);
            Controls.Add(lblDurasi);
            Controls.Add(lblAlat);
            Controls.Add(lblNama);
            Name = "UCRiwayatPengembalian";
            Size = new Size(1683, 60);
            Load += UCRiwayatPengembalian_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNama;
        private Label lblAlat;
        private Label lblDurasi;
        private Label lblTanggalPinjam;
        private Label lblTanggalKembali;
        private Label lblDenda;
        private Label lblStatus;
        private Button btnKonfirmasi;
    }
}
