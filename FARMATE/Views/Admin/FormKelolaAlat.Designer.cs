namespace FARMATE.Views.Admin
{
    partial class FormKelolaAlat
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
            panelSidebar = new Panel();
            btnHapus = new Button();
            btnEdit = new Button();
            btnTambah = new Button();
            panelTambahAlat = new Panel();
            btnPilihGambar = new Button();
            pbFotoAlat = new PictureBox();
            btnBatal = new Button();
            btnSimpan = new Button();
            cmbBBM = new ComboBox();
            cmbKategori = new ComboBox();
            txtStok = new TextBox();
            txtHarga = new TextBox();
            txtDeskripsi = new TextBox();
            txtMerk = new TextBox();
            lblBBM = new Label();
            lblStok = new Label();
            lblHarga = new Label();
            lblDeskripsi = new Label();
            lblMerk = new Label();
            lblKategori = new Label();
            btnLogout = new Button();
            panelNavbar = new Panel();
            btnDataUser = new Button();
            btnRiwayat = new Button();
            btnKelolaAlat = new Button();
            panelContent = new Panel();
            flowPanen = new FlowLayoutPanel();
            flowTraktor = new FlowLayoutPanel();
            flowDrone = new FlowLayoutPanel();
            panelSidebar.SuspendLayout();
            panelTambahAlat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbFotoAlat).BeginInit();
            panelNavbar.SuspendLayout();
            panelContent.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.Controls.Add(btnHapus);
            panelSidebar.Controls.Add(btnEdit);
            panelSidebar.Controls.Add(btnTambah);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(233, 1050);
            panelSidebar.TabIndex = 0;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(62, 242);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(112, 34);
            btnHapus.TabIndex = 2;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += btnHapus_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(62, 190);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 34);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(62, 136);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(112, 34);
            btnTambah.TabIndex = 0;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click;
            // 
            // panelTambahAlat
            // 
            panelTambahAlat.BackColor = SystemColors.Window;
            panelTambahAlat.BorderStyle = BorderStyle.FixedSingle;
            panelTambahAlat.Controls.Add(btnPilihGambar);
            panelTambahAlat.Controls.Add(pbFotoAlat);
            panelTambahAlat.Controls.Add(btnBatal);
            panelTambahAlat.Controls.Add(btnSimpan);
            panelTambahAlat.Controls.Add(cmbBBM);
            panelTambahAlat.Controls.Add(cmbKategori);
            panelTambahAlat.Controls.Add(txtStok);
            panelTambahAlat.Controls.Add(txtHarga);
            panelTambahAlat.Controls.Add(txtDeskripsi);
            panelTambahAlat.Controls.Add(txtMerk);
            panelTambahAlat.Controls.Add(lblBBM);
            panelTambahAlat.Controls.Add(lblStok);
            panelTambahAlat.Controls.Add(lblHarga);
            panelTambahAlat.Controls.Add(lblDeskripsi);
            panelTambahAlat.Controls.Add(lblMerk);
            panelTambahAlat.Controls.Add(lblKategori);
            panelTambahAlat.Location = new Point(356, 682);
            panelTambahAlat.Name = "panelTambahAlat";
            panelTambahAlat.Size = new Size(594, 333);
            panelTambahAlat.TabIndex = 3;
            panelTambahAlat.Visible = false;
            // 
            // btnPilihGambar
            // 
            btnPilihGambar.Location = new Point(68, 173);
            btnPilihGambar.Name = "btnPilihGambar";
            btnPilihGambar.Size = new Size(138, 34);
            btnPilihGambar.TabIndex = 15;
            btnPilihGambar.Text = "Pilih Gambar";
            btnPilihGambar.UseVisualStyleBackColor = true;
            btnPilihGambar.Click += btnPilihGambar_Click;
            // 
            // pbFotoAlat
            // 
            pbFotoAlat.BorderStyle = BorderStyle.FixedSingle;
            pbFotoAlat.Location = new Point(40, 13);
            pbFotoAlat.Name = "pbFotoAlat";
            pbFotoAlat.Size = new Size(180, 140);
            pbFotoAlat.TabIndex = 14;
            pbFotoAlat.TabStop = false;
            pbFotoAlat.Click += pbFotoAlat_Click;
            // 
            // btnBatal
            // 
            btnBatal.Location = new Point(145, 259);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(72, 34);
            btnBatal.TabIndex = 13;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = true;
            btnBatal.Click += btnBatal_Click;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(40, 259);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(88, 34);
            btnSimpan.TabIndex = 12;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // cmbBBM
            // 
            cmbBBM.FormattingEnabled = true;
            cmbBBM.Location = new Point(444, 248);
            cmbBBM.Name = "cmbBBM";
            cmbBBM.Size = new Size(108, 33);
            cmbBBM.TabIndex = 11;
            // 
            // cmbKategori
            // 
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(287, 41);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(92, 33);
            cmbKategori.TabIndex = 10;
            // 
            // txtStok
            // 
            txtStok.Location = new Point(280, 248);
            txtStok.Name = "txtStok";
            txtStok.Size = new Size(99, 31);
            txtStok.TabIndex = 9;
            // 
            // txtHarga
            // 
            txtHarga.Location = new Point(448, 148);
            txtHarga.Name = "txtHarga";
            txtHarga.Size = new Size(104, 31);
            txtHarga.TabIndex = 8;
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.Location = new Point(287, 148);
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(92, 31);
            txtDeskripsi.TabIndex = 7;
            // 
            // txtMerk
            // 
            txtMerk.Location = new Point(448, 41);
            txtMerk.Name = "txtMerk";
            txtMerk.Size = new Size(104, 31);
            txtMerk.TabIndex = 6;
            // 
            // lblBBM
            // 
            lblBBM.AutoSize = true;
            lblBBM.Location = new Point(444, 220);
            lblBBM.Name = "lblBBM";
            lblBBM.Size = new Size(108, 25);
            lblBBM.TabIndex = 5;
            lblBBM.Text = "Bahan Bakar";
            // 
            // lblStok
            // 
            lblStok.AutoSize = true;
            lblStok.Location = new Point(295, 220);
            lblStok.Name = "lblStok";
            lblStok.Size = new Size(47, 25);
            lblStok.TabIndex = 4;
            lblStok.Text = "Stok";
            // 
            // lblHarga
            // 
            lblHarga.AutoSize = true;
            lblHarga.Location = new Point(472, 120);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(60, 25);
            lblHarga.TabIndex = 3;
            lblHarga.Text = "Harga";
            // 
            // lblDeskripsi
            // 
            lblDeskripsi.AutoSize = true;
            lblDeskripsi.Location = new Point(295, 120);
            lblDeskripsi.Name = "lblDeskripsi";
            lblDeskripsi.Size = new Size(84, 25);
            lblDeskripsi.TabIndex = 2;
            lblDeskripsi.Text = "Deskripsi";
            // 
            // lblMerk
            // 
            lblMerk.AutoSize = true;
            lblMerk.Location = new Point(472, 13);
            lblMerk.Name = "lblMerk";
            lblMerk.Size = new Size(52, 25);
            lblMerk.TabIndex = 1;
            lblMerk.Text = "Merk";
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.Location = new Point(295, 13);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(78, 25);
            lblKategori.TabIndex = 0;
            lblKategori.Text = "Kategori";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(1175, 47);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(112, 34);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // panelNavbar
            // 
            panelNavbar.Controls.Add(btnLogout);
            panelNavbar.Controls.Add(btnDataUser);
            panelNavbar.Controls.Add(btnRiwayat);
            panelNavbar.Controls.Add(btnKelolaAlat);
            panelNavbar.Dock = DockStyle.Top;
            panelNavbar.Location = new Point(233, 0);
            panelNavbar.Name = "panelNavbar";
            panelNavbar.Size = new Size(1361, 130);
            panelNavbar.TabIndex = 1;
            panelNavbar.Paint += panelNavbar_Paint;
            // 
            // btnDataUser
            // 
            btnDataUser.Location = new Point(641, 47);
            btnDataUser.Name = "btnDataUser";
            btnDataUser.Size = new Size(112, 34);
            btnDataUser.TabIndex = 2;
            btnDataUser.Text = "Data User";
            btnDataUser.UseVisualStyleBackColor = true;
            btnDataUser.Click += btnDataUser_Click;
            // 
            // btnRiwayat
            // 
            btnRiwayat.Location = new Point(443, 47);
            btnRiwayat.Name = "btnRiwayat";
            btnRiwayat.Size = new Size(112, 34);
            btnRiwayat.TabIndex = 1;
            btnRiwayat.Text = "Riwayat";
            btnRiwayat.UseVisualStyleBackColor = true;
            btnRiwayat.Click += btnRiwayat_Click;
            // 
            // btnKelolaAlat
            // 
            btnKelolaAlat.Location = new Point(262, 47);
            btnKelolaAlat.Name = "btnKelolaAlat";
            btnKelolaAlat.Size = new Size(112, 34);
            btnKelolaAlat.TabIndex = 0;
            btnKelolaAlat.Text = "Kelola Alat";
            btnKelolaAlat.UseVisualStyleBackColor = true;
            btnKelolaAlat.Click += btnKelolaAlat_Click;
            // 
            // panelContent
            // 
            panelContent.Controls.Add(flowPanen);
            panelContent.Controls.Add(flowTraktor);
            panelContent.Controls.Add(flowDrone);
            panelContent.Location = new Point(233, 130);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1137, 546);
            panelContent.TabIndex = 2;
            // 
            // flowPanen
            // 
            flowPanen.AutoScroll = true;
            flowPanen.Location = new Point(18, 369);
            flowPanen.Name = "flowPanen";
            flowPanen.Size = new Size(1107, 150);
            flowPanen.TabIndex = 2;
            flowPanen.WrapContents = false;
            // 
            // flowTraktor
            // 
            flowTraktor.AutoScroll = true;
            flowTraktor.Location = new Point(18, 177);
            flowTraktor.Name = "flowTraktor";
            flowTraktor.Size = new Size(1107, 169);
            flowTraktor.TabIndex = 1;
            flowTraktor.WrapContents = false;
            // 
            // flowDrone
            // 
            flowDrone.AutoScroll = true;
            flowDrone.Location = new Point(16, 6);
            flowDrone.Name = "flowDrone";
            flowDrone.Size = new Size(1109, 153);
            flowDrone.TabIndex = 0;
            flowDrone.WrapContents = false;
            flowDrone.Paint += flowDrone_Paint;
            // 
            // FormKelolaAlat
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1594, 1050);
            Controls.Add(panelTambahAlat);
            Controls.Add(panelContent);
            Controls.Add(panelNavbar);
            Controls.Add(panelSidebar);
            Name = "FormKelolaAlat";
            Text = "FormKelolaAlat";
            Load += FormKelolaAlat_Load;
            panelSidebar.ResumeLayout(false);
            panelTambahAlat.ResumeLayout(false);
            panelTambahAlat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbFotoAlat).EndInit();
            panelNavbar.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSidebar;
        private Panel panelNavbar;
        private Panel panelContent;
        private FlowLayoutPanel flowPanen;
        private FlowLayoutPanel flowTraktor;
        private FlowLayoutPanel flowDrone;
        private Button btnLogout;
        private Button btnHapus;
        private Button btnEdit;
        private Button btnTambah;
        private Panel panelTambahAlat;
        private Label lblHarga;
        private Label lblDeskripsi;
        private Label lblMerk;
        private Label lblKategori;
        private Button btnSimpan;
        private ComboBox cmbBBM;
        private ComboBox cmbKategori;
        private TextBox txtStok;
        private TextBox txtHarga;
        private TextBox txtDeskripsi;
        private TextBox txtMerk;
        private Label lblBBM;
        private Label lblStok;
        private Button btnBatal;
        private Button btnPilihGambar;
        private PictureBox pbFotoAlat;
        private Button btnRiwayat;
        private Button btnKelolaAlat;
        private Button btnDataUser;
    }
}