namespace FARMATE.Views.User
{
    partial class FormDetailAlat
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
            btnRiwayat = new Button();
            btnDaftarAlat = new Button();
            pbFoto = new PictureBox();
            lblMerk = new Label();
            lblHarga = new Label();
            lblKategori = new Label();
            lblBBM = new Label();
            rtbDeskripsi = new RichTextBox();
            panelSewa = new Panel();
            lblTotalHarga = new Label();
            btnSewa = new Button();
            lblTotalText = new Label();
            btnPlus = new Button();
            lblHari = new Label();
            btnMinus = new Button();
            lblDurasi = new Label();
            dtpMulai = new DateTimePicker();
            lblMulai = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblStok = new Label();
            label = new Label();
            panelNavbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbFoto).BeginInit();
            panelSewa.SuspendLayout();
            SuspendLayout();
            // 
            // panelNavbar
            // 
            panelNavbar.Controls.Add(btnLogout);
            panelNavbar.Controls.Add(btnRiwayat);
            panelNavbar.Controls.Add(btnDaftarAlat);
            panelNavbar.Dock = DockStyle.Top;
            panelNavbar.Location = new Point(0, 0);
            panelNavbar.Name = "panelNavbar";
            panelNavbar.Size = new Size(1178, 71);
            panelNavbar.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(1042, 17);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(112, 34);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnRiwayat
            // 
            btnRiwayat.Location = new Point(637, 15);
            btnRiwayat.Name = "btnRiwayat";
            btnRiwayat.Size = new Size(112, 34);
            btnRiwayat.TabIndex = 1;
            btnRiwayat.Text = "Riwayat";
            btnRiwayat.UseVisualStyleBackColor = true;
            btnRiwayat.Click += btnRiwayat_Click;
            // 
            // btnDaftarAlat
            // 
            btnDaftarAlat.Location = new Point(507, 15);
            btnDaftarAlat.Name = "btnDaftarAlat";
            btnDaftarAlat.Size = new Size(112, 34);
            btnDaftarAlat.TabIndex = 0;
            btnDaftarAlat.Text = "Daftar Alat";
            btnDaftarAlat.UseVisualStyleBackColor = true;
            btnDaftarAlat.Click += btnDaftarAlat_Click;
            // 
            // pbFoto
            // 
            pbFoto.Location = new Point(12, 88);
            pbFoto.Name = "pbFoto";
            pbFoto.Size = new Size(500, 300);
            pbFoto.SizeMode = PictureBoxSizeMode.Zoom;
            pbFoto.TabIndex = 1;
            pbFoto.TabStop = false;
            // 
            // lblMerk
            // 
            lblMerk.AutoSize = true;
            lblMerk.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMerk.Location = new Point(530, 88);
            lblMerk.Name = "lblMerk";
            lblMerk.Size = new Size(107, 48);
            lblMerk.TabIndex = 2;
            lblMerk.Text = "Merk";
            // 
            // lblHarga
            // 
            lblHarga.AutoSize = true;
            lblHarga.Location = new Point(625, 151);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(60, 25);
            lblHarga.TabIndex = 3;
            lblHarga.Text = "Harga";
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.Location = new Point(625, 189);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(78, 25);
            lblKategori.TabIndex = 4;
            lblKategori.Text = "Kategori";
            // 
            // lblBBM
            // 
            lblBBM.AutoSize = true;
            lblBBM.Location = new Point(625, 225);
            lblBBM.Name = "lblBBM";
            lblBBM.Size = new Size(48, 25);
            lblBBM.TabIndex = 5;
            lblBBM.Text = "BBM";
            // 
            // rtbDeskripsi
            // 
            rtbDeskripsi.Location = new Point(541, 268);
            rtbDeskripsi.Name = "rtbDeskripsi";
            rtbDeskripsi.ReadOnly = true;
            rtbDeskripsi.Size = new Size(625, 120);
            rtbDeskripsi.TabIndex = 6;
            rtbDeskripsi.Text = "";
            // 
            // panelSewa
            // 
            panelSewa.Controls.Add(lblTotalHarga);
            panelSewa.Controls.Add(btnSewa);
            panelSewa.Controls.Add(lblTotalText);
            panelSewa.Controls.Add(btnPlus);
            panelSewa.Controls.Add(lblHari);
            panelSewa.Controls.Add(btnMinus);
            panelSewa.Controls.Add(lblDurasi);
            panelSewa.Controls.Add(dtpMulai);
            panelSewa.Controls.Add(lblMulai);
            panelSewa.Location = new Point(541, 408);
            panelSewa.Name = "panelSewa";
            panelSewa.Size = new Size(625, 224);
            panelSewa.TabIndex = 7;
            // 
            // lblTotalHarga
            // 
            lblTotalHarga.AutoSize = true;
            lblTotalHarga.Location = new Point(477, 34);
            lblTotalHarga.Name = "lblTotalHarga";
            lblTotalHarga.Size = new Size(107, 25);
            lblTotalHarga.TabIndex = 8;
            lblTotalHarga.Text = "Rp. 900.000";
            // 
            // btnSewa
            // 
            btnSewa.Location = new Point(398, 103);
            btnSewa.Name = "btnSewa";
            btnSewa.Size = new Size(175, 34);
            btnSewa.TabIndex = 7;
            btnSewa.Text = "Sewa Sekarang";
            btnSewa.UseVisualStyleBackColor = true;
            btnSewa.Click += btnSewa_Click;
            // 
            // lblTotalText
            // 
            lblTotalText.AutoSize = true;
            lblTotalText.Location = new Point(422, 34);
            lblTotalText.Name = "lblTotalText";
            lblTotalText.Size = new Size(49, 25);
            lblTotalText.TabIndex = 6;
            lblTotalText.Text = "Total";
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(124, 169);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(33, 34);
            btnPlus.TabIndex = 5;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // lblHari
            // 
            lblHari.AutoSize = true;
            lblHari.Location = new Point(96, 174);
            lblHari.Name = "lblHari";
            lblHari.Size = new Size(22, 25);
            lblHari.TabIndex = 4;
            lblHari.Text = "1";
            // 
            // btnMinus
            // 
            btnMinus.Location = new Point(36, 169);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(42, 34);
            btnMinus.TabIndex = 3;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // lblDurasi
            // 
            lblDurasi.AutoSize = true;
            lblDurasi.Location = new Point(36, 131);
            lblDurasi.Name = "lblDurasi";
            lblDurasi.Size = new Size(108, 25);
            lblDurasi.TabIndex = 2;
            lblDurasi.Text = "Durasi Sewa";
            // 
            // dtpMulai
            // 
            dtpMulai.Location = new Point(28, 78);
            dtpMulai.Name = "dtpMulai";
            dtpMulai.Size = new Size(300, 31);
            dtpMulai.TabIndex = 1;
            // 
            // lblMulai
            // 
            lblMulai.AutoSize = true;
            lblMulai.Location = new Point(23, 34);
            lblMulai.Name = "lblMulai";
            lblMulai.Size = new Size(121, 25);
            lblMulai.TabIndex = 0;
            lblMulai.Text = "Tanggal Mulai";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(541, 151);
            label1.Name = "label1";
            label1.Size = new Size(60, 25);
            label1.TabIndex = 8;
            label1.Text = "Harga";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(541, 189);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 9;
            label2.Text = "Kategori";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(553, 225);
            label3.Name = "label3";
            label3.Size = new Size(48, 25);
            label3.TabIndex = 10;
            label3.Text = "BBM";
            // 
            // lblStok
            // 
            lblStok.AutoSize = true;
            lblStok.Location = new Point(119, 452);
            lblStok.Name = "lblStok";
            lblStok.Size = new Size(47, 25);
            lblStok.TabIndex = 13;
            lblStok.Text = "Stok";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(66, 452);
            label.Name = "label";
            label.Size = new Size(47, 25);
            label.TabIndex = 14;
            label.Text = "Stok";
            // 
            // FormDetailAlat
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 644);
            Controls.Add(label);
            Controls.Add(lblStok);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panelSewa);
            Controls.Add(rtbDeskripsi);
            Controls.Add(lblBBM);
            Controls.Add(lblKategori);
            Controls.Add(lblHarga);
            Controls.Add(lblMerk);
            Controls.Add(pbFoto);
            Controls.Add(panelNavbar);
            Name = "FormDetailAlat";
            Text = "FormDetailAlat";
            Load += FormDetailAlat_Load;
            panelNavbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbFoto).EndInit();
            panelSewa.ResumeLayout(false);
            panelSewa.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelNavbar;
        private PictureBox pbFoto;
        private Label lblMerk;
        private Label lblHarga;
        private Label lblKategori;
        private Label lblBBM;
        private RichTextBox rtbDeskripsi;
        private Panel panelSewa;
        private DateTimePicker dtpMulai;
        private Label lblMulai;
        private Button btnSewa;
        private Label lblTotalText;
        private Button btnPlus;
        private Label lblHari;
        private Button btnMinus;
        private Label lblDurasi;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblTotalHarga;
        private Button btnLogout;
        private Button btnRiwayat;
        private Button btnDaftarAlat;
        private Label lblStok;
        private Label label;
    }
}