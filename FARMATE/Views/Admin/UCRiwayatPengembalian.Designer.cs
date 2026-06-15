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
            lblNama.Location = new Point(30, 25);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(59, 25);
            lblNama.TabIndex = 0;
            lblNama.Text = "label1";
            // 
            // lblAlat
            // 
            lblAlat.AutoSize = true;
            lblAlat.Location = new Point(153, 22);
            lblAlat.Name = "lblAlat";
            lblAlat.Size = new Size(59, 25);
            lblAlat.TabIndex = 1;
            lblAlat.Text = "label1";
            // 
            // lblDurasi
            // 
            lblDurasi.AutoSize = true;
            lblDurasi.Location = new Point(297, 22);
            lblDurasi.Name = "lblDurasi";
            lblDurasi.Size = new Size(59, 25);
            lblDurasi.TabIndex = 2;
            lblDurasi.Text = "label1";
            // 
            // lblTanggalPinjam
            // 
            lblTanggalPinjam.AutoSize = true;
            lblTanggalPinjam.Location = new Point(496, 25);
            lblTanggalPinjam.Name = "lblTanggalPinjam";
            lblTanggalPinjam.Size = new Size(59, 25);
            lblTanggalPinjam.TabIndex = 3;
            lblTanggalPinjam.Text = "label1";
            // 
            // lblTanggalKembali
            // 
            lblTanggalKembali.AutoSize = true;
            lblTanggalKembali.Location = new Point(775, 25);
            lblTanggalKembali.Name = "lblTanggalKembali";
            lblTanggalKembali.Size = new Size(59, 25);
            lblTanggalKembali.TabIndex = 4;
            lblTanggalKembali.Text = "label1";
            // 
            // lblDenda
            // 
            lblDenda.AutoSize = true;
            lblDenda.Location = new Point(1163, 22);
            lblDenda.Name = "lblDenda";
            lblDenda.Size = new Size(59, 25);
            lblDenda.TabIndex = 5;
            lblDenda.Text = "label1";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(1589, 25);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(59, 25);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "label1";
            // 
            // btnKonfirmasi
            // 
            btnKonfirmasi.Location = new Point(1383, 21);
            btnKonfirmasi.Name = "btnKonfirmasi";
            btnKonfirmasi.Size = new Size(112, 34);
            btnKonfirmasi.TabIndex = 8;
            btnKonfirmasi.Text = "button1";
            btnKonfirmasi.UseVisualStyleBackColor = true;
            btnKonfirmasi.Click += btnKonfirmasi_Click;
            // 
            // UCRiwayatPengembalian
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnKonfirmasi);
            Controls.Add(lblStatus);
            Controls.Add(lblDenda);
            Controls.Add(lblTanggalKembali);
            Controls.Add(lblTanggalPinjam);
            Controls.Add(lblDurasi);
            Controls.Add(lblAlat);
            Controls.Add(lblNama);
            Name = "UCRiwayatPengembalian";
            Size = new Size(1682, 68);
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
