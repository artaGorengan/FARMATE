namespace FARMATE.Views.Admin
{
    partial class UCTambahAlat
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
            pbFotoAlat = new PictureBox();
            btnPilihGambar = new Button();
            cmbKategori = new ComboBox();
            lblKategori = new Label();
            lblMerk = new Label();
            txtMerk = new TextBox();
            lblDeskripsi = new Label();
            lblHarga = new Label();
            txtHarga = new TextBox();
            lblStok = new Label();
            txtStok = new TextBox();
            lblBBM = new Label();
            cmbBBM = new ComboBox();
            btnSimpan = new Button();
            btnBatal = new Button();
            RTBDeskripsi = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pbFotoAlat).BeginInit();
            SuspendLayout();
            // 
            // pbFotoAlat
            // 
            pbFotoAlat.Location = new Point(23, 27);
            pbFotoAlat.Name = "pbFotoAlat";
            pbFotoAlat.Size = new Size(374, 390);
            pbFotoAlat.SizeMode = PictureBoxSizeMode.Zoom;
            pbFotoAlat.TabIndex = 15;
            pbFotoAlat.TabStop = false;
            // 
            // btnPilihGambar
            // 
            btnPilihGambar.Location = new Point(131, 450);
            btnPilihGambar.Name = "btnPilihGambar";
            btnPilihGambar.Size = new Size(138, 34);
            btnPilihGambar.TabIndex = 16;
            btnPilihGambar.Text = "Pilih Gambar";
            btnPilihGambar.UseVisualStyleBackColor = true;
            btnPilihGambar.Click += btnPilihGambar_Click;
            // 
            // cmbKategori
            // 
            cmbKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(425, 55);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(265, 33);
            cmbKategori.TabIndex = 17;
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.Location = new Point(425, 27);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(78, 25);
            lblKategori.TabIndex = 18;
            lblKategori.Text = "Kategori";
            // 
            // lblMerk
            // 
            lblMerk.AutoSize = true;
            lblMerk.Location = new Point(451, 108);
            lblMerk.Name = "lblMerk";
            lblMerk.Size = new Size(52, 25);
            lblMerk.TabIndex = 19;
            lblMerk.Text = "Merk";
            // 
            // txtMerk
            // 
            txtMerk.Location = new Point(425, 136);
            txtMerk.Name = "txtMerk";
            txtMerk.Size = new Size(265, 31);
            txtMerk.TabIndex = 20;
            // 
            // lblDeskripsi
            // 
            lblDeskripsi.AutoSize = true;
            lblDeskripsi.Location = new Point(23, 506);
            lblDeskripsi.Name = "lblDeskripsi";
            lblDeskripsi.Size = new Size(84, 25);
            lblDeskripsi.TabIndex = 21;
            lblDeskripsi.Text = "Deskripsi";
            // 
            // lblHarga
            // 
            lblHarga.AutoSize = true;
            lblHarga.Location = new Point(451, 185);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(60, 25);
            lblHarga.TabIndex = 23;
            lblHarga.Text = "Harga";
            // 
            // txtHarga
            // 
            txtHarga.Location = new Point(425, 213);
            txtHarga.Name = "txtHarga";
            txtHarga.Size = new Size(265, 31);
            txtHarga.TabIndex = 24;
            // 
            // lblStok
            // 
            lblStok.AutoSize = true;
            lblStok.Location = new Point(456, 268);
            lblStok.Name = "lblStok";
            lblStok.Size = new Size(47, 25);
            lblStok.TabIndex = 25;
            lblStok.Text = "Stok";
            // 
            // txtStok
            // 
            txtStok.Location = new Point(430, 296);
            txtStok.Name = "txtStok";
            txtStok.Size = new Size(260, 31);
            txtStok.TabIndex = 26;
            // 
            // lblBBM
            // 
            lblBBM.AutoSize = true;
            lblBBM.Location = new Point(430, 349);
            lblBBM.Name = "lblBBM";
            lblBBM.Size = new Size(108, 25);
            lblBBM.TabIndex = 27;
            lblBBM.Text = "Bahan Bakar";
            // 
            // cmbBBM
            // 
            cmbBBM.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBBM.FormattingEnabled = true;
            cmbBBM.Location = new Point(430, 384);
            cmbBBM.Name = "cmbBBM";
            cmbBBM.Size = new Size(260, 33);
            cmbBBM.TabIndex = 28;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(52, 711);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(88, 34);
            btnSimpan.TabIndex = 29;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnBatal
            // 
            btnBatal.Location = new Point(197, 711);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(72, 34);
            btnBatal.TabIndex = 30;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = true;
            btnBatal.Click += btnBatal_Click;
            // 
            // RTBDeskripsi
            // 
            RTBDeskripsi.Location = new Point(23, 543);
            RTBDeskripsi.Name = "RTBDeskripsi";
            RTBDeskripsi.Size = new Size(678, 142);
            RTBDeskripsi.TabIndex = 31;
            RTBDeskripsi.Text = "";
            // 
            // UCTambahAlat
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(RTBDeskripsi);
            Controls.Add(btnBatal);
            Controls.Add(btnSimpan);
            Controls.Add(cmbBBM);
            Controls.Add(lblBBM);
            Controls.Add(txtStok);
            Controls.Add(lblStok);
            Controls.Add(txtHarga);
            Controls.Add(lblHarga);
            Controls.Add(lblDeskripsi);
            Controls.Add(txtMerk);
            Controls.Add(lblMerk);
            Controls.Add(lblKategori);
            Controls.Add(cmbKategori);
            Controls.Add(btnPilihGambar);
            Controls.Add(pbFotoAlat);
            Name = "UCTambahAlat";
            Size = new Size(741, 809);
            Load += UCTambahAlat_Load;
            ((System.ComponentModel.ISupportInitialize)pbFotoAlat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbFotoAlat;
        private Button btnPilihGambar;
        private ComboBox cmbKategori;
        private Label lblKategori;
        private Label lblMerk;
        private TextBox txtMerk;
        private Label lblDeskripsi;
        private Label lblHarga;
        private TextBox txtHarga;
        private Label lblStok;
        private TextBox txtStok;
        private Label lblBBM;
        private ComboBox cmbBBM;
        private Button btnSimpan;
        private Button btnBatal;
        private RichTextBox RTBDeskripsi;
    }
}
