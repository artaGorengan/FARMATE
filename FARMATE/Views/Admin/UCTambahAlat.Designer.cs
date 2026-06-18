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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCTambahAlat));
            pbFotoAlat = new PictureBox();
            btnPilihGambar = new Button();
            cmbKategori = new ComboBox();
            txtMerk = new TextBox();
            txtHarga = new TextBox();
            txtStok = new TextBox();
            cmbBBM = new ComboBox();
            btnSimpan = new Button();
            btnBatal = new Button();
            RTBDeskripsi = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pbFotoAlat).BeginInit();
            SuspendLayout();
            // 
            // pbFotoAlat
            // 
            pbFotoAlat.BackgroundImageLayout = ImageLayout.Zoom;
            pbFotoAlat.Location = new Point(34, 55);
            pbFotoAlat.Name = "pbFotoAlat";
            pbFotoAlat.Size = new Size(371, 390);
            pbFotoAlat.SizeMode = PictureBoxSizeMode.Zoom;
            pbFotoAlat.TabIndex = 15;
            pbFotoAlat.TabStop = false;
            // 
            // btnPilihGambar
            // 
            btnPilihGambar.BackgroundImageLayout = ImageLayout.Zoom;
            btnPilihGambar.Image = (Image)resources.GetObject("btnPilihGambar.Image");
            btnPilihGambar.Location = new Point(143, 451);
            btnPilihGambar.Name = "btnPilihGambar";
            btnPilihGambar.Size = new Size(138, 34);
            btnPilihGambar.TabIndex = 16;
            btnPilihGambar.UseVisualStyleBackColor = true;
            btnPilihGambar.Click += btnPilihGambar_Click;
            // 
            // cmbKategori
            // 
            cmbKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKategori.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbKategori.ForeColor = Color.DarkOliveGreen;
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(451, 72);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(265, 29);
            cmbKategori.TabIndex = 17;
            // 
            // txtMerk
            // 
            txtMerk.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMerk.ForeColor = Color.DarkOliveGreen;
            txtMerk.Location = new Point(451, 141);
            txtMerk.Name = "txtMerk";
            txtMerk.Size = new Size(265, 28);
            txtMerk.TabIndex = 20;
            // 
            // txtHarga
            // 
            txtHarga.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHarga.ForeColor = Color.DarkOliveGreen;
            txtHarga.Location = new Point(451, 230);
            txtHarga.Name = "txtHarga";
            txtHarga.Size = new Size(265, 28);
            txtHarga.TabIndex = 24;
            // 
            // txtStok
            // 
            txtStok.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStok.ForeColor = Color.DarkOliveGreen;
            txtStok.Location = new Point(451, 318);
            txtStok.Name = "txtStok";
            txtStok.Size = new Size(265, 28);
            txtStok.TabIndex = 26;
            // 
            // cmbBBM
            // 
            cmbBBM.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBBM.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbBBM.ForeColor = Color.DarkOliveGreen;
            cmbBBM.FormattingEnabled = true;
            cmbBBM.Location = new Point(451, 403);
            cmbBBM.Name = "cmbBBM";
            cmbBBM.Size = new Size(265, 29);
            cmbBBM.TabIndex = 28;
            // 
            // btnSimpan
            // 
            btnSimpan.Image = (Image)resources.GetObject("btnSimpan.Image");
            btnSimpan.Location = new Point(52, 711);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(88, 34);
            btnSimpan.TabIndex = 29;
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnBatal
            // 
            btnBatal.Image = (Image)resources.GetObject("btnBatal.Image");
            btnBatal.Location = new Point(197, 711);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(72, 34);
            btnBatal.TabIndex = 30;
            btnBatal.UseVisualStyleBackColor = true;
            btnBatal.Click += btnBatal_Click;
            // 
            // RTBDeskripsi
            // 
            RTBDeskripsi.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RTBDeskripsi.ForeColor = Color.DarkOliveGreen;
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
            BackColor = Color.Transparent;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            Controls.Add(RTBDeskripsi);
            Controls.Add(btnBatal);
            Controls.Add(btnSimpan);
            Controls.Add(cmbBBM);
            Controls.Add(txtStok);
            Controls.Add(txtHarga);
            Controls.Add(txtMerk);
            Controls.Add(cmbKategori);
            Controls.Add(btnPilihGambar);
            Controls.Add(pbFotoAlat);
            Location = new Point(0, 100);
            Name = "UCTambahAlat";
            Size = new Size(750, 809);
            Load += UCTambahAlat_Load;
            ((System.ComponentModel.ISupportInitialize)pbFotoAlat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbFotoAlat;
        private Button btnPilihGambar;
        private ComboBox cmbKategori;
        private TextBox txtMerk;
        private TextBox txtHarga;
        private TextBox txtStok;
        private ComboBox cmbBBM;
        private Button btnSimpan;
        private Button btnBatal;
        private RichTextBox RTBDeskripsi;
    }
}
