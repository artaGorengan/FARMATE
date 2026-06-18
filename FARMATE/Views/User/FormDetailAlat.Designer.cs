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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetailAlat));
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
            lblTotalHarga = new Label();
            btnSewa = new Button();
            btnPlus = new Button();
            lblHari = new Label();
            btnMinus = new Button();
            dtpMulai = new DateTimePicker();
            lblStok = new Label();
            button1 = new Button();
            panelNavbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbFoto).BeginInit();
            SuspendLayout();
            // 
            // panelNavbar
            // 
            panelNavbar.BackgroundImage = (Image)resources.GetObject("panelNavbar.BackgroundImage");
            panelNavbar.Controls.Add(btnLogout);
            panelNavbar.Controls.Add(btnRiwayat);
            panelNavbar.Controls.Add(btnDaftarAlat);
            panelNavbar.Dock = DockStyle.Top;
            panelNavbar.Location = new Point(0, 0);
            panelNavbar.Name = "panelNavbar";
            panelNavbar.Size = new Size(1898, 117);
            panelNavbar.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.BackgroundImage = (Image)resources.GetObject("btnLogout.BackgroundImage");
            btnLogout.BackgroundImageLayout = ImageLayout.Zoom;
            btnLogout.Location = new Point(1638, 12);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(248, 89);
            btnLogout.TabIndex = 2;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnRiwayat
            // 
            btnRiwayat.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRiwayat.ForeColor = Color.DarkOliveGreen;
            btnRiwayat.Location = new Point(1082, 43);
            btnRiwayat.Name = "btnRiwayat";
            btnRiwayat.Size = new Size(112, 34);
            btnRiwayat.TabIndex = 1;
            btnRiwayat.Text = "RIWAYAT";
            btnRiwayat.UseVisualStyleBackColor = true;
            btnRiwayat.Click += btnRiwayat_Click;
            // 
            // btnDaftarAlat
            // 
            btnDaftarAlat.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDaftarAlat.ForeColor = Color.DarkOliveGreen;
            btnDaftarAlat.Location = new Point(752, 43);
            btnDaftarAlat.Name = "btnDaftarAlat";
            btnDaftarAlat.Size = new Size(165, 34);
            btnDaftarAlat.TabIndex = 0;
            btnDaftarAlat.Text = "DAFTAR ALAT";
            btnDaftarAlat.UseVisualStyleBackColor = true;
            btnDaftarAlat.Click += btnDaftarAlat_Click;
            // 
            // pbFoto
            // 
            pbFoto.Location = new Point(128, 165);
            pbFoto.Name = "pbFoto";
            pbFoto.Size = new Size(601, 409);
            pbFoto.SizeMode = PictureBoxSizeMode.Zoom;
            pbFoto.TabIndex = 1;
            pbFoto.TabStop = false;
            // 
            // lblMerk
            // 
            lblMerk.AutoSize = true;
            lblMerk.BackColor = Color.Transparent;
            lblMerk.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMerk.ForeColor = Color.DarkOliveGreen;
            lblMerk.Location = new Point(765, 180);
            lblMerk.Name = "lblMerk";
            lblMerk.Size = new Size(106, 42);
            lblMerk.TabIndex = 2;
            lblMerk.Text = "Merk";
            // 
            // lblHarga
            // 
            lblHarga.AutoSize = true;
            lblHarga.BackColor = Color.Transparent;
            lblHarga.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHarga.ForeColor = Color.FromArgb(106, 140, 81);
            lblHarga.Location = new Point(848, 290);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(96, 38);
            lblHarga.TabIndex = 3;
            lblHarga.Text = "Harga";
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.BackColor = Color.Transparent;
            lblKategori.Font = new Font("Arial Rounded MT Bold", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKategori.Location = new Point(848, 394);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(77, 18);
            lblKategori.TabIndex = 4;
            lblKategori.Text = "Kategori";
            // 
            // lblBBM
            // 
            lblBBM.AutoSize = true;
            lblBBM.BackColor = Color.Transparent;
            lblBBM.Font = new Font("Arial Rounded MT Bold", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBBM.Location = new Point(880, 354);
            lblBBM.Name = "lblBBM";
            lblBBM.Size = new Size(45, 18);
            lblBBM.TabIndex = 5;
            lblBBM.Text = "BBM";
            // 
            // rtbDeskripsi
            // 
            rtbDeskripsi.Location = new Point(764, 479);
            rtbDeskripsi.Name = "rtbDeskripsi";
            rtbDeskripsi.ReadOnly = true;
            rtbDeskripsi.Size = new Size(743, 80);
            rtbDeskripsi.TabIndex = 6;
            rtbDeskripsi.Text = "";
            rtbDeskripsi.TextChanged += rtbDeskripsi_TextChanged;
            // 
            // lblTotalHarga
            // 
            lblTotalHarga.AutoSize = true;
            lblTotalHarga.BackColor = Color.Transparent;
            lblTotalHarga.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalHarga.ForeColor = Color.FromArgb(106, 134, 81);
            lblTotalHarga.Location = new Point(1561, 780);
            lblTotalHarga.Name = "lblTotalHarga";
            lblTotalHarga.Size = new Size(42, 48);
            lblTotalHarga.TabIndex = 8;
            lblTotalHarga.Text = "0";
            // 
            // btnSewa
            // 
            btnSewa.BackColor = Color.FromArgb(57, 105, 29);
            btnSewa.Font = new Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSewa.ForeColor = Color.White;
            btnSewa.Location = new Point(679, 907);
            btnSewa.Name = "btnSewa";
            btnSewa.Size = new Size(1139, 66);
            btnSewa.TabIndex = 7;
            btnSewa.Text = "Sewa Sekarang";
            btnSewa.UseVisualStyleBackColor = false;
            btnSewa.Click += btnSewa_Click;
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(885, 775);
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
            lblHari.BackColor = Color.Transparent;
            lblHari.Font = new Font("Bookman Old Style", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHari.ForeColor = Color.DarkOliveGreen;
            lblHari.Location = new Point(740, 780);
            lblHari.Name = "lblHari";
            lblHari.Size = new Size(32, 32);
            lblHari.TabIndex = 4;
            lblHari.Text = "1";
            // 
            // btnMinus
            // 
            btnMinus.Location = new Point(566, 775);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(35, 34);
            btnMinus.TabIndex = 3;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // dtpMulai
            // 
            dtpMulai.CalendarFont = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpMulai.CalendarForeColor = Color.DarkOliveGreen;
            dtpMulai.CalendarTitleForeColor = Color.DarkOliveGreen;
            dtpMulai.CalendarTrailingForeColor = SystemColors.GradientInactiveCaption;
            dtpMulai.Location = new Point(128, 778);
            dtpMulai.Name = "dtpMulai";
            dtpMulai.Size = new Size(360, 31);
            dtpMulai.TabIndex = 1;
            // 
            // lblStok
            // 
            lblStok.AutoSize = true;
            lblStok.BackColor = Color.Transparent;
            lblStok.Font = new Font("Arial Rounded MT Bold", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStok.Location = new Point(820, 434);
            lblStok.Name = "lblStok";
            lblStok.Size = new Size(44, 18);
            lblStok.TabIndex = 13;
            lblStok.Text = "Stok";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(224, 224, 224);
            button1.Font = new Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.DimGray;
            button1.Location = new Point(128, 907);
            button1.Name = "button1";
            button1.Size = new Size(523, 66);
            button1.TabIndex = 14;
            button1.Text = "Kembali";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormDetailAlat
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1898, 1024);
            Controls.Add(button1);
            Controls.Add(lblTotalHarga);
            Controls.Add(btnSewa);
            Controls.Add(lblStok);
            Controls.Add(lblHari);
            Controls.Add(btnPlus);
            Controls.Add(btnMinus);
            Controls.Add(rtbDeskripsi);
            Controls.Add(dtpMulai);
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
        private DateTimePicker dtpMulai;
        private Button btnSewa;
        private Button btnPlus;
        private Label lblHari;
        private Button btnMinus;
        private Label lblTotalHarga;
        private Button btnLogout;
        private Button btnRiwayat;
        private Button btnDaftarAlat;
        private Label lblStok;
        private Button button1;
    }
}